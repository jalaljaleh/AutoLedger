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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelMenuMain = new System.Windows.Forms.Panel();
            this.labelVersion = new System.Windows.Forms.Label();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.labelError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTime = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.cbUsername = new DevExpress.XtraEditors.ComboBoxEdit();
            this.pbLoading = new DevExpress.XtraWaitForm.ProgressPanel();
            this.btnTelegram = new AutoLedger.App.Controls.ModernButton();
            this.btnSourceCode = new AutoLedger.App.Controls.ModernButton();
            this.btnDeveloper = new AutoLedger.App.Controls.ModernButton();
            this.inputPassword = new AutoLedger.App.Controls.ModernTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelMenuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUsername.Properties)).BeginInit();
            this.SuspendLayout();
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
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMenu.BackgroundImage = global::AutoLedger.App.Properties.Resources.black_background;
            this.panelMenu.Controls.Add(this.panelMenuMain);
            this.panelMenu.Controls.Add(this.pbLoading);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenu.Location = new System.Drawing.Point(756, 3);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(321, 674);
            this.panelMenu.TabIndex = 20;
            // 
            // panelMenuMain
            // 
            this.panelMenuMain.Controls.Add(this.btnTelegram);
            this.panelMenuMain.Controls.Add(this.btnDeveloper);
            this.panelMenuMain.Controls.Add(this.btnSourceCode);
            this.panelMenuMain.Controls.Add(this.btnExit);
            this.panelMenuMain.Controls.Add(this.labelError);
            this.panelMenuMain.Controls.Add(this.label1);
            this.panelMenuMain.Controls.Add(this.labelTime);
            this.panelMenuMain.Controls.Add(this.pictureBox1);
            this.panelMenuMain.Controls.Add(this.label2);
            this.panelMenuMain.Controls.Add(this.btnLogin);
            this.panelMenuMain.Controls.Add(this.cbUsername);
            this.panelMenuMain.Controls.Add(this.inputPassword);
            this.panelMenuMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenuMain.Location = new System.Drawing.Point(0, 0);
            this.panelMenuMain.Name = "panelMenuMain";
            this.panelMenuMain.Size = new System.Drawing.Size(321, 674);
            this.panelMenuMain.TabIndex = 20;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.BackColor = System.Drawing.Color.Transparent;
            this.labelVersion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelVersion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelVersion.Location = new System.Drawing.Point(3, 655);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(57, 22);
            this.labelVersion.TabIndex = 23;
            this.labelVersion.Text = "[version]";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Appearance.BackColor = System.Drawing.Color.Maroon;
            this.btnExit.Appearance.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.Options.UseBackColor = true;
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.Location = new System.Drawing.Point(23, 445);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 36);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "خروج";
            // 
            // labelError
            // 
            this.labelError.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelError.Location = new System.Drawing.Point(23, 494);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(273, 66);
            this.labelError.TabIndex = 21;
            this.labelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Vazirmatn", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(34, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 41);
            this.label1.TabIndex = 18;
            this.label1.Text = "حسابداری آیرون تیونینگ";
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
            this.labelTime.Location = new System.Drawing.Point(46, 238);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(235, 33);
            this.labelTime.TabIndex = 8;
            this.labelTime.Text = "[تاریخ]";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutoLedger.App.Properties.Resources.irontuning_icon1;
            this.pictureBox1.Location = new System.Drawing.Point(34, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(116, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "نام و رمز کاربری خود را وارد کنید.";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.btnLogin.Appearance.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Appearance.Options.UseBackColor = true;
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.Location = new System.Drawing.Point(116, 445);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(164, 36);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "ورود";
            // 
            // cbUsername
            // 
            this.cbUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbUsername.EditValue = "نام کاربری";
            this.cbUsername.EnterMoveNextControl = true;
            this.cbUsername.Location = new System.Drawing.Point(20, 320);
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
            // pbLoading
            // 
            this.pbLoading.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pbLoading.Appearance.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbLoading.Appearance.Options.UseBackColor = true;
            this.pbLoading.Appearance.Options.UseFont = true;
            this.pbLoading.AppearanceCaption.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbLoading.AppearanceCaption.ForeColor = System.Drawing.Color.White;
            this.pbLoading.AppearanceCaption.Options.UseFont = true;
            this.pbLoading.AppearanceCaption.Options.UseForeColor = true;
            this.pbLoading.AppearanceDescription.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbLoading.AppearanceDescription.ForeColor = System.Drawing.Color.White;
            this.pbLoading.AppearanceDescription.Options.UseFont = true;
            this.pbLoading.AppearanceDescription.Options.UseForeColor = true;
            this.pbLoading.Caption = ".. حالت انتظار";
            this.pbLoading.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.pbLoading.Description = " ..  در حال اتصال به پایگاه داده    ";
            this.pbLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLoading.Location = new System.Drawing.Point(0, 0);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pbLoading.Size = new System.Drawing.Size(321, 674);
            this.pbLoading.TabIndex = 21;
            // 
            // btnTelegram
            // 
            this.btnTelegram.BaseBackColor = System.Drawing.Color.Empty;
            this.btnTelegram.BorderColor = System.Drawing.Color.Empty;
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
            this.btnTelegram.Location = new System.Drawing.Point(279, 636);
            this.btnTelegram.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTelegram.Name = "btnTelegram";
            this.btnTelegram.PressedBackColor = System.Drawing.Color.DarkMagenta;
            this.btnTelegram.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTelegram.Size = new System.Drawing.Size(39, 34);
            this.btnTelegram.TabIndex = 17;
            this.btnTelegram.UseVisualStyleBackColor = false;
            // 
            // btnSourceCode
            // 
            this.btnSourceCode.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnSourceCode.BaseBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSourceCode.BorderColor = System.Drawing.Color.Black;
            this.btnSourceCode.CornerRadius = 0;
            this.btnSourceCode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSourceCode.Elevation = 0;
            this.btnSourceCode.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSourceCode.FlatAppearance.BorderSize = 0;
            this.btnSourceCode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSourceCode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSourceCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSourceCode.Font = new System.Drawing.Font("Vazirmatn", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSourceCode.ForeColor = System.Drawing.Color.White;
            this.btnSourceCode.HoverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnSourceCode.Icon = null;
            this.btnSourceCode.IconSize = 20;
            this.btnSourceCode.Location = new System.Drawing.Point(0, 648);
            this.btnSourceCode.Margin = new System.Windows.Forms.Padding(0);
            this.btnSourceCode.Name = "btnSourceCode";
            this.btnSourceCode.PressedBackColor = System.Drawing.Color.DarkMagenta;
            this.btnSourceCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSourceCode.Size = new System.Drawing.Size(321, 26);
            this.btnSourceCode.TabIndex = 16;
            this.btnSourceCode.Text = "Copyright ©️ 2026 Haluntm";
            this.btnSourceCode.UseVisualStyleBackColor = false;
            // 
            // btnDeveloper
            // 
            this.btnDeveloper.BaseBackColor = System.Drawing.Color.Empty;
            this.btnDeveloper.BorderColor = System.Drawing.Color.Transparent;
            this.btnDeveloper.CornerRadius = 0;
            this.btnDeveloper.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDeveloper.Elevation = 0;
            this.btnDeveloper.FlatAppearance.BorderSize = 6;
            this.btnDeveloper.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDeveloper.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDeveloper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeveloper.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeveloper.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeveloper.HoverBackColor = System.Drawing.Color.Navy;
            this.btnDeveloper.Icon = global::AutoLedger.App.Properties.Resources.verified_badge_128;
            this.btnDeveloper.IconSize = 20;
            this.btnDeveloper.Location = new System.Drawing.Point(0, 610);
            this.btnDeveloper.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeveloper.Name = "btnDeveloper";
            this.btnDeveloper.PressedBackColor = System.Drawing.Color.DarkMagenta;
            this.btnDeveloper.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDeveloper.Size = new System.Drawing.Size(321, 38);
            this.btnDeveloper.TabIndex = 15;
            this.btnDeveloper.Text = "طراحی و توسعه محمدجلال ژاله";
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
            this.inputPassword.Location = new System.Drawing.Point(20, 371);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.PasswordChar = '*';
            this.inputPassword.Placeholder = "رمز عبور";
            this.inputPassword.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputPassword.Size = new System.Drawing.Size(262, 40);
            this.inputPassword.TabIndex = 1;
            this.inputPassword.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputPassword.UseSystemPasswordChar = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1080, 680);
            this.ControlBox = false;
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نرم افزار حسابداری آیرون توینینگ";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenuMain.ResumeLayout(false);
            this.panelMenuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUsername.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraWaitForm.ProgressPanel pbLoading;
        private System.Windows.Forms.Label labelError;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private System.Windows.Forms.Label labelVersion;
    }
}