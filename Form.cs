using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace ST_QrPrint
{
    public partial class FormQr : Form
    {
        private DotNetBarcode barcode = new DotNetBarcode();

        public FormQr()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DotNetBarcode barcode = new DotNetBarcode();
            barcode.Type = DotNetBarcode.Types.QRCode;

            font = new Font("Courier New", 10);

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

        Font font;

        private void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            Debug.Print("hello");
            Debug.Print(e.MarginBounds.Right.ToString());
            Debug.Print(e.MarginBounds.Bottom.ToString());
            Debug.Print(e.MarginBounds.ToString());


			const int qr_width = 4;
			barcode.QRCopyToClipboard("ABCD", qr_width);
			Image img = Clipboard.GetImage();
			Debug.Print(img.Width.ToString());
			Debug.Print(img.Height.ToString());
			int qr_size = img.Width;
            

            var g = e.Graphics;

			int text_width = (int)g.MeasureString("ABCD", font).Width;

			// A4: 8.27in x 11.69in
			const int W = 6;
			const int H = 5;
			const int cel_width  = 827/W;
			const int cel_height = 1169/H;

            for (int y=0; y<H; ++y)
            {
                for (int x=0; x<W; ++x)
                {
					int dx = x * cel_width;
					int dy = y * cel_height;

                    g.DrawRectangle(
                        (x^y)%2==0 ? Pens.Red : Pens.Black,
						new Rectangle(dx+2, dy+2, dx + cel_width-2, dy+cel_height-2));
                    barcode.QRWriteBar("ABCD",
						   dx + (cel_width-qr_size)/2,
						   dy + 10,
                           qr_width, e.Graphics);
                    g.DrawString("ABCD", font, Brushes.Black,
                           new PointF(
							   dx + (cel_width-text_width)/2,
							   dy + 160));
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
    }
}
