/*
 * Created by SharpDevelop.
 * User: Quang Vinh
 * Date: 4/7/2008
 * Time: 11:12 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BlowfishDemo
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ctrtab = new System.Windows.Forms.TabControl();
            this.tpCText = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btDecipher = new System.Windows.Forms.Button();
            this.btEncipher = new System.Windows.Forms.Button();
            this.txKey = new System.Windows.Forms.TextBox();
            this.txOutput = new System.Windows.Forms.TextBox();
            this.txInput = new System.Windows.Forms.TextBox();
            this.tpEDFile = new System.Windows.Forms.TabPage();
            this.lbState = new System.Windows.Forms.Label();
            this.tpInfo = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.lbAlgorithm = new System.Windows.Forms.Label();
            this.btFOut = new System.Windows.Forms.Button();
            this.btFIn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txFIn = new System.Windows.Forms.TextBox();
            this.txFOut = new System.Windows.Forms.TextBox();
            this.btFDecipher = new System.Windows.Forms.Button();
            this.txFKey = new System.Windows.Forms.TextBox();
            this.btFEncipher = new System.Windows.Forms.Button();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.ctrtab.SuspendLayout();
            this.tpCText.SuspendLayout();
            this.tpEDFile.SuspendLayout();
            this.tpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrtab
            // 
            this.ctrtab.Controls.Add(this.tpCText);
            this.ctrtab.Controls.Add(this.tpEDFile);
            this.ctrtab.Controls.Add(this.tpInfo);
            this.ctrtab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrtab.Location = new System.Drawing.Point(0, 0);
            this.ctrtab.Name = "ctrtab";
            this.ctrtab.SelectedIndex = 0;
            this.ctrtab.Size = new System.Drawing.Size(339, 165);
            this.ctrtab.TabIndex = 0;
            // 
            // tpCText
            // 
            this.tpCText.Controls.Add(this.label3);
            this.tpCText.Controls.Add(this.label2);
            this.tpCText.Controls.Add(this.label1);
            this.tpCText.Controls.Add(this.btDecipher);
            this.tpCText.Controls.Add(this.btEncipher);
            this.tpCText.Controls.Add(this.txKey);
            this.tpCText.Controls.Add(this.txOutput);
            this.tpCText.Controls.Add(this.txInput);
            this.tpCText.Location = new System.Drawing.Point(4, 22);
            this.tpCText.Name = "tpCText";
            this.tpCText.Padding = new System.Windows.Forms.Padding(3);
            this.tpCText.Size = new System.Drawing.Size(331, 139);
            this.tpCText.TabIndex = 0;
            this.tpCText.Text = "Encipher/Decipher Text";
            this.tpCText.UseVisualStyleBackColor = true;
            this.tpCText.Click += new System.EventHandler(this.tpCText_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Output:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Input:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Key:";
            // 
            // btDecipher
            // 
            this.btDecipher.Location = new System.Drawing.Point(262, 5);
            this.btDecipher.Name = "btDecipher";
            this.btDecipher.Size = new System.Drawing.Size(59, 21);
            this.btDecipher.TabIndex = 3;
            this.btDecipher.Text = "&Decipher";
            this.btDecipher.UseVisualStyleBackColor = true;
            this.btDecipher.Click += new System.EventHandler(this.BtDecipherClick);
            // 
            // btEncipher
            // 
            this.btEncipher.Location = new System.Drawing.Point(192, 5);
            this.btEncipher.Name = "btEncipher";
            this.btEncipher.Size = new System.Drawing.Size(64, 21);
            this.btEncipher.TabIndex = 2;
            this.btEncipher.Text = "&Encipher";
            this.btEncipher.UseVisualStyleBackColor = true;
            this.btEncipher.Click += new System.EventHandler(this.BtEncipherClick);
            // 
            // txKey
            // 
            this.txKey.Location = new System.Drawing.Point(42, 6);
            this.txKey.Name = "txKey";
            this.txKey.Size = new System.Drawing.Size(135, 20);
            this.txKey.TabIndex = 0;
            this.txKey.TextChanged += new System.EventHandler(this.TxKeyTextChanged);
            // 
            // txOutput
            // 
            this.txOutput.Location = new System.Drawing.Point(42, 80);
            this.txOutput.Multiline = true;
            this.txOutput.Name = "txOutput";
            this.txOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txOutput.Size = new System.Drawing.Size(278, 51);
            this.txOutput.TabIndex = 4;
            // 
            // txInput
            // 
            this.txInput.Location = new System.Drawing.Point(42, 32);
            this.txInput.Multiline = true;
            this.txInput.Name = "txInput";
            this.txInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txInput.Size = new System.Drawing.Size(278, 41);
            this.txInput.TabIndex = 1;
            // 
            // tpEDFile
            // 
            this.tpEDFile.Controls.Add(this.lbState);
            this.tpEDFile.Controls.Add(this.progress);
            this.tpEDFile.Controls.Add(this.label6);
            this.tpEDFile.Controls.Add(this.label5);
            this.tpEDFile.Controls.Add(this.label4);
            this.tpEDFile.Controls.Add(this.btFDecipher);
            this.tpEDFile.Controls.Add(this.btFEncipher);
            this.tpEDFile.Controls.Add(this.btFOut);
            this.tpEDFile.Controls.Add(this.btFIn);
            this.tpEDFile.Controls.Add(this.txFKey);
            this.tpEDFile.Controls.Add(this.txFOut);
            this.tpEDFile.Controls.Add(this.txFIn);
            this.tpEDFile.Location = new System.Drawing.Point(4, 22);
            this.tpEDFile.Name = "tpEDFile";
            this.tpEDFile.Padding = new System.Windows.Forms.Padding(3);
            this.tpEDFile.Size = new System.Drawing.Size(331, 139);
            this.tpEDFile.TabIndex = 1;
            this.tpEDFile.Text = "Encipher/Decipher File";
            this.tpEDFile.UseVisualStyleBackColor = true;
            this.tpEDFile.Click += new System.EventHandler(this.tpEDFile_Click);
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbState.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbState.Location = new System.Drawing.Point(-4, 111);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(0, 13);
            this.lbState.TabIndex = 5;
            // 
            // tpInfo
            // 
            this.tpInfo.Controls.Add(this.pictureBox1);
            this.tpInfo.Controls.Add(this.lbAuthor);
            this.tpInfo.Controls.Add(this.lbAlgorithm);
            this.tpInfo.Location = new System.Drawing.Point(4, 22);
            this.tpInfo.Name = "tpInfo";
            this.tpInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpInfo.Size = new System.Drawing.Size(331, 139);
            this.tpInfo.TabIndex = 2;
            this.tpInfo.Text = "Information";
            this.tpInfo.UseVisualStyleBackColor = true;
            this.tpInfo.Click += new System.EventHandler(this.tpInfo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuthor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbAuthor.Location = new System.Drawing.Point(42, 101);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(35, 13);
            this.lbAuthor.TabIndex = 0;
            this.lbAuthor.Text = "label7";
            // 
            // lbAlgorithm
            // 
            this.lbAlgorithm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbAlgorithm.Location = new System.Drawing.Point(6, 3);
            this.lbAlgorithm.Name = "lbAlgorithm";
            this.lbAlgorithm.Size = new System.Drawing.Size(322, 90);
            this.lbAlgorithm.TabIndex = 0;
            this.lbAlgorithm.Text = "label7";
            // 
            // btFOut
            // 
            this.btFOut.AutoSize = true;
            this.btFOut.Location = new System.Drawing.Point(292, 30);
            this.btFOut.Name = "btFOut";
            this.btFOut.Size = new System.Drawing.Size(26, 23);
            this.btFOut.TabIndex = 3;
            this.btFOut.Text = "...";
            this.btFOut.UseVisualStyleBackColor = true;
            this.btFOut.Click += new System.EventHandler(this.BtFOutClick);
            // 
            // btFIn
            // 
            this.btFIn.AutoSize = true;
            this.btFIn.Location = new System.Drawing.Point(292, 4);
            this.btFIn.Name = "btFIn";
            this.btFIn.Size = new System.Drawing.Size(26, 23);
            this.btFIn.TabIndex = 1;
            this.btFIn.Text = "...";
            this.btFIn.UseVisualStyleBackColor = true;
            this.btFIn.Click += new System.EventHandler(this.BtFInClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Key:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Output File:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Input File:";
            // 
            // txFIn
            // 
            this.txFIn.Location = new System.Drawing.Point(74, 6);
            this.txFIn.Name = "txFIn";
            this.txFIn.Size = new System.Drawing.Size(212, 20);
            this.txFIn.TabIndex = 0;
            // 
            // txFOut
            // 
            this.txFOut.Location = new System.Drawing.Point(74, 32);
            this.txFOut.Name = "txFOut";
            this.txFOut.Size = new System.Drawing.Size(212, 20);
            this.txFOut.TabIndex = 2;
            // 
            // btFDecipher
            // 
            this.btFDecipher.Location = new System.Drawing.Point(188, 84);
            this.btFDecipher.Name = "btFDecipher";
            this.btFDecipher.Size = new System.Drawing.Size(98, 23);
            this.btFDecipher.TabIndex = 6;
            this.btFDecipher.Text = "&Decipher";
            this.btFDecipher.UseVisualStyleBackColor = true;
            this.btFDecipher.Click += new System.EventHandler(this.BtFDecipherClick);
            // 
            // txFKey
            // 
            this.txFKey.Location = new System.Drawing.Point(74, 58);
            this.txFKey.Name = "txFKey";
            this.txFKey.PasswordChar = '*';
            this.txFKey.Size = new System.Drawing.Size(212, 20);
            this.txFKey.TabIndex = 4;
            // 
            // btFEncipher
            // 
            this.btFEncipher.Location = new System.Drawing.Point(74, 84);
            this.btFEncipher.Name = "btFEncipher";
            this.btFEncipher.Size = new System.Drawing.Size(100, 23);
            this.btFEncipher.TabIndex = 5;
            this.btFEncipher.Text = "&Encipher";
            this.btFEncipher.UseVisualStyleBackColor = true;
            this.btFEncipher.Click += new System.EventHandler(this.BtFEncipherClick);
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(74, 111);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(212, 20);
            this.progress.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 165);
            this.Controls.Add(this.ctrtab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Blowfish Demo";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
            this.ctrtab.ResumeLayout(false);
            this.tpCText.ResumeLayout(false);
            this.tpCText.PerformLayout();
            this.tpEDFile.ResumeLayout(false);
            this.tpEDFile.PerformLayout();
            this.tpInfo.ResumeLayout(false);
            this.tpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}
        public System.Windows.Forms.Label lbState;
        private System.Windows.Forms.TabPage tpInfo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tpEDFile;
		private System.Windows.Forms.TextBox txInput;
		private System.Windows.Forms.TextBox txOutput;
		private System.Windows.Forms.TextBox txKey;
		private System.Windows.Forms.Button btEncipher;
		private System.Windows.Forms.Button btDecipher;
		private System.Windows.Forms.TabPage tpCText;
		private System.Windows.Forms.TabControl ctrtab;
        public System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btFDecipher;
        private System.Windows.Forms.Button btFEncipher;
        private System.Windows.Forms.Button btFOut;
        private System.Windows.Forms.Button btFIn;
        private System.Windows.Forms.TextBox txFKey;
        private System.Windows.Forms.TextBox txFOut;
        private System.Windows.Forms.TextBox txFIn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.Label lbAlgorithm;
	}
}
