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
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.textBoxSqlStatus = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonPrintGameCode = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.buttonPrint = new System.Windows.Forms.Button();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label4 = new System.Windows.Forms.Label();
			this.buttonAnimals = new System.Windows.Forms.Button();
			this.tabPage4.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.textBoxSqlStatus);
			this.tabPage4.Controls.Add(this.button1);
			this.tabPage4.Location = new System.Drawing.Point(4, 29);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(658, 412);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "デバッグ用";
			this.tabPage4.UseVisualStyleBackColor = true;
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
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.buttonPrintGameCode);
			this.tabPage1.Controls.Add(this.buttonExit);
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
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(433, 262);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(119, 20);
			this.label3.TabIndex = 22;
			this.label3.Text = "ゲームのQRコード";
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
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
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
			this.numericUpDown1.Visible = false;
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
			this.label2.Visible = false;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(666, 445);
			this.tabControl1.TabIndex = 18;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.buttonAnimals);
			this.tabPage2.Location = new System.Drawing.Point(4, 29);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(658, 412);
			this.tabPage2.TabIndex = 4;
			this.tabPage2.Text = "特殊なQRコード";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(170, 80);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 20);
			this.label4.TabIndex = 26;
			this.label4.Text = "チーター";
			// 
			// buttonAnimals
			// 
			this.buttonAnimals.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAnimals.BackgroundImage")));
			this.buttonAnimals.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonAnimals.Font = new System.Drawing.Font("Meiryo UI", 12F);
			this.buttonAnimals.Location = new System.Drawing.Point(34, 31);
			this.buttonAnimals.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonAnimals.Name = "buttonAnimals";
			this.buttonAnimals.Size = new System.Drawing.Size(115, 116);
			this.buttonAnimals.TabIndex = 25;
			this.buttonAnimals.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.buttonAnimals.UseVisualStyleBackColor = true;
			this.buttonAnimals.Click += new System.EventHandler(this.buttonAnimals_Click);
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
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.TextBox textBoxSqlStatus;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonPrintGameCode;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Button buttonPrint;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button buttonAnimals;

	}
}

