using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ST_QrPrint
{
	enum PrintType
	{
		PlayerCode,
		GameCode,
		Animals,
	}

	public partial class FormQr : Form
	{
		/*=== 設定ここから ===*/
		const string ID_FONT = "Consolas";

		// A4: 210mm x 297mm
		// エーワン Item Number 72244
		const float margin_h   =  8.8f;   //紙と印刷部分上端のマージンmm
		const float margin_v   =  8.4f;   //紙と印刷部分左端のマージンmm
		const float cel_width  = 48.3f;   //シールのサイズ
		const float cel_height = 25.4f;
		const float id_top_mm  =  8.25f;  //シールに対する文字印刷部分のマージン
		const float id_left_mm = 22.5f;
		/*=== 設定ここまで ===*/

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

			DotNetBarcode barcode = new DotNetBarcode();
			barcode.Type = DotNetBarcode.Types.QRCode;
		}

		private void pd_PrintPlayerCode(object sender, PrintPageEventArgs e)
			{ pd_PrintPage(PrintType.PlayerCode, sender, e);　}
		private void pd_PrintGameCode(object sender, PrintPageEventArgs e)
			{ pd_PrintPage(PrintType.GameCode, sender, e);　}
		private void pd_PrintAnimals(object sender, PrintPageEventArgs e)
			{ pd_PrintPage(PrintType.Animals, sender, e); }

		private void buttonPrintGameCode_Click(object sender, EventArgs e)
			{ PrintCommon(pd_PrintGameCode, sender, e); }
		private void buttonPrint_Click(object sender, EventArgs e)
			{ PrintCommon(pd_PrintPlayerCode, sender, e); }
		private void buttonAnimals_Click(object sender, EventArgs e)
			{ PrintCommon(pd_PrintAnimals, sender, e); }

		delegate void PrintDelegate(object sender, PrintPageEventArgs e);


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
			const int W = 4;
			const int H = 11;

			string[] showname;
			string[] ids;
			try
			{
				ids = GetIdsFromDatabase(print_type, W*H, out showname);
			}
			catch (MySqlException ex)
			{
				textBoxSqlStatus.Text = ex.Message;
				return;
			}

			var g = e.Graphics;
			float font_pt = 20.0f;
			const float to_inch = 1 / 0.254f;
			string prefix = "";
			switch (print_type)
			{
			case PrintType.PlayerCode:
				prefix = "P";
				font_pt = 24.0f;
				break;
			case PrintType.GameCode:
				prefix = "G";
				font_pt = 20.0f;
				break;
			case PrintType.Animals:
				prefix = "";
				font_pt = 16.0f;
				break;
			}

			if (font!=null)
			{
				font.Dispose();
			}
			font = new Font(ID_FONT, font_pt, FontStyle.Bold);

			float text_top_mm = id_top_mm + (24.0f - font_pt)/4;

			int i = 0;
			for (int y=0; y<H; ++y)
			{
				for (int x=0; x<W; ++x, ++i)
				{
					string full_id = prefix + ids[i];
					string show_id = (showname!=null) ? showname[i] : GetShortId(ids[i]);

					const int qr_width = 3;
					barcode.QRCopyToClipboard(full_id, qr_width);
					Image img = Clipboard.GetImage();
					Debug.Print(img.Width.ToString());
					Debug.Print(img.Height.ToString());
					int qr_size = img.Width;
					int text_width = (int)g.MeasureString(show_id, font).Width;

					float dx = x * cel_width  + margin_h;
					float dy = y * cel_height + margin_v;

#if false
					g.DrawRectangle(
						//(x+y)%2==0 ? Pens.Red : Pens.Black,
						Pens.Black,
						to_inch * dx,
						to_inch * dy,
						to_inch * cel_width ,
						to_inch * cel_height);
#endif
					//barcode.QRBackColorTimingPattern = Color.Red;
					barcode.BackGroundColor = Color.Transparent;
					barcode.QRWriteBar(full_id,
							to_inch * (dx + 2),
							to_inch * (dy + 2),
							qr_width, e.Graphics);
					g.DrawString(show_id, font, Brushes.Black,
							new PointF(
								to_inch * (dx + id_left_mm),
								to_inch * (dy + text_top_mm)));
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
			// O/ou/を除く35文字セットから出す
			const string all =
				"0123456789"+
				"ABCDEFGHIJ"+
				"KLMNPQRSTU"+
				"VWXYZ";
			return include_zero
				? all[rand.Next()%35]
				: all[rand.Next()%34+1];
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

		string[] GetIdsFromDatabase(PrintType print_type, int count, out string[] showname)
		{
			var ids = new System.Collections.ArrayList(count);
			string all_ids = "";

			showname = null;
			string table_name;
			string col_name;
			switch (print_type)
			{
			case PrintType.GameCode:
				table_name = "records";
				col_name   = "record_id";
				break;
			case PrintType.PlayerCode:
				table_name = "users";
				col_name   = "player_id";
				break;
			case PrintType.Animals:{
				var list = new System.Collections.ArrayList();
				var name = new System.Collections.ArrayList();
				for (int i=0; i<count; ++i)
				{
					list.Add("M:CHEETAH-1");
					name.Add("チーター");
				}
				showname = (string[])name.ToArray(typeof(string));
				return (string[])list.ToArray(typeof(string));}
			default:{
				var list = new System.Collections.ArrayList();
				var name = new System.Collections.ArrayList();
				for (int i=0; i<count; ++i)
				{
					list.Add("#NO-ID#");
					name.Add("無効なID");
				}
				showname = (string[])name.ToArray(typeof(string));
				return (string[])list.ToArray(typeof(string));}
			}

			MySqlConnection conn = connect_to_db();
			for (int i=0; i<count; ++i)
			{
				for (int tries=0; tries<10; ++tries)
				{
					var date = DateTime.Now;
					string user_id = GetRandomId(print_type);

					string query =
						"INSERT INTO "+table_name+" "+
						"(" + col_name + ",created) values " +
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
				string[] temp;
				ids = GetIdsFromDatabase(PrintType.PlayerCode, 30, out temp);
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

		private void FormQr_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (conn_keep_alive!=null && conn_keep_alive.State==System.Data.ConnectionState.Open)
			{
				conn_keep_alive.Close();
				conn_keep_alive.Dispose();
			}
		}

		private void PrintCommon(PrintDelegate print, object sender, EventArgs e)
		{
			var pd = new PrintDocument();
			pd.PrintPage += new PrintPageEventHandler(print);
			pd.Print();
		}
	}
}
