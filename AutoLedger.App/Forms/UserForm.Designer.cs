namespace AutoLedger.App.Forms
{
    partial class UserForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.toolbarFormControl1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormControl();
            this.toolbarFormManager1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.inputFullName = new AutoLedger.App.Controls.ModernTextBox();
            this.InputPhoneNumber = new AutoLedger.App.Controls.ModernTextBox();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.InputAddress = new AutoLedger.App.Controls.ModernTextBox();
            this.inputPasswordCurrent = new AutoLedger.App.Controls.ModernTextBox();
            this.inputPasswordNew = new AutoLedger.App.Controls.ModernTextBox();
            this.inputPasswordNewRepeat = new AutoLedger.App.Controls.ModernTextBox();
            this.inputCreatedAt = new AutoLedger.App.Controls.ModernTextBox();
            this.inputId = new AutoLedger.App.Controls.ModernTextBox();
            this.inputNationalId = new AutoLedger.App.Controls.ModernTextBox();
            this.inputDescription = new AutoLedger.App.Controls.ModernTextBox();
            this.btnCancel = new AutoLedger.App.Controls.ModernButton();
            this.btnConfirm = new AutoLedger.App.Controls.ModernButton();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // toolbarFormControl1
            // 
            this.toolbarFormControl1.Location = new System.Drawing.Point(0, 0);
            this.toolbarFormControl1.Manager = this.toolbarFormManager1;
            this.toolbarFormControl1.Name = "toolbarFormControl1";
            this.toolbarFormControl1.Size = new System.Drawing.Size(807, 33);
            this.toolbarFormControl1.TabIndex = 2;
            this.toolbarFormControl1.TabStop = false;
            this.toolbarFormControl1.ToolbarForm = this;
            // 
            // toolbarFormManager1
            // 
            this.toolbarFormManager1.DockControls.Add(this.barDockControlTop);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlBottom);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlLeft);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlRight);
            this.toolbarFormManager1.Form = this;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 33);
            this.barDockControlTop.Manager = this.toolbarFormManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(807, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 492);
            this.barDockControlBottom.Manager = this.toolbarFormManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(807, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 33);
            this.barDockControlLeft.Manager = this.toolbarFormManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 459);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(807, 33);
            this.barDockControlRight.Manager = this.toolbarFormManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 459);
            // 
            // inputFullName
            // 
            this.inputFullName.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.inputFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputFullName.BackColor = System.Drawing.SystemColors.Window;
            this.inputFullName.BorderColor = System.Drawing.Color.LightGray;
            this.inputFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputFullName.ForeColor = System.Drawing.Color.Black;
            this.inputFullName.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.inputFullName.Icon = global::AutoLedger.App.Properties.Resources.bussiness_man;
            this.inputFullName.Location = new System.Drawing.Point(377, 57);
            this.inputFullName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputFullName.MaxLength = 100;
            this.inputFullName.Name = "inputFullName";
            this.inputFullName.Placeholder = "نام و نام خانوادگی";
            this.inputFullName.PlaceholderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inputFullName.Size = new System.Drawing.Size(256, 43);
            this.inputFullName.TabIndex = 9;
            this.inputFullName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InputPhoneNumber
            // 
            this.InputPhoneNumber.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.InputPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InputPhoneNumber.BackColor = System.Drawing.Color.White;
            this.InputPhoneNumber.BorderColor = System.Drawing.Color.LightGray;
            this.InputPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.InputPhoneNumber.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.InputPhoneNumber.Icon = global::AutoLedger.App.Properties.Resources.phone_128;
            this.InputPhoneNumber.Location = new System.Drawing.Point(377, 108);
            this.InputPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InputPhoneNumber.MaxLength = 15;
            this.InputPhoneNumber.Name = "InputPhoneNumber";
            this.InputPhoneNumber.Placeholder = "تلفن همراه";
            this.InputPhoneNumber.PlaceholderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.InputPhoneNumber.Size = new System.Drawing.Size(256, 41);
            this.InputPhoneNumber.TabIndex = 10;
            this.InputPhoneNumber.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::AutoLedger.App.Properties.Resources.administrator_male_80px;
            this.pictureEdit1.Location = new System.Drawing.Point(651, 55);
            this.pictureEdit1.MenuManager = this.toolbarFormManager1;
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(109, 109);
            this.pictureEdit1.TabIndex = 11;
            // 
            // InputAddress
            // 
            this.InputAddress.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.InputAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InputAddress.BackColor = System.Drawing.Color.White;
            this.InputAddress.BorderColor = System.Drawing.Color.LightGray;
            this.InputAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputAddress.ForeColor = System.Drawing.Color.Black;
            this.InputAddress.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.InputAddress.Icon = global::AutoLedger.App.Properties.Resources.zoom_to_fit_128;
            this.InputAddress.Location = new System.Drawing.Point(366, 228);
            this.InputAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InputAddress.MaxLength = 200;
            this.InputAddress.Name = "InputAddress";
            this.InputAddress.Placeholder = "آدرس";
            this.InputAddress.PlaceholderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.InputAddress.Size = new System.Drawing.Size(394, 75);
            this.InputAddress.TabIndex = 12;
            this.InputAddress.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // inputPasswordCurrent
            // 
            this.inputPasswordCurrent.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.inputPasswordCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputPasswordCurrent.BackColor = System.Drawing.SystemColors.Window;
            this.inputPasswordCurrent.BorderColor = System.Drawing.Color.LightGray;
            this.inputPasswordCurrent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputPasswordCurrent.ForeColor = System.Drawing.Color.Black;
            this.inputPasswordCurrent.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.inputPasswordCurrent.Icon = global::AutoLedger.App.Properties.Resources.security_lock_128;
            this.inputPasswordCurrent.Location = new System.Drawing.Point(29, 111);
            this.inputPasswordCurrent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputPasswordCurrent.MaxLength = 20;
            this.inputPasswordCurrent.Name = "inputPasswordCurrent";
            this.inputPasswordCurrent.Placeholder = "رمز فعلی";
            this.inputPasswordCurrent.PlaceholderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inputPasswordCurrent.Size = new System.Drawing.Size(256, 41);
            this.inputPasswordCurrent.TabIndex = 13;
            this.inputPasswordCurrent.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputPasswordNew
            // 
            this.inputPasswordNew.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.inputPasswordNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputPasswordNew.BackColor = System.Drawing.Color.Brown;
            this.inputPasswordNew.BorderColor = System.Drawing.Color.LightGray;
            this.inputPasswordNew.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputPasswordNew.ForeColor = System.Drawing.Color.White;
            this.inputPasswordNew.HoverColor = System.Drawing.SystemColors.ControlDark;
            this.inputPasswordNew.Icon = global::AutoLedger.App.Properties.Resources.security_lock_128;
            this.inputPasswordNew.Location = new System.Drawing.Point(29, 159);
            this.inputPasswordNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputPasswordNew.MaxLength = 20;
            this.inputPasswordNew.Name = "inputPasswordNew";
            this.inputPasswordNew.PasswordChar = '*';
            this.inputPasswordNew.Placeholder = "رمز جدید";
            this.inputPasswordNew.PlaceholderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inputPasswordNew.Size = new System.Drawing.Size(256, 41);
            this.inputPasswordNew.TabIndex = 14;
            this.inputPasswordNew.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputPasswordNew.UseSystemPasswordChar = true;
            // 
            // inputPasswordNewRepeat
            // 
            this.inputPasswordNewRepeat.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.inputPasswordNewRepeat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputPasswordNewRepeat.BackColor = System.Drawing.Color.Brown;
            this.inputPasswordNewRepeat.BorderColor = System.Drawing.Color.LightGray;
            this.inputPasswordNewRepeat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputPasswordNewRepeat.ForeColor = System.Drawing.Color.White;
            this.inputPasswordNewRepeat.HoverColor = System.Drawing.SystemColors.ControlDark;
            this.inputPasswordNewRepeat.Icon = global::AutoLedger.App.Properties.Resources.security_lock_128;
            this.inputPasswordNewRepeat.Location = new System.Drawing.Point(29, 201);
            this.inputPasswordNewRepeat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputPasswordNewRepeat.MaxLength = 20;
            this.inputPasswordNewRepeat.Name = "inputPasswordNewRepeat";
            this.inputPasswordNewRepeat.PasswordChar = '*';
            this.inputPasswordNewRepeat.Placeholder = "تکرار رمز عبور";
            this.inputPasswordNewRepeat.PlaceholderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inputPasswordNewRepeat.Size = new System.Drawing.Size(256, 43);
            this.inputPasswordNewRepeat.TabIndex = 15;
            this.inputPasswordNewRepeat.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputPasswordNewRepeat.UseSystemPasswordChar = true;
            // 
            // inputCreatedAt
            // 
            this.inputCreatedAt.AccentColor = System.Drawing.Color.Empty;
            this.inputCreatedAt.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.inputCreatedAt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.inputCreatedAt.CornerRadius = 2;
            this.inputCreatedAt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputCreatedAt.Enabled = false;
            this.inputCreatedAt.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCreatedAt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.inputCreatedAt.HoverColor = System.Drawing.Color.Empty;
            this.inputCreatedAt.Icon = global::AutoLedger.App.Properties.Resources.calendar_1_128;
            this.inputCreatedAt.Location = new System.Drawing.Point(29, 58);
            this.inputCreatedAt.Margin = new System.Windows.Forms.Padding(0);
            this.inputCreatedAt.Name = "inputCreatedAt";
            this.inputCreatedAt.Placeholder = "[تاریخ ایجاد]";
            this.inputCreatedAt.PlaceholderColor = System.Drawing.Color.BlanchedAlmond;
            this.inputCreatedAt.ShowClearButton = false;
            this.inputCreatedAt.Size = new System.Drawing.Size(256, 35);
            this.inputCreatedAt.TabIndex = 17;
            this.inputCreatedAt.Text = "[تاریخ]";
            this.inputCreatedAt.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputId
            // 
            this.inputId.AccentColor = System.Drawing.Color.Empty;
            this.inputId.BackColor = System.Drawing.Color.DarkRed;
            this.inputId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.inputId.CornerRadius = 0;
            this.inputId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputId.Enabled = false;
            this.inputId.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputId.ForeColor = System.Drawing.Color.White;
            this.inputId.HoverColor = System.Drawing.Color.Empty;
            this.inputId.Icon = global::AutoLedger.App.Properties.Resources.security_lock_128;
            this.inputId.Location = new System.Drawing.Point(651, 170);
            this.inputId.Name = "inputId";
            this.inputId.Placeholder = "[شناسه]";
            this.inputId.PlaceholderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inputId.ShowClearButton = false;
            this.inputId.Size = new System.Drawing.Size(109, 35);
            this.inputId.TabIndex = 16;
            this.inputId.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputNationalId
            // 
            this.inputNationalId.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.inputNationalId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputNationalId.BackColor = System.Drawing.Color.White;
            this.inputNationalId.BorderColor = System.Drawing.Color.LightGray;
            this.inputNationalId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputNationalId.ForeColor = System.Drawing.Color.Black;
            this.inputNationalId.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.inputNationalId.Icon = global::AutoLedger.App.Properties.Resources.verified_badge_128;
            this.inputNationalId.Location = new System.Drawing.Point(377, 159);
            this.inputNationalId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputNationalId.MaxLength = 11;
            this.inputNationalId.Name = "inputNationalId";
            this.inputNationalId.Placeholder = "کد ملی";
            this.inputNationalId.PlaceholderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inputNationalId.Size = new System.Drawing.Size(256, 41);
            this.inputNationalId.TabIndex = 18;
            this.inputNationalId.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputDescription
            // 
            this.inputDescription.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.inputDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputDescription.BackColor = System.Drawing.Color.White;
            this.inputDescription.BorderColor = System.Drawing.Color.LightGray;
            this.inputDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputDescription.ForeColor = System.Drawing.Color.Black;
            this.inputDescription.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.inputDescription.Icon = global::AutoLedger.App.Properties.Resources.iran;
            this.inputDescription.Location = new System.Drawing.Point(29, 311);
            this.inputDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputDescription.MaxLength = 500;
            this.inputDescription.Name = "inputDescription";
            this.inputDescription.Placeholder = "توضیحات";
            this.inputDescription.PlaceholderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inputDescription.Size = new System.Drawing.Size(731, 85);
            this.inputDescription.TabIndex = 19;
            this.inputDescription.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.btnCancel.BaseBackColor = System.Drawing.Color.Gray;
            this.btnCancel.BorderColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverBackColor = System.Drawing.Color.Empty;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(500, 426);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnCancel.Size = new System.Drawing.Size(84, 43);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "لغو";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.btnConfirm.BaseBackColor = System.Drawing.Color.Green;
            this.btnConfirm.BorderColor = System.Drawing.Color.Transparent;
            this.btnConfirm.CornerRadius = 2;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.HoverBackColor = System.Drawing.Color.Empty;
            this.btnConfirm.Icon = global::AutoLedger.App.Properties.Resources.approval_128;
            this.btnConfirm.IconSize = 22;
            this.btnConfirm.Location = new System.Drawing.Point(590, 421);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnConfirm.Size = new System.Drawing.Size(170, 48);
            this.btnConfirm.TabIndex = 21;
            this.btnConfirm.Text = "تایید";
            this.btnConfirm.UseVisualStyleBackColor = false;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 492);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.inputDescription);
            this.Controls.Add(this.inputNationalId);
            this.Controls.Add(this.inputCreatedAt);
            this.Controls.Add(this.inputId);
            this.Controls.Add(this.inputPasswordNewRepeat);
            this.Controls.Add(this.inputPasswordCurrent);
            this.Controls.Add(this.inputPasswordNew);
            this.Controls.Add(this.InputAddress);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.inputFullName);
            this.Controls.Add(this.InputPhoneNumber);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.toolbarFormControl1);
            this.HtmlText = "[کاربر]";
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("UserForm.IconOptions.Icon")));
            this.IconOptions.Image = global::AutoLedger.App.Properties.Resources.irontuning_icon;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ToolbarFormControl = this.toolbarFormControl1;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormControl toolbarFormControl1;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormManager toolbarFormManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private Controls.ModernTextBox inputFullName;
        private Controls.ModernTextBox InputPhoneNumber;
        private Controls.ModernTextBox inputPasswordNewRepeat;
        private Controls.ModernTextBox inputPasswordCurrent;
        private Controls.ModernTextBox inputPasswordNew;
        private Controls.ModernTextBox InputAddress;
        private Controls.ModernTextBox inputDescription;
        private Controls.ModernTextBox inputNationalId;
        private Controls.ModernTextBox inputCreatedAt;
        private Controls.ModernTextBox inputId;
        private Controls.ModernButton btnCancel;
        private Controls.ModernButton btnConfirm;
    }
}