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
    public partial class FormQr : Form
    {
		// A4: 210mm x 297mm
		const float margin_h = 8.5f; //mm
		const float margin_v = 9.0f; //mm
		float cel_width  = 48.3f;
		float cel_height = 25.4f;
		float font_pt = 24.0f;
		float id_top_mm = 8.25f;
		float id_left_mm = 22.5f;

		// http://www.mimosa.gr.jp/oa_label/17_1882.html
		// LDW44CEX
		// left 8.5mm
		// top 9.0mm
		// 48.3 x 25.4


		private DotNetBarcode barcode = new DotNetBarcode();

		Font font;

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

            font = new Font("Courier New", font_pt, FontStyle.Bold);

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

        private void pd_PrintPage(object sender, PrintPageEventArgs e)
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
				ids = GetIdsFromDatabase(W*H);
			}
			catch (MySqlException ex)
			{
				textBoxSqlStatus.Text = ex.Message;
				return;
			}

            var g = e.Graphics;

			const float to_inch = 1 / 0.254f;

			int i = 0;
            for (int y=0; y<H; ++y)
            {
                for (int x=0; x<W; ++x, ++i)
                {
					const int qr_width = 3;
					barcode.QRCopyToClipboard(ids[i], qr_width);
					Image img = Clipboard.GetImage();
					Debug.Print(img.Width.ToString());
					Debug.Print(img.Height.ToString());
					int qr_size = img.Width;
					int text_width = (int)g.MeasureString(ids[i], font).Width;

					float dx = x * cel_width  + margin_h;
					float dy = y * cel_height + margin_v;

                    g.DrawRectangle(
                        (x+y)%2==0 ? Pens.Red : Pens.Black,
						to_inch * dx,
						to_inch * dy,
						to_inch * cel_width ,
						to_inch * cel_height);
					barcode.QRBackColorTimingPattern = Color.Red;
					barcode.BackGroundColor = Color.Transparent;
                    barcode.QRWriteBar(ids[i],
						   to_inch * (dx + 2),
						   to_inch * (dy + 2),
                           qr_width, e.Graphics);
					g.DrawString(ids[i], font, Brushes.Black,
                           new PointF(
							   to_inch * (dx + id_left_mm),
							   to_inch * (dy + id_top_mm)));
                }
            }
            e.HasMorePages = false;
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            var pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);

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
			connection_string += "Server = localhost;";
			connection_string += "User ID = st_user;";
			connection_string += "Password = eureka;";
			connection_string += "Database = ST;";

			var conn = new MySqlConnection(connection_string);
			conn.Open();
			conn_keep_alive = conn;
			return conn;
		}

		string[] GetIdsFromDatabase(int count)
		{
			MySqlConnection conn = connect_to_db();

			var ids = new System.Collections.ArrayList(count);
			string all_ids = "";
			
			for (int i=0; i<count; ++i)
			{
				for (int tries=0; tries<10; ++tries)
				{
					var date = DateTime.Now;
					string user_id = string.Empty;
					var rand = new Random();
					user_id += Char.ConvertFromUtf32('A'+(rand.Next()%26));
					user_id += Char.ConvertFromUtf32('A'+(rand.Next()%26));
					user_id += Char.ConvertFromUtf32('A'+(rand.Next()%26));
					user_id += Char.ConvertFromUtf32('A'+(rand.Next()%26));

					string query =
						"INSERT INTO player "+
						"(id,regdate) values "+
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
				ids = GetIdsFromDatabase(30);
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
					"DELETE FROM player "+
					"WHERE lastused IS NULL";
				var command = new MySqlCommand(query, conn);
				try
				{
					int resval = command.ExecuteNonQuery();
					textBoxSqlStatus.Text = resval.ToString()+"コの未使用IDを削除しました。";
				}
				catch (MySqlException)
				{
					textBoxSqlStatus.Text = "ERR";
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
    }
}
