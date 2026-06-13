namespace AutoLedger.App.Forms
{
    partial class AddCarForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBtnCarReception = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCarReception = new System.Windows.Forms.Button();
            this.labelBtnCarReception = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.carId = new AutoLedger.App.Controls.CarIdControl();
            this.inputColor = new AutoLedger.App.Controls.ModernTextBox();
            this.inputTip = new AutoLedger.App.Controls.ModernTextBox();
            this.inputBrand = new AutoLedger.App.Controls.ModernTextBox();
            this.inputModel = new AutoLedger.App.Controls.ModernTextBox();
            this.panel1.SuspendLayout();
            this.panelBtnCarReception.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.carId);
            this.panel1.Controls.Add(this.inputColor);
            this.panel1.Controls.Add(this.inputTip);
            this.panel1.Controls.Add(this.inputBrand);
            this.panel1.Controls.Add(this.inputModel);
            this.panel1.Location = new System.Drawing.Point(200, 113);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 480);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(414, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(435, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "فرم پذیرش خودرو ";
            // 
            // panelBtnCarReception
            // 
            this.panelBtnCarReception.AutoSize = true;
            this.panelBtnCarReception.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelBtnCarReception.Controls.Add(this.btnCarReception);
            this.panelBtnCarReception.Controls.Add(this.labelBtnCarReception);
            this.panelBtnCarReception.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelBtnCarReception.Location = new System.Drawing.Point(719, 113);
            this.panelBtnCarReception.Name = "panelBtnCarReception";
            this.panelBtnCarReception.Size = new System.Drawing.Size(125, 127);
            this.panelBtnCarReception.TabIndex = 5;
            // 
            // btnCarReception
            // 
            this.btnCarReception.BackgroundImage = global::AutoLedger.App.Properties.Resources.add_car;
            this.btnCarReception.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCarReception.FlatAppearance.BorderSize = 0;
            this.btnCarReception.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarReception.Location = new System.Drawing.Point(3, 3);
            this.btnCarReception.Name = "btnCarReception";
            this.btnCarReception.Size = new System.Drawing.Size(96, 100);
            this.btnCarReception.TabIndex = 2;
            this.btnCarReception.UseVisualStyleBackColor = true;
            // 
            // labelBtnCarReception
            // 
            this.labelBtnCarReception.AutoSize = true;
            this.labelBtnCarReception.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBtnCarReception.Location = new System.Drawing.Point(3, 106);
            this.labelBtnCarReception.Name = "labelBtnCarReception";
            this.labelBtnCarReception.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelBtnCarReception.Size = new System.Drawing.Size(119, 21);
            this.labelBtnCarReception.TabIndex = 1;
            this.labelBtnCarReception.Text = "1. اطلاعات خودرو";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(719, 259);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(123, 127);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::AutoLedger.App.Properties.Resources.bussiness_man;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 100);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 106);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "2. اطلاعات مالک";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 62);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(807, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "پر کردن اطلاعات خودرو و مالک یا تحویل دهنده خودرو برای تعمیرگاه و تقویت خودروی تخ" +
    "صصی آیرون تونینگ الزامی می باشد.";
            // 
            // carId
            // 
            this.carId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.carId.Location = new System.Drawing.Point(95, 33);
            this.carId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.carId.Name = "carId";
            this.carId.Size = new System.Drawing.Size(292, 70);
            this.carId.TabIndex = 5;
            // 
            // inputColor
            // 
            this.inputColor.BackColor = System.Drawing.SystemColors.Window;
            this.inputColor.BorderColor = System.Drawing.Color.LightGray;
            this.inputColor.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.inputColor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputColor.ForeColor = System.Drawing.Color.Black;
            this.inputColor.Location = new System.Drawing.Point(248, 171);
            this.inputColor.MaxLength = 30;
            this.inputColor.Name = "inputColor";
            this.inputColor.Placeholder = "رنگ";
            this.inputColor.PlaceholderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inputColor.Size = new System.Drawing.Size(145, 35);
            this.inputColor.TabIndex = 8;
            this.inputColor.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputTip
            // 
            this.inputTip.BackColor = System.Drawing.SystemColors.Window;
            this.inputTip.BorderColor = System.Drawing.Color.LightGray;
            this.inputTip.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.inputTip.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputTip.ForeColor = System.Drawing.Color.Black;
            this.inputTip.Location = new System.Drawing.Point(97, 171);
            this.inputTip.MaxLength = 100;
            this.inputTip.Name = "inputTip";
            this.inputTip.Placeholder = "تیپ";
            this.inputTip.PlaceholderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inputTip.Size = new System.Drawing.Size(145, 35);
            this.inputTip.TabIndex = 9;
            this.inputTip.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputBrand
            // 
            this.inputBrand.BackColor = System.Drawing.SystemColors.Window;
            this.inputBrand.BorderColor = System.Drawing.Color.LightGray;
            this.inputBrand.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.inputBrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputBrand.ForeColor = System.Drawing.Color.Black;
            this.inputBrand.Location = new System.Drawing.Point(248, 122);
            this.inputBrand.MaxLength = 50;
            this.inputBrand.Name = "inputBrand";
            this.inputBrand.Placeholder = "برند";
            this.inputBrand.PlaceholderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inputBrand.Size = new System.Drawing.Size(145, 35);
            this.inputBrand.TabIndex = 6;
            this.inputBrand.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputModel
            // 
            this.inputModel.BackColor = System.Drawing.SystemColors.Window;
            this.inputModel.BorderColor = System.Drawing.Color.LightGray;
            this.inputModel.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.inputModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputModel.ForeColor = System.Drawing.Color.Black;
            this.inputModel.Location = new System.Drawing.Point(97, 122);
            this.inputModel.MaxLength = 4;
            this.inputModel.Name = "inputModel";
            this.inputModel.NumbersOnly = true;
            this.inputModel.Placeholder = "مدل";
            this.inputModel.PlaceholderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inputModel.Size = new System.Drawing.Size(145, 35);
            this.inputModel.TabIndex = 7;
            this.inputModel.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(891, 683);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBtnCarReception);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "AddCarForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ثبت نام خودروی جدید";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panelBtnCarReception.ResumeLayout(false);
            this.panelBtnCarReception.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel panelBtnCarReception;
        private System.Windows.Forms.Button btnCarReception;
        private System.Windows.Forms.Label labelBtnCarReception;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Controls.CarIdControl carId;
        private Controls.ModernTextBox inputColor;
        private Controls.ModernTextBox inputTip;
        private Controls.ModernTextBox inputBrand;
        private Controls.ModernTextBox inputModel;
    }
}