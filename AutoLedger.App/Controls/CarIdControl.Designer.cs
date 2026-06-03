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
            this.inputSuffixCode = new System.Windows.Forms.TextBox();
            this.cbLetter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputProvinceCode = new System.Windows.Forms.TextBox();
            this.inputSerialNumber = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.pictureBox2);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.inputSuffixCode);
            this.mainPanel.Controls.Add(this.cbLetter);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.inputProvinceCode);
            this.mainPanel.Controls.Add(this.inputSerialNumber);
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(292, 70);
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
            this.label3.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(5, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "IRAN";
            // 
            // inputSuffixCode
            // 
            this.inputSuffixCode.AcceptsTab = true;
            this.inputSuffixCode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputSuffixCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputSuffixCode.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.inputSuffixCode.Location = new System.Drawing.Point(245, 21);
            this.inputSuffixCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputSuffixCode.MaxLength = 2;
            this.inputSuffixCode.Name = "inputSuffixCode";
            this.inputSuffixCode.Size = new System.Drawing.Size(36, 29);
            this.inputSuffixCode.TabIndex = 3;
            this.inputSuffixCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbLetter
            // 
            this.cbLetter.DropDownHeight = 200;
            this.cbLetter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLetter.DropDownWidth = 60;
            this.cbLetter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cbLetter.FormattingEnabled = true;
            this.cbLetter.ItemHeight = 21;
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
            this.cbLetter.Location = new System.Drawing.Point(98, 22);
            this.cbLetter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLetter.Name = "cbLetter";
            this.cbLetter.Size = new System.Drawing.Size(58, 29);
            this.cbLetter.TabIndex = 4;
            this.cbLetter.ValueMember = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(8, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "🇮.🇷";
            // 
            // inputProvinceCode
            // 
            this.inputProvinceCode.AcceptsTab = true;
            this.inputProvinceCode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputProvinceCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputProvinceCode.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.inputProvinceCode.Location = new System.Drawing.Point(41, 21);
            this.inputProvinceCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputProvinceCode.MaxLength = 2;
            this.inputProvinceCode.Name = "inputProvinceCode";
            this.inputProvinceCode.Size = new System.Drawing.Size(50, 29);
            this.inputProvinceCode.TabIndex = 1;
            this.inputProvinceCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputSerialNumber
            // 
            this.inputSerialNumber.AcceptsTab = true;
            this.inputSerialNumber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputSerialNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputSerialNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.inputSerialNumber.Location = new System.Drawing.Point(166, 21);
            this.inputSerialNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputSerialNumber.MaxLength = 3;
            this.inputSerialNumber.Name = "inputSerialNumber";
            this.inputSerialNumber.Size = new System.Drawing.Size(71, 29);
            this.inputSerialNumber.TabIndex = 2;
            this.inputSerialNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Blue;
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 58);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(238, -5);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "ایران";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CarIdControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CarIdControl";
            this.Size = new System.Drawing.Size(292, 70);
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
        private System.Windows.Forms.TextBox inputSuffixCode;
        private System.Windows.Forms.TextBox inputSerialNumber;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox inputProvinceCode;
    }
}
