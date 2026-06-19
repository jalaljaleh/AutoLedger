namespace AutoLedger.App.Controls
{
    partial class CarIdControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbLetter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputSuffixCode = new AutoLedger.App.Controls.ModernTextBox();
            this.inputSerialNumber = new AutoLedger.App.Controls.ModernTextBox();
            this.inputProvinceCode = new AutoLedger.App.Controls.ModernTextBox();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.inputProvinceCode);
            this.mainPanel.Controls.Add(this.inputSerialNumber);
            this.mainPanel.Controls.Add(this.inputSuffixCode);
            this.mainPanel.Controls.Add(this.pictureBox2);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.cbLetter);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(296, 75);
            this.mainPanel.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::AutoLedger.App.Properties.Resources.iran;
            this.pictureBox2.Location = new System.Drawing.Point(5, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Blue;
            this.label3.Font = new System.Drawing.Font("Vazirmatn", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(5, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "IRAN";
            // 
            // cbLetter
            // 
            this.cbLetter.DisplayMember = "0";
            this.cbLetter.DropDownHeight = 200;
            this.cbLetter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLetter.DropDownWidth = 60;
            this.cbLetter.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLetter.FormattingEnabled = true;
            this.cbLetter.IntegralHeight = false;
            this.cbLetter.ItemHeight = 27;
            this.cbLetter.Items.AddRange(new object[] {
            "الف",
            "ب",
            "پ",
            "ت",
            "ث",
            "ج",
            "ح",
            "د",
            "ر",
            "ز",
            "ژ",
            "س",
            "ش",
            "ص",
            "ض",
            "ط",
            "ظ",
            "ع",
            "ف",
            "ق",
            "ک",
            "گ",
            "ل",
            "م",
            "ن",
            "و",
            "ه",
            "ی",
            "D",
            "S",
            "♿"});
            this.cbLetter.Location = new System.Drawing.Point(105, 24);
            this.cbLetter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLetter.Name = "cbLetter";
            this.cbLetter.Size = new System.Drawing.Size(58, 35);
            this.cbLetter.TabIndex = 4;
            this.cbLetter.ValueMember = "ج";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "🇮.🇷";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Blue;
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 71);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(238, -3);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "ایران";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputSuffixCode
            // 
            this.inputSuffixCode.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.inputSuffixCode.BackColor = System.Drawing.Color.White;
            this.inputSuffixCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.inputSuffixCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputSuffixCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.inputSuffixCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.inputSuffixCode.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.inputSuffixCode.Icon = null;
            this.inputSuffixCode.Location = new System.Drawing.Point(41, 21);
            this.inputSuffixCode.Name = "inputSuffixCode";
            this.inputSuffixCode.NumbersOnly = true;
            this.inputSuffixCode.Placeholder = "پیش";
            this.inputSuffixCode.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.inputSuffixCode.ShowClearButton = false;
            this.inputSuffixCode.Size = new System.Drawing.Size(58, 40);
            this.inputSuffixCode.TabIndex = 16;
            this.inputSuffixCode.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputSerialNumber
            // 
            this.inputSerialNumber.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.inputSerialNumber.BackColor = System.Drawing.Color.White;
            this.inputSerialNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.inputSerialNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputSerialNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.inputSerialNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.inputSerialNumber.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.inputSerialNumber.Icon = null;
            this.inputSerialNumber.Location = new System.Drawing.Point(169, 21);
            this.inputSerialNumber.Name = "inputSerialNumber";
            this.inputSerialNumber.NumbersOnly = true;
            this.inputSerialNumber.Placeholder = "سریال";
            this.inputSerialNumber.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.inputSerialNumber.ShowClearButton = false;
            this.inputSerialNumber.Size = new System.Drawing.Size(55, 40);
            this.inputSerialNumber.TabIndex = 17;
            this.inputSerialNumber.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputProvinceCode
            // 
            this.inputProvinceCode.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.inputProvinceCode.BackColor = System.Drawing.Color.White;
            this.inputProvinceCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.inputProvinceCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputProvinceCode.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.inputProvinceCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.inputProvinceCode.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.inputProvinceCode.Icon = null;
            this.inputProvinceCode.Location = new System.Drawing.Point(230, 21);
            this.inputProvinceCode.Name = "inputProvinceCode";
            this.inputProvinceCode.NumbersOnly = true;
            this.inputProvinceCode.Placeholder = "استان";
            this.inputProvinceCode.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.inputProvinceCode.ShowClearButton = false;
            this.inputProvinceCode.Size = new System.Drawing.Size(55, 40);
            this.inputProvinceCode.TabIndex = 18;
            this.inputProvinceCode.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CarIdControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CarIdControl";
            this.Size = new System.Drawing.Size(296, 75);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLetter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ModernTextBox inputProvinceCode;
        private ModernTextBox inputSerialNumber;
        private ModernTextBox inputSuffixCode;
    }
}
