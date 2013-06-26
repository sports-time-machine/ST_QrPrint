using System;


namespace ST_QrPrint
{
    partial class FormQr
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQr));
			this.textBoxPrinterState = new System.Windows.Forms.TextBox();
			this.textBoxServerState = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.textBoxSqlStatus = new System.Windows.Forms.TextBox();
			this.buttonRemoveUnusedIds = new System.Windows.Forms.Button();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.buttonExit = new System.Windows.Forms.Button();
			this.checkPrintWithoutPreview = new System.Windows.Forms.CheckBox();
			this.buttonPrint = new System.Windows.Forms.Button();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.picturePrinterStatus = new System.Windows.Forms.PictureBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.picturePrinter = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pictureDatabaseStatus = new System.Windows.Forms.PictureBox();
			this.pictureDatabase = new System.Windows.Forms.PictureBox();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.buttonPrintGameCode = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picturePrinterStatus)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picturePrinter)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureDatabaseStatus)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureDatabase)).BeginInit();
			this.tabPage4.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBoxPrinterState
			// 
			this.textBoxPrinterState.Font = new System.Drawing.Font("Meiryo UI", 10F);
			this.textBoxPrinterState.Location = new System.Drawing.Point(16, 235);
			this.textBoxPrinterState.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxPrinterState.Multiline = true;
			this.textBoxPrinterState.Name = "textBoxPrinterState";
			this.textBoxPrinterState.ReadOnly = true;
			this.textBoxPrinterState.Size = new System.Drawing.Size(280, 100);
			this.textBoxPrinterState.TabIndex = 4;
			// 
			// textBoxServerState
			// 
			this.textBoxServerState.Font = new System.Drawing.Font("Meiryo UI", 10F);
			this.textBoxServerState.Location = new System.Drawing.Point(17, 235);
			this.textBoxServerState.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxServerState.Multiline = true;
			this.textBoxServerState.Name = "textBoxServerState";
			this.textBoxServerState.ReadOnly = true;
			this.textBoxServerState.Size = new System.Drawing.Size(280, 100);
			this.textBoxServerState.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(344, 380);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 20);
			this.label2.TabIndex = 8;
			this.label2.Text = "枚印刷する";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(124, 49);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(0, 20);
			this.label4.TabIndex = 11;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Meiryo UI", 12F);
			this.button1.Location = new System.Drawing.Point(486, 350);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(163, 52);
			this.button1.TabIndex = 12;
			this.button1.Text = "ID Get";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBoxSqlStatus
			// 
			this.textBoxSqlStatus.BackColor = System.Drawing.Color.Black;
			this.textBoxSqlStatus.Font = new System.Drawing.Font("Courier New", 12F);
			this.textBoxSqlStatus.ForeColor = System.Drawing.Color.Green;
			this.textBoxSqlStatus.Location = new System.Drawing.Point(9, 7);
			this.textBoxSqlStatus.Margin = new System.Windows.Forms.Padding(4);
			this.textBoxSqlStatus.Multiline = true;
			this.textBoxSqlStatus.Name = "textBoxSqlStatus";
			this.textBoxSqlStatus.Size = new System.Drawing.Size(640, 336);
			this.textBoxSqlStatus.TabIndex = 14;
			// 
			// buttonRemoveUnusedIds
			// 
			this.buttonRemoveUnusedIds.Font = new System.Drawing.Font("Meiryo UI", 12F);
			this.buttonRemoveUnusedIds.Location = new System.Drawing.Point(9, 352);
			this.buttonRemoveUnusedIds.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonRemoveUnusedIds.Name = "buttonRemoveUnusedIds";
			this.buttonRemoveUnusedIds.Size = new System.Drawing.Size(163, 52);
			this.buttonRemoveUnusedIds.TabIndex = 15;
			this.buttonRemoveUnusedIds.Text = "未使用IDの削除";
			this.buttonRemoveUnusedIds.UseVisualStyleBackColor = true;
			this.buttonRemoveUnusedIds.Click += new System.EventHandler(this.buttonRemoveUnusedIds_Click);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Font = new System.Drawing.Font("Tahoma", 20F);
			this.numericUpDown1.Location = new System.Drawing.Point(226, 368);
			this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(110, 40);
			this.numericUpDown1.TabIndex = 17;
			this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(666, 445);
			this.tabControl1.TabIndex = 18;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.buttonPrintGameCode);
			this.tabPage1.Controls.Add(this.buttonExit);
			this.tabPage1.Controls.Add(this.checkPrintWithoutPreview);
			this.tabPage1.Controls.Add(this.buttonPrint);
			this.tabPage1.Controls.Add(this.numericUpDown1);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Location = new System.Drawing.Point(4, 29);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(658, 412);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "印刷";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// buttonExit
			// 
			this.buttonExit.BackgroundImage = global::ST_QrPrint.Properties.Resources.system_shutdown_6;
			this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonExit.Font = new System.Drawing.Font("Meiryo UI", 12F);
			this.buttonExit.Location = new System.Drawing.Point(9, 322);
			this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(80, 80);
			this.buttonExit.TabIndex = 19;
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click_1);
			// 
			// checkPrintWithoutPreview
			// 
			this.checkPrintWithoutPreview.AutoSize = true;
			this.checkPrintWithoutPreview.Location = new System.Drawing.Point(494, 383);
			this.checkPrintWithoutPreview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkPrintWithoutPreview.Name = "checkPrintWithoutPreview";
			this.checkPrintWithoutPreview.Size = new System.Drawing.Size(160, 24);
			this.checkPrintWithoutPreview.TabIndex = 18;
			this.checkPrintWithoutPreview.Text = "プレビューせずに印刷";
			this.checkPrintWithoutPreview.UseVisualStyleBackColor = true;
			// 
			// buttonPrint
			// 
			this.buttonPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPrint.BackgroundImage")));
			this.buttonPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonPrint.Font = new System.Drawing.Font("Meiryo UI", 12F);
			this.buttonPrint.Location = new System.Drawing.Point(123, 108);
			this.buttonPrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonPrint.Name = "buttonPrint";
			this.buttonPrint.Size = new System.Drawing.Size(152, 149);
			this.buttonPrint.TabIndex = 2;
			this.buttonPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.buttonPrint.UseVisualStyleBackColor = true;
			this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.groupBox2);
			this.tabPage3.Controls.Add(this.groupBox1);
			this.tabPage3.Location = new System.Drawing.Point(4, 29);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(658, 412);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "各種状態";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.picturePrinterStatus);
			this.groupBox2.Controls.Add(this.textBoxPrinterState);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Controls.Add(this.picturePrinter);
			this.groupBox2.Location = new System.Drawing.Point(335, 6);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(315, 398);
			this.groupBox2.TabIndex = 23;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "プリンターの状態";
			// 
			// picturePrinterStatus
			// 
			this.picturePrinterStatus.BackColor = System.Drawing.Color.DimGray;
			this.picturePrinterStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.picturePrinterStatus.Location = new System.Drawing.Point(176, 147);
			this.picturePrinterStatus.Name = "picturePrinterStatus";
			this.picturePrinterStatus.Size = new System.Drawing.Size(80, 80);
			this.picturePrinterStatus.TabIndex = 21;
			this.picturePrinterStatus.TabStop = false;
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new System.Drawing.Font("Meiryo UI", 9F);
			this.textBox1.Location = new System.Drawing.Point(16, 343);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(280, 41);
			this.textBox1.TabIndex = 20;
			this.textBox1.TabStop = false;
			this.textBox1.Text = "出力するプリンターはWindowsの\r\n「通常使うプリンター」で設定してください。";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// picturePrinter
			// 
			this.picturePrinter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picturePrinter.BackgroundImage")));
			this.picturePrinter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.picturePrinter.Location = new System.Drawing.Point(56, 27);
			this.picturePrinter.Name = "picturePrinter";
			this.picturePrinter.Size = new System.Drawing.Size(200, 200);
			this.picturePrinter.TabIndex = 19;
			this.picturePrinter.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBoxServerState);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.pictureDatabaseStatus);
			this.groupBox1.Controls.Add(this.pictureDatabase);
			this.groupBox1.Location = new System.Drawing.Point(8, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(321, 398);
			this.groupBox1.TabIndex = 22;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "データサーバーの状態";
			// 
			// pictureDatabaseStatus
			// 
			this.pictureDatabaseStatus.BackColor = System.Drawing.Color.DimGray;
			this.pictureDatabaseStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureDatabaseStatus.Location = new System.Drawing.Point(177, 147);
			this.pictureDatabaseStatus.Name = "pictureDatabaseStatus";
			this.pictureDatabaseStatus.Size = new System.Drawing.Size(80, 80);
			this.pictureDatabaseStatus.TabIndex = 21;
			this.pictureDatabaseStatus.TabStop = false;
			// 
			// pictureDatabase
			// 
			this.pictureDatabase.BackgroundImage = global::ST_QrPrint.Properties.Resources.db;
			this.pictureDatabase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureDatabase.Location = new System.Drawing.Point(57, 27);
			this.pictureDatabase.Name = "pictureDatabase";
			this.pictureDatabase.Size = new System.Drawing.Size(200, 200);
			this.pictureDatabase.TabIndex = 12;
			this.pictureDatabase.TabStop = false;
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.textBoxSqlStatus);
			this.tabPage4.Controls.Add(this.buttonRemoveUnusedIds);
			this.tabPage4.Controls.Add(this.button1);
			this.tabPage4.Location = new System.Drawing.Point(4, 29);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(658, 412);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "デバッグ用";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// buttonPrintGameCode
			// 
			this.buttonPrintGameCode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPrintGameCode.BackgroundImage")));
			this.buttonPrintGameCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonPrintGameCode.Font = new System.Drawing.Font("Meiryo UI", 12F);
			this.buttonPrintGameCode.Location = new System.Drawing.Point(416, 108);
			this.buttonPrintGameCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonPrintGameCode.Name = "buttonPrintGameCode";
			this.buttonPrintGameCode.Size = new System.Drawing.Size(152, 149);
			this.buttonPrintGameCode.TabIndex = 20;
			this.buttonPrintGameCode.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.buttonPrintGameCode.UseVisualStyleBackColor = true;
			this.buttonPrintGameCode.Click += new System.EventHandler(this.buttonPrintGameCode_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(129, 262);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(142, 20);
			this.label1.TabIndex = 21;
			this.label1.Text = "プレイヤーのQRコード";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(433, 262);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(119, 20);
			this.label3.TabIndex = 22;
			this.label3.Text = "ゲームのQRコード";
			// 
			// FormQr
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(666, 445);
			this.Controls.Add(this.tabControl1);
			this.Font = new System.Drawing.Font("Meiryo UI", 12F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "FormQr";
			this.Text = "スポーツタイムマシン　QRコード発行";
			this.TransparencyKey = System.Drawing.Color.Navy;
			this.Activated += new System.EventHandler(this.FormQr_Activated);
			this.Deactivate += new System.EventHandler(this.FormQr_Deactivate);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormQr_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormQr_Paint);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picturePrinterStatus)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picturePrinter)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureDatabaseStatus)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureDatabase)).EndInit();
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.Button buttonPrint;
		private System.Windows.Forms.TextBox textBoxPrinterState;
		private System.Windows.Forms.TextBox textBoxServerState;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBoxSqlStatus;
		private System.Windows.Forms.Button buttonRemoveUnusedIds;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.PictureBox pictureDatabase;
		private System.Windows.Forms.CheckBox checkPrintWithoutPreview;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.PictureBox picturePrinter;
		private System.Windows.Forms.PictureBox pictureDatabaseStatus;
		private System.Windows.Forms.PictureBox picturePrinterStatus;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonPrintGameCode;
    }
}

