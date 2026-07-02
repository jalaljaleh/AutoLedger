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
            this.labelVersion = new System.Windows.Forms.Label();
            this.inputPassword = new AutoLedger.App.Controls.ModernTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cbUsername = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUsername.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.BackColor = System.Drawing.Color.Transparent;
            this.labelVersion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelVersion.ForeColor = System.Drawing.Color.Cornsilk;
            this.labelVersion.Location = new System.Drawing.Point(2, 655);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(10);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(53, 22);
            this.labelVersion.TabIndex = 4;
            this.labelVersion.Text = "Version";
            // 
            // inputPassword
            // 
            this.inputPassword.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.inputPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inputPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.inputPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.inputPassword.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.inputPassword.Icon = global::AutoLedger.App.Properties.Resources.security_lock_128;
            this.inputPassword.Location = new System.Drawing.Point(693, 325);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.PasswordChar = '*';
            this.inputPassword.Placeholder = "رمز عبور";
            this.inputPassword.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.inputPassword.Size = new System.Drawing.Size(260, 40);
            this.inputPassword.TabIndex = 2;
            this.inputPassword.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(2, 3);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1076, 674);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // cbUsername
            // 
            this.cbUsername.EditValue = "نام کاربری";
            this.cbUsername.EnterMoveNextControl = true;
            this.cbUsername.Location = new System.Drawing.Point(693, 275);
            this.cbUsername.Name = "cbUsername";
            this.cbUsername.Properties.Appearance.Options.UseTextOptions = true;
            this.cbUsername.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbUsername.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUsername.Properties.NullText = "نام کاربری";
            this.cbUsername.Size = new System.Drawing.Size(260, 34);
            this.cbUsername.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.btnLogin.Appearance.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Appearance.Options.UseBackColor = true;
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.Location = new System.Drawing.Point(837, 393);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(116, 36);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "ورود";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1080, 680);
            this.ControlBox = false;
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cbUsername);
            this.Controls.Add(this.inputPassword);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نرم افزار حسابداری آیرون توینینگ";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUsername.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelVersion;
        private Controls.ModernTextBox inputPassword;
        private DevExpress.XtraEditors.ComboBoxEdit cbUsername;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
    }
}