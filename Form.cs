using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ST_QrPrint
{
	enum PrintType
	{
		PlayerCode,
		GameCode,
	}

    public partial class FormQr : Form
    {
		// A4: 210mm x 297mm
		const float margin_h = 8.5f; //mm
		const float margin_v = 9.0f; //mm
		float cel_width  = 48.3f;
		float cel_height = 25.4f;
		float id_top_mm = 8.25f;
		float id_left_mm = 22.5f;

		// http://www.mimosa.gr.jp/oa_label/17_1882.html
		// LDW44CEX
		// left 8.5mm
		// top 9.0mm
		// 48.3 x 25.4


		private DotNetBarcode barcode = new DotNetBarcode();
		private Font font;
		private static Random rand = new Random();

        public FormQr()
        {
            InitializeComponent();
			this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			this.BackColor = Color.Transparent;
		}

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

		static void apply(PictureBox obj, PictureBox child, Image img)
		{
			child.Parent = obj;
			child.BackColor = Color.Transparent;
			child.BackgroundImage = img;
			
			// Bottom, Right
			child.Location = new Point(
				obj.Size.Width - child.Size.Width,
				obj.Size.Height - child.Size.Height);
		}

        private void Form1_Load(object sender, EventArgs e)
        {
			var okay = ST_QrPrint.Properties.Resources.dialog_ok_2;

			apply(
				pictureDatabase,
				pictureDatabaseStatus,
				okay);
			apply(
				picturePrinter,
				picturePrinterStatus,
				okay);




            DotNetBarcode barcode = new DotNetBarcode();
            barcode.Type = DotNetBarcode.Types.QRCode;

			textBoxServerState.Text =
				"良好";

			PrintDocument pd = new PrintDocument();
			var prn = pd.PrinterSettings.DefaultPageSettings;
			textBoxPrinterState.Text =
				pd.PrinterSettings.PrinterName+"\r\n"+
				prn.PrinterResolution.X+"x"+prn.PrinterResolution.Y+"dpi\r\n"+
				prn.PaperSize.Kind.ToString()+"\r\n";
		}

        private void FormQr_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pd_PrintPlayerCode(object sender, PrintPageEventArgs e)
        {
			pd_PrintPage(PrintType.PlayerCode, sender, e);
		}

		delegate void PrintDelegate(object sender, PrintPageEventArgs e);

        private void pd_PrintGameCode(object sender, PrintPageEventArgs e)
        {
			pd_PrintPage(PrintType.GameCode, sender, e);
		}

		static string GetShortId(string id)
		{
			// P00001234 => 1234
			// G00000ABC59 => ABC59
			for (int i=1; i<id.Length; ++i)
			{
				if (id[i]=='0')
				{
					// skip zero
					continue;
				}
				return id.Substring(i);
			}
			return id;
		}

		private void pd_PrintPage(PrintType print_type, object sender, PrintPageEventArgs e)
        {
            Debug.Print("hello");
            Debug.Print(e.MarginBounds.Right.ToString());
            Debug.Print(e.MarginBounds.Bottom.ToString());
            Debug.Print(e.MarginBounds.ToString());

			const int W = 4;
			const int H = 11;

			string[] ids;
			try
			{
				ids = GetIdsFromDatabase(print_type, W*H);
			}
			catch (MySqlException ex)
			{
				textBoxSqlStatus.Text = ex.Message;
				return;
			}

            var g = e.Graphics;

			float font_pt = (print_type==PrintType.PlayerCode) ? 24.0f : 20.0f;
			if (font!=null)
			{
				font.Dispose();
			}
			font = new Font("Courier New", font_pt, FontStyle.Bold);


			const float to_inch = 1 / 0.254f;
			string prefix = (print_type==PrintType.PlayerCode) ? "P" : "G";

			int i = 0;
            for (int y=0; y<H; ++y)
            {
                for (int x=0; x<W; ++x, ++i)
                {
					string full_id = prefix + ids[i];
					string short_id = GetShortId(ids[i]);

					const int qr_width = 3;
					barcode.QRCopyToClipboard(full_id, qr_width);
					Image img = Clipboard.GetImage();
					Debug.Print(img.Width.ToString());
					Debug.Print(img.Height.ToString());
					int qr_size = img.Width;
					int text_width = (int)g.MeasureString(short_id, font).Width;

					float dx = x * cel_width  + margin_h;
					float dy = y * cel_height + margin_v;

                    g.DrawRectangle(
                        //(x+y)%2==0 ? Pens.Red : Pens.Black,
						Pens.Black,
						to_inch * dx,
						to_inch * dy,
						to_inch * cel_width ,
						to_inch * cel_height);
					//barcode.QRBackColorTimingPattern = Color.Red;
					barcode.BackGroundColor = Color.Transparent;
                    barcode.QRWriteBar(full_id,
						   to_inch * (dx + 2),
						   to_inch * (dy + 2),
                           qr_width, e.Graphics);
					g.DrawString(short_id, font, Brushes.Black,
                           new PointF(
							   to_inch * (dx + id_left_mm),
							   to_inch * (dy + id_top_mm)));
                }
            }
            e.HasMorePages = false;
        }

		private void FormQr_Activated(object sender, EventArgs e)
		{
			this.BackColor = SystemColors.GradientActiveCaption;
			this.Opacity = 1.0f;
		}

		private void FormQr_Deactivate(object sender, EventArgs e)
		{
			this.BackColor = SystemColors.GradientInactiveCaption;
			this.Opacity = 0.9f;
		}

		MySqlConnection conn_keep_alive;

		MySqlConnection connect_to_db()
		{
			if (conn_keep_alive!=null && conn_keep_alive.State==System.Data.ConnectionState.Open)
			{
				return conn_keep_alive;
			}

			string connection_string = string.Empty;
			connection_string += "Server = ST_SERVER;";
			connection_string += "User ID = st_user;";
			connection_string += "Password = eureka;";
			connection_string += "Database = st;";

			var conn = new MySqlConnection(connection_string);
			conn.Open();
			conn_keep_alive = conn;
			return conn;
		}

		static char GetRandomChar(bool include_zero)
		{
			const string all = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
			return include_zero
				? all[rand.Next()%36]
				: all[rand.Next()%35+1];
		}
		
		static string GetRandomId(PrintType print_type)
		{
			if (print_type==PrintType.PlayerCode)
			{
				string id = "0000";
				id += GetRandomChar(false);
				id += GetRandomChar(true);
				id += GetRandomChar(true);
				id += GetRandomChar(true);
				return id;
			}
			else
			{
				string id = "00000";
				id += GetRandomChar(false);
				id += GetRandomChar(true);
				id += GetRandomChar(true);
				id += GetRandomChar(true);
				id += GetRandomChar(true);
				return id;
			}
		}

		string[] GetIdsFromDatabase(PrintType print_type, int count)
		{
			MySqlConnection conn = connect_to_db();

			var ids = new System.Collections.ArrayList(count);
			string all_ids = "";

			string table_name =
				(print_type==PrintType.GameCode)
					? "records"
					: "users";			
			for (int i=0; i<count; ++i)
			{
				for (int tries=0; tries<10; ++tries)
				{
					var date = DateTime.Now;
					string user_id = GetRandomId(print_type);

					string query =
						"INSERT INTO "+table_name+" "+
						"(player_id,created) values "+
						"('"+user_id+"','"+date.ToString("yyyy-MM-dd HH:mm:ss")+"')";
					var command =new MySqlCommand(query, conn);
					try
					{
						command.ExecuteNonQuery();
						ids.Add(user_id);
						all_ids += user_id;
						if (tries>0)
						{
							all_ids += "(" + (tries).ToString() + ")";
						}
						all_ids += " ";
						break;
					}
					catch (MySqlException ex)
					{
						if (ex.ErrorCode==-2147467259)
						{
							continue;
						}
						else
						{
							textBoxSqlStatus.Text = "SQL ERROR";
							break;
						}
					}
				}
			}

			var retval = (string[])ids.ToArray(typeof(string));		
			textBoxSqlStatus.Text = all_ids;
			return retval;
		}


		private void button1_Click(object sender, EventArgs e)
		{
			textBoxSqlStatus.Text = "Connecting...";

			string[] ids;
			try
			{
				ids = GetIdsFromDatabase(PrintType.PlayerCode, 30);
			}
			catch (MySqlException ex)
			{
				textBoxSqlStatus.Text = ex.Message;
				return;
			}

#if false			
			{
				var command = conn.CreateCommand();
				command.CommandText = "SELECT * FROM player";
				var reader = command.ExecuteReader();
				command.Dispose();

				while (reader.Read())
				{
					textBoxSqlStatus.Text =
							"ID:"+reader["id"].ToString()+" "+
							"DATE:"+reader["register"].ToString();
				}
				command.Connection.Close();
			}
#endif
		}

		private void buttonRemoveUnusedIds_Click(object sender, EventArgs e)
		{			
			MySqlConnection conn;
			textBoxSqlStatus.Text = "Connecting...";

			try
			{
				conn = connect_to_db();
			}
			catch (MySqlException ex)
			{
				textBoxSqlStatus.Text = ex.Message;
				return;
			}

			{
				string query =
					"DELETE FROM users "+
					"WHERE is_synced=0";
				var command = new MySqlCommand(query, conn);
				try
				{
					int resval = command.ExecuteNonQuery();
					textBoxSqlStatus.Text = resval.ToString()+"コの未使用IDを削除しました。";
				}
				catch (MySqlException ex)
				{
					textBoxSqlStatus.Text = ex.ToString();
				}
			}

			conn.Close();
			conn.Dispose();
		}

		private void FormQr_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (conn_keep_alive!=null && conn_keep_alive.State==System.Data.ConnectionState.Open)
			{
				conn_keep_alive.Close();
				conn_keep_alive.Dispose();
			}
		}

		private void buttonExit_Click_1(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void buttonPrintGameCode_Click(object sender, EventArgs e)
		{
			PrintCommon(pd_PrintGameCode, sender, e);
		}

		private void buttonPrint_Click(object sender, EventArgs e)
		{
			PrintCommon(pd_PrintPlayerCode, sender, e);
		}

		private void PrintCommon(PrintDelegate print, object sender, EventArgs e)
		{
			var pd = new PrintDocument();
			pd.PrintPage += new PrintPageEventHandler(print);

			if (checkPrintWithoutPreview.Checked)
			{
				pd.Print();
			}
			else
			{
				var ppd = new PrintPreviewDialog();
				ppd.Document = pd;
				ppd.ShowDialog();
			}
		}
	}
}
