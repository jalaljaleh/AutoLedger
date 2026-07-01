namespace AutoLedger.App.Forms
{
    partial class ExpenseForm
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
            this.inputTitle = new AutoLedger.App.Controls.ModernTextBox();
            this.inputDescription = new AutoLedger.App.Controls.ModernTextBox();
            this.inputAmount = new AutoLedger.App.Controls.ModernTextBox();
            this.labelAmountPersian = new System.Windows.Forms.Label();
            this.inputPaidTo = new AutoLedger.App.Controls.ModernTextBox();
            this.InputPaymentMethod = new AutoLedger.App.Controls.ModernTextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new AutoLedger.App.Controls.ModernButton();
            this.btnCancel = new AutoLedger.App.Controls.ModernButton();
            this.SuspendLayout();
            // 
            // inputTitle
            // 
            this.inputTitle.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.inputTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputTitle.BackColor = System.Drawing.Color.White;
            this.inputTitle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.inputTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.inputTitle.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.inputTitle.Icon = global::AutoLedger.App.Properties.Resources.approval_128;
            this.inputTitle.Location = new System.Drawing.Point(45, 35);
            this.inputTitle.Name = "inputTitle";
            this.inputTitle.Placeholder = "عنوان خرید";
            this.inputTitle.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.inputTitle.Size = new System.Drawing.Size(295, 40);
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
            this.inputDescription.Location = new System.Drawing.Point(45, 81);
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
            this.inputAmount.BackColor = System.Drawing.Color.White;
            this.inputAmount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.inputAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.inputAmount.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.inputAmount.Icon = global::AutoLedger.App.Properties.Resources.coin;
            this.inputAmount.Location = new System.Drawing.Point(45, 202);
            this.inputAmount.Name = "inputAmount";
            this.inputAmount.NumbersOnly = true;
            this.inputAmount.Placeholder = "مبلغ";
            this.inputAmount.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.inputAmount.Size = new System.Drawing.Size(295, 40);
            this.inputAmount.TabIndex = 3;
            this.inputAmount.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelAmountPersian
            // 
            this.labelAmountPersian.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAmountPersian.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmountPersian.Location = new System.Drawing.Point(45, 246);
            this.labelAmountPersian.Name = "labelAmountPersian";
            this.labelAmountPersian.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelAmountPersian.Size = new System.Drawing.Size(294, 31);
            this.labelAmountPersian.TabIndex = 3;
            this.labelAmountPersian.Text = "0 تومان";
            // 
            // inputPaidTo
            // 
            this.inputPaidTo.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.inputPaidTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputPaidTo.BackColor = System.Drawing.Color.White;
            this.inputPaidTo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.inputPaidTo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputPaidTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.inputPaidTo.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.inputPaidTo.Icon = global::AutoLedger.App.Properties.Resources.checked_user;
            this.inputPaidTo.Location = new System.Drawing.Point(45, 280);
            this.inputPaidTo.Name = "inputPaidTo";
            this.inputPaidTo.Placeholder = "نام و نام خانوادگی دریافت کننده";
            this.inputPaidTo.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.inputPaidTo.Size = new System.Drawing.Size(295, 40);
            this.inputPaidTo.TabIndex = 4;
            this.inputPaidTo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InputPaymentMethod
            // 
            this.InputPaymentMethod.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.InputPaymentMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InputPaymentMethod.BackColor = System.Drawing.Color.White;
            this.InputPaymentMethod.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.InputPaymentMethod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputPaymentMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.InputPaymentMethod.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.InputPaymentMethod.Icon = global::AutoLedger.App.Properties.Resources.credit_card_128;
            this.InputPaymentMethod.Location = new System.Drawing.Point(45, 326);
            this.InputPaymentMethod.Name = "InputPaymentMethod";
            this.InputPaymentMethod.Placeholder = "شیوه پرداخت";
            this.InputPaymentMethod.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.InputPaymentMethod.Size = new System.Drawing.Size(295, 40);
            this.InputPaymentMethod.TabIndex = 5;
            this.InputPaymentMethod.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbCategory
            // 
            this.cbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(45, 378);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(295, 29);
            this.cbCategory.TabIndex = 6;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.btnConfirm.BaseBackColor = System.Drawing.Color.Green;
            this.btnConfirm.BorderColor = System.Drawing.Color.Transparent;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.HoverBackColor = System.Drawing.Color.Empty;
            this.btnConfirm.Icon = global::AutoLedger.App.Properties.Resources.approval_128;
            this.btnConfirm.IconSize = 22;
            this.btnConfirm.Location = new System.Drawing.Point(204, 455);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnConfirm.Size = new System.Drawing.Size(150, 40);
            this.btnConfirm.TabIndex = 7;
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
            this.btnCancel.Location = new System.Drawing.Point(31, 455);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnCancel.Size = new System.Drawing.Size(90, 40);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "لغو";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // ExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(376, 516);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.InputPaymentMethod);
            this.Controls.Add(this.inputPaidTo);
            this.Controls.Add(this.labelAmountPersian);
            this.Controls.Add(this.inputAmount);
            this.Controls.Add(this.inputDescription);
            this.Controls.Add(this.inputTitle);
            this.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ExpenseForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "فرم مخارج";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ModernTextBox inputTitle;
        private Controls.ModernTextBox inputDescription;
        private Controls.ModernTextBox inputAmount;
        private System.Windows.Forms.Label labelAmountPersian;
        private Controls.ModernTextBox inputPaidTo;
        private Controls.ModernTextBox InputPaymentMethod;
        private System.Windows.Forms.ComboBox cbCategory;
        private Controls.ModernButton btnConfirm;
        private Controls.ModernButton btnCancel;
    }
}