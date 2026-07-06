namespace AutoLedger.App.Forms
{
    partial class CarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarForm));
            this.toolbarFormControl1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormControl();
            this.toolbarFormManager1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.stepProgressBar1 = new DevExpress.XtraEditors.StepProgressBar();
            this.btnCarInfo = new DevExpress.XtraEditors.StepProgressBarItem();
            this.btnCarOwnerInfo = new DevExpress.XtraEditors.StepProgressBarItem();
            this.btnNone = new DevExpress.XtraEditors.StepProgressBarItem();
            this.btnCarReception = new System.Windows.Forms.Button();
            this.inputBrand = new AutoLedger.App.Controls.ModernTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputUserCardId = new AutoLedger.App.Controls.ModernTextBox();
            this.inputFullName = new AutoLedger.App.Controls.ModernTextBox();
            this.inputPhoneNumber = new AutoLedger.App.Controls.ModernTextBox();
            this.inputColor = new AutoLedger.App.Controls.ModernTextBox();
            this.inputTip = new AutoLedger.App.Controls.ModernTextBox();
            this.inputModel = new AutoLedger.App.Controls.ModernTextBox();
            this.carIdControl = new AutoLedger.App.Controls.CarIdControl();
            this.inputCreatedAt = new AutoLedger.App.Controls.ModernTextBox();
            this.inputId = new AutoLedger.App.Controls.ModernTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNext = new AutoLedger.App.Controls.ModernButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepProgressBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolbarFormControl1
            // 
            this.toolbarFormControl1.Location = new System.Drawing.Point(0, 0);
            this.toolbarFormControl1.Manager = this.toolbarFormManager1;
            this.toolbarFormControl1.Name = "toolbarFormControl1";
            this.toolbarFormControl1.Size = new System.Drawing.Size(637, 33);
            this.toolbarFormControl1.TabIndex = 0;
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
            this.barDockControlTop.Size = new System.Drawing.Size(637, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 667);
            this.barDockControlBottom.Manager = this.toolbarFormManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(637, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 33);
            this.barDockControlLeft.Manager = this.toolbarFormManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 634);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(637, 33);
            this.barDockControlRight.Manager = this.toolbarFormManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 634);
            // 
            // stepProgressBar1
            // 
            this.stepProgressBar1.AllowUserInteraction = DevExpress.Utils.DefaultBoolean.True;
            this.stepProgressBar1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.stepProgressBar1.Appearance.ForeColor = System.Drawing.Color.DarkGreen;
            this.stepProgressBar1.Appearance.Options.UseBackColor = true;
            this.stepProgressBar1.Appearance.Options.UseForeColor = true;
            this.stepProgressBar1.Appearances.CommonActiveColor = System.Drawing.Color.DarkGreen;
            this.stepProgressBar1.Appearances.ItemAppearance.ActiveIndicatorColor = System.Drawing.Color.DarkGreen;
            this.stepProgressBar1.ConnectorLineThickness = 5;
            this.stepProgressBar1.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.stepProgressBar1.Items.Add(this.btnCarInfo);
            this.stepProgressBar1.Items.Add(this.btnCarOwnerInfo);
            this.stepProgressBar1.Items.Add(this.btnNone);
            this.stepProgressBar1.LayoutMode = DevExpress.XtraEditors.StepProgressBarLayoutMode.FullSize;
            this.stepProgressBar1.Location = new System.Drawing.Point(345, 167);
            this.stepProgressBar1.Name = "stepProgressBar1";
            this.stepProgressBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.stepProgressBar1.ProgressMode = DevExpress.XtraEditors.Controls.StepProgressBar.ProgressMode.Range;
            this.stepProgressBar1.ShadowDrawMode = ((DevExpress.XtraEditors.StepProgressBarShadowDrawMode)((DevExpress.XtraEditors.StepProgressBarShadowDrawMode.ActiveElements | DevExpress.XtraEditors.StepProgressBarShadowDrawMode.InactiveElements)));
            this.stepProgressBar1.Size = new System.Drawing.Size(256, 461);
            this.stepProgressBar1.TabIndex = 20;
            // 
            // btnCarInfo
            // 
            this.btnCarInfo.AllowUserInteraction = DevExpress.Utils.DefaultBoolean.False;
            this.btnCarInfo.Appearance.ActiveIndicatorColor = System.Drawing.Color.DarkGreen;
            this.btnCarInfo.ContentBlock1.Caption = "1";
            this.btnCarInfo.ContentBlock2.Caption = "ثبت اطلاعات خودرو";
            this.btnCarInfo.Name = "btnCarInfo";
            this.btnCarInfo.Options.Indicator.ActiveStateDrawMode = DevExpress.XtraEditors.IndicatorDrawMode.Outline;
            // 
            // btnCarOwnerInfo
            // 
            this.btnCarOwnerInfo.AllowUserInteraction = DevExpress.Utils.DefaultBoolean.False;
            this.btnCarOwnerInfo.Appearance.ActiveIndicatorColor = System.Drawing.Color.DarkGreen;
            this.btnCarOwnerInfo.ContentBlock1.Caption = "2";
            this.btnCarOwnerInfo.ContentBlock2.Caption = "ثبت اطلاعات تحویل دهنده";
            this.btnCarOwnerInfo.Name = "btnCarOwnerInfo";
            this.btnCarOwnerInfo.Options.Indicator.ActiveStateDrawMode = DevExpress.XtraEditors.IndicatorDrawMode.Outline;
            // 
            // btnNone
            // 
            this.btnNone.AllowUserInteraction = DevExpress.Utils.DefaultBoolean.False;
            this.btnNone.Appearance.ActiveIndicatorColor = System.Drawing.Color.DarkGreen;
            this.btnNone.ContentBlock1.Caption = "3";
            this.btnNone.ContentBlock2.Caption = "فرم پذیرش";
            this.btnNone.Name = "btnNone";
            // 
            // btnCarReception
            // 
            this.btnCarReception.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCarReception.BackgroundImage = global::AutoLedger.App.Properties.Resources.irontuning_icon1;
            this.btnCarReception.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCarReception.Enabled = false;
            this.btnCarReception.FlatAppearance.BorderSize = 0;
            this.btnCarReception.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarReception.Location = new System.Drawing.Point(428, 33);
            this.btnCarReception.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCarReception.Name = "btnCarReception";
            this.btnCarReception.Size = new System.Drawing.Size(135, 129);
            this.btnCarReception.TabIndex = 2;
            this.btnCarReception.UseVisualStyleBackColor = true;
            // 
            // inputBrand
            // 
            this.inputBrand.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.inputBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputBrand.BackColor = System.Drawing.SystemColors.Window;
            this.inputBrand.BorderColor = System.Drawing.Color.LightGray;
            this.inputBrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputBrand.ForeColor = System.Drawing.Color.Black;
            this.inputBrand.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.inputBrand.Icon = global::AutoLedger.App.Properties.Resources.mercedes_benz_128;
            this.inputBrand.Location = new System.Drawing.Point(178, 266);
            this.inputBrand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputBrand.MaxLength = 50;
            this.inputBrand.Name = "inputBrand";
            this.inputBrand.Placeholder = "برند";
            this.inputBrand.PlaceholderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inputBrand.Size = new System.Drawing.Size(141, 44);
            this.inputBrand.TabIndex = 2;
            this.inputBrand.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Vazirmatn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(265, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 38);
            this.label2.TabIndex = 15;
            this.label2.Text = "فرم پذیرش خودرو";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputUserCardId
            // 
            this.inputUserCardId.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.inputUserCardId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputUserCardId.BackColor = System.Drawing.Color.White;
            this.inputUserCardId.BorderColor = System.Drawing.Color.LightGray;
            this.inputUserCardId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputUserCardId.ForeColor = System.Drawing.Color.Black;
            this.inputUserCardId.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.inputUserCardId.Icon = global::AutoLedger.App.Properties.Resources.verified_badge_128;
            this.inputUserCardId.Location = new System.Drawing.Point(37, 501);
            this.inputUserCardId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputUserCardId.MaxLength = 10;
            this.inputUserCardId.Name = "inputUserCardId";
            this.inputUserCardId.Placeholder = "کد ملی";
            this.inputUserCardId.PlaceholderColor = System.Drawing.Color.Black;
            this.inputUserCardId.Size = new System.Drawing.Size(282, 42);
            this.inputUserCardId.TabIndex = 6;
            this.inputUserCardId.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.inputFullName.Location = new System.Drawing.Point(37, 400);
            this.inputFullName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputFullName.MaxLength = 150;
            this.inputFullName.Name = "inputFullName";
            this.inputFullName.Placeholder = "نام و نام خانوادگی";
            this.inputFullName.PlaceholderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inputFullName.Size = new System.Drawing.Size(282, 43);
            this.inputFullName.TabIndex = 7;
            this.inputFullName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputPhoneNumber
            // 
            this.inputPhoneNumber.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.inputPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputPhoneNumber.BackColor = System.Drawing.Color.White;
            this.inputPhoneNumber.BorderColor = System.Drawing.Color.LightGray;
            this.inputPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.inputPhoneNumber.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.inputPhoneNumber.Icon = global::AutoLedger.App.Properties.Resources.phone_128;
            this.inputPhoneNumber.Location = new System.Drawing.Point(37, 451);
            this.inputPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputPhoneNumber.MaxLength = 15;
            this.inputPhoneNumber.Name = "inputPhoneNumber";
            this.inputPhoneNumber.Placeholder = "تلفن همراه";
            this.inputPhoneNumber.PlaceholderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inputPhoneNumber.Size = new System.Drawing.Size(282, 42);
            this.inputPhoneNumber.TabIndex = 8;
            this.inputPhoneNumber.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputColor
            // 
            this.inputColor.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.inputColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputColor.BackColor = System.Drawing.SystemColors.Window;
            this.inputColor.BorderColor = System.Drawing.Color.LightGray;
            this.inputColor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputColor.ForeColor = System.Drawing.Color.Black;
            this.inputColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.inputColor.Icon = global::AutoLedger.App.Properties.Resources.color_wheel_128;
            this.inputColor.Location = new System.Drawing.Point(178, 323);
            this.inputColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputColor.MaxLength = 30;
            this.inputColor.Name = "inputColor";
            this.inputColor.Placeholder = "رنگ";
            this.inputColor.PlaceholderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inputColor.Size = new System.Drawing.Size(141, 42);
            this.inputColor.TabIndex = 3;
            this.inputColor.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputTip
            // 
            this.inputTip.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.inputTip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputTip.BackColor = System.Drawing.SystemColors.Window;
            this.inputTip.BorderColor = System.Drawing.Color.LightGray;
            this.inputTip.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputTip.ForeColor = System.Drawing.Color.Black;
            this.inputTip.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.inputTip.Icon = global::AutoLedger.App.Properties.Resources.info_128;
            this.inputTip.Location = new System.Drawing.Point(37, 266);
            this.inputTip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputTip.MaxLength = 100;
            this.inputTip.Name = "inputTip";
            this.inputTip.Placeholder = "تیپ";
            this.inputTip.PlaceholderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inputTip.Size = new System.Drawing.Size(135, 44);
            this.inputTip.TabIndex = 4;
            this.inputTip.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputModel
            // 
            this.inputModel.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.inputModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputModel.BackColor = System.Drawing.SystemColors.Window;
            this.inputModel.BorderColor = System.Drawing.Color.LightGray;
            this.inputModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputModel.ForeColor = System.Drawing.Color.Black;
            this.inputModel.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.inputModel.Icon = global::AutoLedger.App.Properties.Resources.tesla_model_x_128;
            this.inputModel.Location = new System.Drawing.Point(37, 323);
            this.inputModel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputModel.MaxLength = 6;
            this.inputModel.Name = "inputModel";
            this.inputModel.NumbersOnly = true;
            this.inputModel.Placeholder = "مدل";
            this.inputModel.PlaceholderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inputModel.Size = new System.Drawing.Size(135, 44);
            this.inputModel.TabIndex = 2;
            this.inputModel.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // carIdControl
            // 
            this.carIdControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.carIdControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carIdControl.Enabled = false;
            this.carIdControl.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carIdControl.Location = new System.Drawing.Point(37, 176);
            this.carIdControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.carIdControl.Name = "carIdControl";
            this.carIdControl.Size = new System.Drawing.Size(282, 81);
            this.carIdControl.TabIndex = 1;
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
            this.inputCreatedAt.Location = new System.Drawing.Point(18, 90);
            this.inputCreatedAt.Margin = new System.Windows.Forms.Padding(0);
            this.inputCreatedAt.Name = "inputCreatedAt";
            this.inputCreatedAt.Placeholder = "[تاریخ ایجاد]";
            this.inputCreatedAt.PlaceholderColor = System.Drawing.Color.BlanchedAlmond;
            this.inputCreatedAt.ShowClearButton = false;
            this.inputCreatedAt.Size = new System.Drawing.Size(211, 38);
            this.inputCreatedAt.TabIndex = 34;
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
            this.inputId.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Bold);
            this.inputId.ForeColor = System.Drawing.Color.White;
            this.inputId.HoverColor = System.Drawing.Color.Empty;
            this.inputId.Icon = global::AutoLedger.App.Properties.Resources.security_lock_128;
            this.inputId.Location = new System.Drawing.Point(18, 49);
            this.inputId.Name = "inputId";
            this.inputId.Placeholder = "[شناسه پذیرش]";
            this.inputId.PlaceholderColor = System.Drawing.Color.WhiteSmoke;
            this.inputId.ShowClearButton = false;
            this.inputId.Size = new System.Drawing.Size(211, 38);
            this.inputId.TabIndex = 33;
            this.inputId.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.Location = new System.Drawing.Point(37, 581);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 44);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "لغو";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNext.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnNext.BaseBackColor = System.Drawing.Color.DarkGreen;
            this.btnNext.BorderColor = System.Drawing.Color.Gray;
            this.btnNext.CornerRadius = 2;
            this.btnNext.FlatAppearance.BorderSize = 6;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.HoverBackColor = System.Drawing.Color.LightGray;
            this.btnNext.Icon = global::AutoLedger.App.Properties.Resources.approval_128;
            this.btnNext.IconSize = 20;
            this.btnNext.Location = new System.Drawing.Point(129, 579);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.PressedBackColor = System.Drawing.Color.DarkGray;
            this.btnNext.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNext.Size = new System.Drawing.Size(190, 49);
            this.btnNext.TabIndex = 35;
            this.btnNext.Text = "ثبت و تایید اطلاعات";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Vazirmatn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(265, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 38);
            this.label1.TabIndex = 41;
            this.label1.Text = "آیرون تیونینگ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CarForm
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 667);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stepProgressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.inputCreatedAt);
            this.Controls.Add(this.inputId);
            this.Controls.Add(this.inputBrand);
            this.Controls.Add(this.inputColor);
            this.Controls.Add(this.inputTip);
            this.Controls.Add(this.inputModel);
            this.Controls.Add(this.inputFullName);
            this.Controls.Add(this.inputPhoneNumber);
            this.Controls.Add(this.inputUserCardId);
            this.Controls.Add(this.carIdControl);
            this.Controls.Add(this.btnCarReception);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.toolbarFormControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("CarForm.IconOptions.Icon")));
            this.IconOptions.Image = global::AutoLedger.App.Properties.Resources.irontuning_icon;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CarForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "فرم ثبت اطلاعات خودرو";
            this.ToolbarFormControl = this.toolbarFormControl1;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepProgressBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.ToolbarForm.ToolbarFormControl toolbarFormControl1;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormManager toolbarFormManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Button btnCarReception;
        private Controls.ModernTextBox inputBrand;
        private System.Windows.Forms.Label label2;
        private Controls.ModernTextBox inputColor;
        private Controls.ModernTextBox inputTip;
        private Controls.ModernTextBox inputModel;
        private Controls.CarIdControl carIdControl;
        private DevExpress.XtraEditors.StepProgressBar stepProgressBar1;
        private Controls.ModernTextBox inputFullName;
        private Controls.ModernTextBox inputPhoneNumber;
        private Controls.ModernTextBox inputUserCardId;
        private DevExpress.XtraEditors.StepProgressBarItem btnCarInfo;
        private DevExpress.XtraEditors.StepProgressBarItem btnCarOwnerInfo;
        private DevExpress.XtraEditors.StepProgressBarItem btnNone;
        private Controls.ModernTextBox inputCreatedAt;
        private Controls.ModernTextBox inputId;
        private System.Windows.Forms.Button btnCancel;
        private Controls.ModernButton btnNext;
        private System.Windows.Forms.Label label1;
    }
}