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
			this.labelPrinterStatus = new System.Windows.Forms.Label();
			this.buttonPrint = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.checkPrintWithoutPreview = new System.Windows.Forms.CheckBox();
			this.textBoxPrinterState = new System.Windows.Forms.TextBox();
			this.textBoxServerState = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.textBoxSqlStatus = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// labelPrinterStatus
			// 
			this.labelPrinterStatus.AutoSize = true;
			this.labelPrinterStatus.Location = new System.Drawing.Point(14, 68);
			this.labelPrinterStatus.Name = "labelPrinterStatus";
			this.labelPrinterStatus.Size = new System.Drawing.Size(84, 15);
			this.labelPrinterStatus.TabIndex = 0;
			this.labelPrinterStatus.Text = "プリンターの状態";
			// 
			// buttonPrint
			// 
			this.buttonPrint.Font = new System.Drawing.Font("Meiryo UI", 12F);
			this.buttonPrint.Location = new System.Drawing.Point(283, 232);
			this.buttonPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonPrint.Name = "buttonPrint";
			this.buttonPrint.Size = new System.Drawing.Size(120, 77);
			this.buttonPrint.TabIndex = 2;
			this.buttonPrint.Text = "印刷する";
			this.buttonPrint.UseVisualStyleBackColor = true;
			this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
			// 
			// buttonExit
			// 
			this.buttonExit.Font = new System.Drawing.Font("Meiryo UI", 12F);
			this.buttonExit.Location = new System.Drawing.Point(17, 225);
			this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(114, 77);
			this.buttonExit.TabIndex = 2;
			this.buttonExit.Text = "終了する";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// checkPrintWithoutPreview
			// 
			this.checkPrintWithoutPreview.AutoSize = true;
			this.checkPrintWithoutPreview.Location = new System.Drawing.Point(279, 69);
			this.checkPrintWithoutPreview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.checkPrintWithoutPreview.Name = "checkPrintWithoutPreview";
			this.checkPrintWithoutPreview.Size = new System.Drawing.Size(123, 19);
			this.checkPrintWithoutPreview.TabIndex = 3;
			this.checkPrintWithoutPreview.Text = "プレビューせずに印刷";
			this.checkPrintWithoutPreview.UseVisualStyleBackColor = true;
			// 
			// textBoxPrinterState
			// 
			this.textBoxPrinterState.Location = new System.Drawing.Point(17, 87);
			this.textBoxPrinterState.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBoxPrinterState.Multiline = true;
			this.textBoxPrinterState.Name = "textBoxPrinterState";
			this.textBoxPrinterState.ReadOnly = true;
			this.textBoxPrinterState.Size = new System.Drawing.Size(382, 57);
			this.textBoxPrinterState.TabIndex = 4;
			// 
			// textBoxServerState
			// 
			this.textBoxServerState.Location = new System.Drawing.Point(17, 30);
			this.textBoxServerState.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBoxServerState.Multiline = true;
			this.textBoxServerState.Name = "textBoxServerState";
			this.textBoxServerState.ReadOnly = true;
			this.textBoxServerState.Size = new System.Drawing.Size(382, 34);
			this.textBoxServerState.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 15);
			this.label1.TabIndex = 6;
			this.label1.Text = "データサーバーの状態";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(151, 279);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(58, 23);
			this.textBox1.TabIndex = 7;
			this.textBox1.Text = "1";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(215, 282);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 15);
			this.label2.TabIndex = 8;
			this.label2.Text = "枚印刷する";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "選手用QRコード",
            "走るQRコード"});
			this.comboBox1.Location = new System.Drawing.Point(79, 182);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 23);
			this.comboBox1.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(14, 185);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 15);
			this.label3.TabIndex = 10;
			this.label3.Text = "データ種類";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(24, 148);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(379, 15);
			this.label4.TabIndex = 11;
			this.label4.Text = "※出力するプリンターはWindowsの「通常使うのプリンター」で設定してください。";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Meiryo UI", 12F);
			this.button1.Location = new System.Drawing.Point(392, 366);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(114, 77);
			this.button1.TabIndex = 12;
			this.button1.Text = "Get";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBoxSqlStatus
			// 
			this.textBoxSqlStatus.Location = new System.Drawing.Point(12, 366);
			this.textBoxSqlStatus.Multiline = true;
			this.textBoxSqlStatus.Name = "textBoxSqlStatus";
			this.textBoxSqlStatus.Size = new System.Drawing.Size(364, 123);
			this.textBoxSqlStatus.TabIndex = 14;
			// 
			// FormQr
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(537, 501);
			this.Controls.Add(this.textBoxSqlStatus);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxServerState);
			this.Controls.Add(this.textBoxPrinterState);
			this.Controls.Add(this.checkPrintWithoutPreview);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.buttonPrint);
			this.Controls.Add(this.labelPrinterStatus);
			this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.Name = "FormQr";
			this.Text = "スポーツタイムマシン　QRコード発行";
			this.Activated += new System.EventHandler(this.FormQr_Activated);
			this.Deactivate += new System.EventHandler(this.FormQr_Deactivate);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormQr_Paint);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.Label labelPrinterStatus;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.CheckBox checkPrintWithoutPreview;
		private System.Windows.Forms.TextBox textBoxPrinterState;
		private System.Windows.Forms.TextBox textBoxServerState;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBoxSqlStatus;
    }
}

