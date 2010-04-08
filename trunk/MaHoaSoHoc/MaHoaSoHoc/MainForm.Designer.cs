namespace MaHoaSoHoc
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEncodeText = new System.Windows.Forms.Button();
            this.btnDecodeText = new System.Windows.Forms.Button();
            this.txtOutputText = new System.Windows.Forms.TextBox();
            this.txtInputText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbState = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.btnDecodeFile = new System.Windows.Forms.Button();
            this.btnEncodeFile = new System.Windows.Forms.Button();
            this.btnOpenOutputFile = new System.Windows.Forms.Button();
            this.txtFileOut = new System.Windows.Forms.TextBox();
            this.btnOpenInputFile = new System.Windows.Forms.Button();
            this.txtFileIn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(557, 219);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnReset);
            this.tabPage1.Controls.Add(this.btnEncodeText);
            this.tabPage1.Controls.Add(this.btnDecodeText);
            this.tabPage1.Controls.Add(this.txtOutputText);
            this.tabPage1.Controls.Add(this.txtInputText);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(549, 193);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mã hóa/giải mã text";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(433, 135);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(97, 36);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnEncodeText
            // 
            this.btnEncodeText.Location = new System.Drawing.Point(433, 33);
            this.btnEncodeText.Name = "btnEncodeText";
            this.btnEncodeText.Size = new System.Drawing.Size(97, 35);
            this.btnEncodeText.TabIndex = 8;
            this.btnEncodeText.Text = "Mã hóa";
            this.btnEncodeText.UseVisualStyleBackColor = true;
            this.btnEncodeText.Click += new System.EventHandler(this.btnEncodeText_Click);
            // 
            // btnDecodeText
            // 
            this.btnDecodeText.Location = new System.Drawing.Point(433, 83);
            this.btnDecodeText.Name = "btnDecodeText";
            this.btnDecodeText.Size = new System.Drawing.Size(97, 35);
            this.btnDecodeText.TabIndex = 7;
            this.btnDecodeText.Text = "Giải mã";
            this.btnDecodeText.UseVisualStyleBackColor = true;
            this.btnDecodeText.Click += new System.EventHandler(this.btnDecodeText_Click);
            // 
            // txtOutputText
            // 
            this.txtOutputText.Location = new System.Drawing.Point(43, 104);
            this.txtOutputText.Multiline = true;
            this.txtOutputText.Name = "txtOutputText";
            this.txtOutputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutputText.Size = new System.Drawing.Size(365, 80);
            this.txtOutputText.TabIndex = 6;
            // 
            // txtInputText
            // 
            this.txtInputText.Location = new System.Drawing.Point(43, 6);
            this.txtInputText.Multiline = true;
            this.txtInputText.Name = "txtInputText";
            this.txtInputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInputText.Size = new System.Drawing.Size(365, 84);
            this.txtInputText.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Output:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Input:";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.lbState);
            this.tabPage2.Controls.Add(this.progress);
            this.tabPage2.Controls.Add(this.btnDecodeFile);
            this.tabPage2.Controls.Add(this.btnEncodeFile);
            this.tabPage2.Controls.Add(this.btnOpenOutputFile);
            this.tabPage2.Controls.Add(this.txtFileOut);
            this.tabPage2.Controls.Add(this.btnOpenInputFile);
            this.tabPage2.Controls.Add(this.txtFileIn);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(549, 193);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mã hóa/giải mã file";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.Location = new System.Drawing.Point(75, 142);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(55, 13);
            this.lbState.TabIndex = 9;
            this.lbState.Text = "Trạng thái";
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(78, 158);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(412, 20);
            this.progress.TabIndex = 8;
            // 
            // btnDecodeFile
            // 
            this.btnDecodeFile.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDecodeFile.Location = new System.Drawing.Point(299, 101);
            this.btnDecodeFile.Name = "btnDecodeFile";
            this.btnDecodeFile.Size = new System.Drawing.Size(111, 36);
            this.btnDecodeFile.TabIndex = 7;
            this.btnDecodeFile.Text = "Giải mã";
            this.btnDecodeFile.UseVisualStyleBackColor = true;
            this.btnDecodeFile.Click += new System.EventHandler(this.btnDecodeFile_Click);
            // 
            // btnEncodeFile
            // 
            this.btnEncodeFile.Location = new System.Drawing.Point(148, 101);
            this.btnEncodeFile.Name = "btnEncodeFile";
            this.btnEncodeFile.Size = new System.Drawing.Size(111, 36);
            this.btnEncodeFile.TabIndex = 6;
            this.btnEncodeFile.Text = "Mã hóa";
            this.btnEncodeFile.UseVisualStyleBackColor = true;
            this.btnEncodeFile.Click += new System.EventHandler(this.btnEncodeFile_Click);
            // 
            // btnOpenOutputFile
            // 
            this.btnOpenOutputFile.Location = new System.Drawing.Point(496, 54);
            this.btnOpenOutputFile.Name = "btnOpenOutputFile";
            this.btnOpenOutputFile.Size = new System.Drawing.Size(33, 23);
            this.btnOpenOutputFile.TabIndex = 5;
            this.btnOpenOutputFile.Text = "...";
            this.btnOpenOutputFile.UseVisualStyleBackColor = true;
            this.btnOpenOutputFile.Click += new System.EventHandler(this.btnOpenOutputFile_Click);
            // 
            // txtFileOut
            // 
            this.txtFileOut.Location = new System.Drawing.Point(63, 56);
            this.txtFileOut.Name = "txtFileOut";
            this.txtFileOut.Size = new System.Drawing.Size(427, 20);
            this.txtFileOut.TabIndex = 4;
            // 
            // btnOpenInputFile
            // 
            this.btnOpenInputFile.Location = new System.Drawing.Point(496, 9);
            this.btnOpenInputFile.Name = "btnOpenInputFile";
            this.btnOpenInputFile.Size = new System.Drawing.Size(33, 23);
            this.btnOpenInputFile.TabIndex = 3;
            this.btnOpenInputFile.Text = "...";
            this.btnOpenInputFile.UseVisualStyleBackColor = true;
            this.btnOpenInputFile.Click += new System.EventHandler(this.btnOpenInputFile_Click);
            // 
            // txtFileIn
            // 
            this.txtFileIn.Location = new System.Drawing.Point(63, 11);
            this.txtFileIn.Name = "txtFileIn";
            this.txtFileIn.Size = new System.Drawing.Size(427, 20);
            this.txtFileIn.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Output file:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Input file:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(90, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHƯƠNG TRÌNH DEMO MÃ HÓA SỐ HỌC";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 266);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo Ma hoa so hoc - SV: Dinh Van Hai - HTTTK47";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnEncodeText;
        private System.Windows.Forms.Button btnDecodeText;
        private System.Windows.Forms.TextBox txtOutputText;
        private System.Windows.Forms.TextBox txtInputText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenOutputFile;
        private System.Windows.Forms.TextBox txtFileOut;
        private System.Windows.Forms.Button btnOpenInputFile;
        private System.Windows.Forms.TextBox txtFileIn;
        public System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Button btnDecodeFile;
        private System.Windows.Forms.Button btnEncodeFile;
        public System.Windows.Forms.Label lbState;
    }
}

