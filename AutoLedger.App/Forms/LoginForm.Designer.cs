namespace AutoLedger.App.Forms
{
    partial class LoginForm
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
            this.labelVersion = new System.Windows.Forms.Label();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.labelTime = new DevExpress.XtraEditors.LabelControl();
            this.cbUsername = new DevExpress.XtraEditors.ComboBoxEdit();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelMenuMain = new System.Windows.Forms.Panel();
            this.labelLoading = new System.Windows.Forms.Label();
            this.btnTelegram = new AutoLedger.App.Controls.ModernButton();
            this.btnSourceCode = new AutoLedger.App.Controls.ModernButton();
            this.btnDeveloper = new AutoLedger.App.Controls.ModernButton();
            this.inputPassword = new AutoLedger.App.Controls.ModernTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cbUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelMenuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelVersion
            // 
            this.labelVersion.BackColor = System.Drawing.Color.Transparent;
            this.labelVersion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelVersion.ForeColor = System.Drawing.Color.Cornsilk;
            this.labelVersion.Location = new System.Drawing.Point(0, 632);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(10);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Padding = new System.Windows.Forms.Padding(5);
            this.labelVersion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelVersion.Size = new System.Drawing.Size(321, 42);
            this.labelVersion.TabIndex = 4;
            this.labelVersion.Text = "Version";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.btnLogin.Appearance.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Appearance.Options.UseBackColor = true;
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.Location = new System.Drawing.Point(170, 314);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(116, 36);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "ورود";
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.Appearance.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Appearance.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelTime.Appearance.Options.UseBackColor = true;
            this.labelTime.Appearance.Options.UseFont = true;
            this.labelTime.Appearance.Options.UseForeColor = true;
            this.labelTime.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelTime.Location = new System.Drawing.Point(45, 86);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(235, 33);
            this.labelTime.TabIndex = 8;
            this.labelTime.Text = "[تاریخ]";
            // 
            // cbUsername
            // 
            this.cbUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbUsername.EditValue = "نام کاربری";
            this.cbUsername.EnterMoveNextControl = true;
            this.cbUsername.Location = new System.Drawing.Point(23, 205);
            this.cbUsername.Name = "cbUsername";
            this.cbUsername.Properties.Appearance.BackColor = System.Drawing.SystemColors.Highlight;
            this.cbUsername.Properties.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F, System.Drawing.FontStyle.Bold);
            this.cbUsername.Properties.Appearance.Options.UseBackColor = true;
            this.cbUsername.Properties.Appearance.Options.UseFont = true;
            this.cbUsername.Properties.Appearance.Options.UseTextOptions = true;
            this.cbUsername.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbUsername.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUsername.Properties.NullText = "نام کاربری";
            this.cbUsername.Size = new System.Drawing.Size(260, 36);
            this.cbUsername.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::AutoLedger.App.Properties.Resources.splashScreen;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(753, 674);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Vazirmatn", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(40, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 41);
            this.label1.TabIndex = 18;
            this.label1.Text = "حسابداری آیرون تیونینگ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(119, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "نام و رمز کاربری خود را وارد کنید.";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMenu.BackgroundImage = global::AutoLedger.App.Properties.Resources.black_background;
            this.panelMenu.Controls.Add(this.labelVersion);
            this.panelMenu.Controls.Add(this.panelMenuMain);
            this.panelMenu.Controls.Add(this.labelLoading);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenu.Location = new System.Drawing.Point(756, 3);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(321, 674);
            this.panelMenu.TabIndex = 20;
            // 
            // panelMenuMain
            // 
            this.panelMenuMain.Controls.Add(this.btnTelegram);
            this.panelMenuMain.Controls.Add(this.label2);
            this.panelMenuMain.Controls.Add(this.label1);
            this.panelMenuMain.Controls.Add(this.btnSourceCode);
            this.panelMenuMain.Controls.Add(this.btnDeveloper);
            this.panelMenuMain.Controls.Add(this.labelTime);
            this.panelMenuMain.Controls.Add(this.btnLogin);
            this.panelMenuMain.Controls.Add(this.cbUsername);
            this.panelMenuMain.Controls.Add(this.inputPassword);
            this.panelMenuMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenuMain.Location = new System.Drawing.Point(0, 0);
            this.panelMenuMain.Name = "panelMenuMain";
            this.panelMenuMain.Size = new System.Drawing.Size(321, 674);
            this.panelMenuMain.TabIndex = 20;
            // 
            // labelLoading
            // 
            this.labelLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLoading.ForeColor = System.Drawing.Color.Snow;
            this.labelLoading.Location = new System.Drawing.Point(0, 0);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(321, 674);
            this.labelLoading.TabIndex = 20;
            this.labelLoading.Text = "در حال بارگذاری ...";
            this.labelLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTelegram
            // 
            this.btnTelegram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTelegram.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnTelegram.BaseBackColor = System.Drawing.SystemColors.MenuText;
            this.btnTelegram.BorderColor = System.Drawing.Color.Gray;
            this.btnTelegram.CornerRadius = 3;
            this.btnTelegram.Elevation = 0;
            this.btnTelegram.FlatAppearance.BorderSize = 6;
            this.btnTelegram.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTelegram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTelegram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTelegram.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelegram.ForeColor = System.Drawing.SystemColors.Window;
            this.btnTelegram.HoverBackColor = System.Drawing.Color.Navy;
            this.btnTelegram.Icon = global::AutoLedger.App.Properties.Resources.email_send_32;
            this.btnTelegram.IconSize = 20;
            this.btnTelegram.Location = new System.Drawing.Point(23, 581);
            this.btnTelegram.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTelegram.Name = "btnTelegram";
            this.btnTelegram.PressedBackColor = System.Drawing.Color.DarkMagenta;
            this.btnTelegram.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTelegram.Size = new System.Drawing.Size(37, 34);
            this.btnTelegram.TabIndex = 17;
            this.btnTelegram.UseVisualStyleBackColor = false;
            // 
            // btnSourceCode
            // 
            this.btnSourceCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSourceCode.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnSourceCode.BaseBackColor = System.Drawing.SystemColors.MenuText;
            this.btnSourceCode.BorderColor = System.Drawing.Color.Gray;
            this.btnSourceCode.CornerRadius = 3;
            this.btnSourceCode.Elevation = 0;
            this.btnSourceCode.FlatAppearance.BorderSize = 6;
            this.btnSourceCode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSourceCode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSourceCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSourceCode.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSourceCode.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSourceCode.HoverBackColor = System.Drawing.Color.Navy;
            this.btnSourceCode.Icon = global::AutoLedger.App.Properties.Resources.coding;
            this.btnSourceCode.IconSize = 20;
            this.btnSourceCode.Location = new System.Drawing.Point(65, 581);
            this.btnSourceCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSourceCode.Name = "btnSourceCode";
            this.btnSourceCode.PressedBackColor = System.Drawing.Color.DarkMagenta;
            this.btnSourceCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSourceCode.Size = new System.Drawing.Size(108, 34);
            this.btnSourceCode.TabIndex = 16;
            this.btnSourceCode.Text = "سورس کد";
            this.btnSourceCode.UseVisualStyleBackColor = false;
            // 
            // btnDeveloper
            // 
            this.btnDeveloper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeveloper.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnDeveloper.BaseBackColor = System.Drawing.SystemColors.MenuText;
            this.btnDeveloper.BorderColor = System.Drawing.Color.Gray;
            this.btnDeveloper.CornerRadius = 3;
            this.btnDeveloper.Elevation = 0;
            this.btnDeveloper.FlatAppearance.BorderSize = 6;
            this.btnDeveloper.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDeveloper.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDeveloper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeveloper.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeveloper.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDeveloper.HoverBackColor = System.Drawing.Color.Navy;
            this.btnDeveloper.Icon = global::AutoLedger.App.Properties.Resources.verified_badge_128;
            this.btnDeveloper.IconSize = 20;
            this.btnDeveloper.Location = new System.Drawing.Point(179, 581);
            this.btnDeveloper.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeveloper.Name = "btnDeveloper";
            this.btnDeveloper.PressedBackColor = System.Drawing.Color.DarkMagenta;
            this.btnDeveloper.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDeveloper.Size = new System.Drawing.Size(132, 34);
            this.btnDeveloper.TabIndex = 15;
            this.btnDeveloper.Text = "توسعه دهنده";
            this.btnDeveloper.UseVisualStyleBackColor = false;
            // 
            // inputPassword
            // 
            this.inputPassword.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.inputPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputPassword.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.inputPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.inputPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.inputPassword.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.inputPassword.Icon = null;
            this.inputPassword.Location = new System.Drawing.Point(25, 256);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.PasswordChar = '*';
            this.inputPassword.Placeholder = "رمز عبور";
            this.inputPassword.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputPassword.Size = new System.Drawing.Size(260, 40);
            this.inputPassword.TabIndex = 1;
            this.inputPassword.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1080, 680);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نرم افزار حسابداری آیرون توینینگ";
            ((System.ComponentModel.ISupportInitialize)(this.cbUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenuMain.ResumeLayout(false);
            this.panelMenuMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelVersion;
        private Controls.ModernTextBox inputPassword;
        private DevExpress.XtraEditors.ComboBoxEdit cbUsername;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.LabelControl labelTime;
        private Controls.ModernButton btnDeveloper;
        private Controls.ModernButton btnSourceCode;
        private Controls.ModernButton btnTelegram;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelMenuMain;
        private System.Windows.Forms.Label labelLoading;
    }
}