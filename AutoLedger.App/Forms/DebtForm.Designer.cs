namespace AutoLedger.App.Forms
{
    partial class DebtForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebtForm));
            this.inputTitle = new AutoLedger.App.Controls.ModernTextBox();
            this.inputDescription = new AutoLedger.App.Controls.ModernTextBox();
            this.inputAmount = new AutoLedger.App.Controls.ModernTextBox();
            this.labelAmountPersian = new System.Windows.Forms.Label();
            this.inputPaidTo = new AutoLedger.App.Controls.ModernTextBox();
            this.btnConfirm = new AutoLedger.App.Controls.ModernButton();
            this.btnCancel = new AutoLedger.App.Controls.ModernButton();
            this.toolbarFormControl1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormControl();
            this.toolbarFormManager1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.inputCreatedAt = new AutoLedger.App.Controls.ModernTextBox();
            this.inputId = new AutoLedger.App.Controls.ModernTextBox();
            this.chPayable = new DevExpress.XtraEditors.CheckEdit();
            this.chReciveable = new DevExpress.XtraEditors.CheckEdit();
            this.chSettled = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chPayable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chReciveable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chSettled.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // inputTitle
            // 
            this.inputTitle.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.inputTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputTitle.BackColor = System.Drawing.Color.White;
            this.inputTitle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.inputTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputTitle.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.inputTitle.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.inputTitle.Icon = global::AutoLedger.App.Properties.Resources.approval_128;
            this.inputTitle.Location = new System.Drawing.Point(394, 61);
            this.inputTitle.Name = "inputTitle";
            this.inputTitle.Placeholder = "عنوان";
            this.inputTitle.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.inputTitle.Size = new System.Drawing.Size(295, 48);
            this.inputTitle.TabIndex = 1;
            this.inputTitle.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputDescription
            // 
            this.inputDescription.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.inputDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputDescription.BackColor = System.Drawing.Color.White;
            this.inputDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.inputDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.inputDescription.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.inputDescription.Icon = null;
            this.inputDescription.Location = new System.Drawing.Point(394, 122);
            this.inputDescription.Name = "inputDescription";
            this.inputDescription.Placeholder = "توضیحات";
            this.inputDescription.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.inputDescription.Size = new System.Drawing.Size(295, 101);
            this.inputDescription.TabIndex = 2;
            this.inputDescription.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // inputAmount
            // 
            this.inputAmount.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.inputAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputAmount.BackColor = System.Drawing.Color.Wheat;
            this.inputAmount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.inputAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputAmount.ForeColor = System.Drawing.Color.Black;
            this.inputAmount.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.inputAmount.Icon = global::AutoLedger.App.Properties.Resources.coin;
            this.inputAmount.Location = new System.Drawing.Point(394, 233);
            this.inputAmount.Name = "inputAmount";
            this.inputAmount.NumbersOnly = true;
            this.inputAmount.Placeholder = "مبلغ";
            this.inputAmount.PlaceholderColor = System.Drawing.Color.Black;
            this.inputAmount.Size = new System.Drawing.Size(295, 45);
            this.inputAmount.TabIndex = 3;
            this.inputAmount.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelAmountPersian
            // 
            this.labelAmountPersian.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAmountPersian.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmountPersian.Location = new System.Drawing.Point(394, 287);
            this.labelAmountPersian.Name = "labelAmountPersian";
            this.labelAmountPersian.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelAmountPersian.Size = new System.Drawing.Size(294, 42);
            this.labelAmountPersian.TabIndex = 3;
            this.labelAmountPersian.Text = "0 تومان";
            // 
            // inputPaidTo
            // 
            this.inputPaidTo.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.inputPaidTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputPaidTo.BackColor = System.Drawing.Color.AliceBlue;
            this.inputPaidTo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.inputPaidTo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputPaidTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.inputPaidTo.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.inputPaidTo.Icon = global::AutoLedger.App.Properties.Resources.checked_user;
            this.inputPaidTo.Location = new System.Drawing.Point(27, 168);
            this.inputPaidTo.Name = "inputPaidTo";
            this.inputPaidTo.Placeholder = "نام و نام خانوادگی طرف حساب";
            this.inputPaidTo.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.inputPaidTo.Size = new System.Drawing.Size(334, 45);
            this.inputPaidTo.TabIndex = 4;
            this.inputPaidTo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnConfirm.Location = new System.Drawing.Point(519, 345);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnConfirm.Size = new System.Drawing.Size(170, 48);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "تایید";
            this.btnConfirm.UseVisualStyleBackColor = false;
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
            this.btnCancel.Location = new System.Drawing.Point(443, 345);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnCancel.Size = new System.Drawing.Size(70, 48);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "لغو";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // toolbarFormControl1
            // 
            this.toolbarFormControl1.Location = new System.Drawing.Point(0, 0);
            this.toolbarFormControl1.Manager = this.toolbarFormManager1;
            this.toolbarFormControl1.Name = "toolbarFormControl1";
            this.toolbarFormControl1.Size = new System.Drawing.Size(716, 33);
            this.toolbarFormControl1.TabIndex = 8;
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
            this.toolbarFormManager1.MaxItemId = 1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 33);
            this.barDockControlTop.Manager = this.toolbarFormManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(716, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 417);
            this.barDockControlBottom.Manager = this.toolbarFormManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(716, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 33);
            this.barDockControlLeft.Manager = this.toolbarFormManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 384);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(716, 33);
            this.barDockControlRight.Manager = this.toolbarFormManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 384);
            // 
            // inputCreatedAt
            // 
            this.inputCreatedAt.AccentColor = System.Drawing.Color.Empty;
            this.inputCreatedAt.BackColor = System.Drawing.Color.Lavender;
            this.inputCreatedAt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.inputCreatedAt.CornerRadius = 2;
            this.inputCreatedAt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputCreatedAt.Enabled = false;
            this.inputCreatedAt.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCreatedAt.ForeColor = System.Drawing.Color.Black;
            this.inputCreatedAt.HoverColor = System.Drawing.Color.Empty;
            this.inputCreatedAt.Icon = global::AutoLedger.App.Properties.Resources.calendar_1_128;
            this.inputCreatedAt.Location = new System.Drawing.Point(27, 104);
            this.inputCreatedAt.Margin = new System.Windows.Forms.Padding(0);
            this.inputCreatedAt.Name = "inputCreatedAt";
            this.inputCreatedAt.Placeholder = "[تاریخ ایجاد]";
            this.inputCreatedAt.PlaceholderColor = System.Drawing.Color.BlanchedAlmond;
            this.inputCreatedAt.ShowClearButton = false;
            this.inputCreatedAt.Size = new System.Drawing.Size(334, 38);
            this.inputCreatedAt.TabIndex = 36;
            this.inputCreatedAt.Text = "[تاریخ]";
            this.inputCreatedAt.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputId
            // 
            this.inputId.AccentColor = System.Drawing.Color.Empty;
            this.inputId.BackColor = System.Drawing.Color.Salmon;
            this.inputId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.inputId.CornerRadius = 0;
            this.inputId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputId.Enabled = false;
            this.inputId.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Bold);
            this.inputId.ForeColor = System.Drawing.Color.Black;
            this.inputId.HoverColor = System.Drawing.Color.Empty;
            this.inputId.Icon = global::AutoLedger.App.Properties.Resources.security_lock_128;
            this.inputId.Location = new System.Drawing.Point(27, 63);
            this.inputId.Name = "inputId";
            this.inputId.Placeholder = "[شناسه]";
            this.inputId.PlaceholderColor = System.Drawing.Color.Black;
            this.inputId.ShowClearButton = false;
            this.inputId.Size = new System.Drawing.Size(334, 38);
            this.inputId.TabIndex = 35;
            this.inputId.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chPayable
            // 
            this.chPayable.Location = new System.Drawing.Point(194, 231);
            this.chPayable.Name = "chPayable";
            this.chPayable.Properties.Appearance.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chPayable.Properties.Appearance.ForeColor = System.Drawing.Color.Brown;
            this.chPayable.Properties.Appearance.Options.UseFont = true;
            this.chPayable.Properties.Appearance.Options.UseForeColor = true;
            this.chPayable.Properties.Appearance.Options.UseTextOptions = true;
            this.chPayable.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chPayable.Properties.AutoHeight = false;
            this.chPayable.Properties.Caption = "بدهکار می‌شوم";
            this.chPayable.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.chPayable.Properties.GlyphVerticalAlignment = DevExpress.Utils.VertAlignment.Center;
            this.chPayable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chPayable.Size = new System.Drawing.Size(167, 48);
            this.chPayable.TabIndex = 5;
            // 
            // chReciveable
            // 
            this.chReciveable.Location = new System.Drawing.Point(27, 231);
            this.chReciveable.Name = "chReciveable";
            this.chReciveable.Properties.Appearance.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chReciveable.Properties.Appearance.ForeColor = System.Drawing.Color.Sienna;
            this.chReciveable.Properties.Appearance.Options.UseFont = true;
            this.chReciveable.Properties.Appearance.Options.UseForeColor = true;
            this.chReciveable.Properties.Appearance.Options.UseTextOptions = true;
            this.chReciveable.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chReciveable.Properties.AutoHeight = false;
            this.chReciveable.Properties.Caption = "طلب کار می شوم";
            this.chReciveable.Properties.ContentAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.chReciveable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chReciveable.Size = new System.Drawing.Size(161, 48);
            this.chReciveable.TabIndex = 6;
            // 
            // chSettled
            // 
            this.chSettled.Location = new System.Drawing.Point(27, 285);
            this.chSettled.Name = "chSettled";
            this.chSettled.Properties.Appearance.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chSettled.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.chSettled.Properties.Appearance.Options.UseFont = true;
            this.chSettled.Properties.Appearance.Options.UseForeColor = true;
            this.chSettled.Properties.Appearance.Options.UseTextOptions = true;
            this.chSettled.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chSettled.Properties.AutoHeight = false;
            this.chSettled.Properties.Caption = "تسویه شده است";
            this.chSettled.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chSettled.Size = new System.Drawing.Size(334, 52);
            this.chSettled.TabIndex = 7;
            // 
            // DebtForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 417);
            this.Controls.Add(this.chSettled);
            this.Controls.Add(this.chReciveable);
            this.Controls.Add(this.chPayable);
            this.Controls.Add(this.inputId);
            this.Controls.Add(this.inputCreatedAt);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.inputPaidTo);
            this.Controls.Add(this.labelAmountPersian);
            this.Controls.Add(this.inputAmount);
            this.Controls.Add(this.inputDescription);
            this.Controls.Add(this.inputTitle);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.toolbarFormControl1);
            this.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DebtForm.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DebtForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "فرم بستانکاری";
            this.ToolbarFormControl = this.toolbarFormControl1;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chPayable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chReciveable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chSettled.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ModernTextBox inputTitle;
        private Controls.ModernTextBox inputDescription;
        private Controls.ModernTextBox inputAmount;
        private System.Windows.Forms.Label labelAmountPersian;
        private Controls.ModernTextBox inputPaidTo;
        private Controls.ModernButton btnConfirm;
        private Controls.ModernButton btnCancel;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormControl toolbarFormControl1;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormManager toolbarFormManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private Controls.ModernTextBox inputId;
        private Controls.ModernTextBox inputCreatedAt;
        private DevExpress.XtraEditors.CheckEdit chPayable;
        private DevExpress.XtraEditors.CheckEdit chReciveable;
        private DevExpress.XtraEditors.CheckEdit chSettled;
    }
}