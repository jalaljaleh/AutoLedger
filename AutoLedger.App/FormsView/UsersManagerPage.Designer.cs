namespace AutoLedger.App.FormsView
{
    partial class UsersManagerPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelRight = new System.Windows.Forms.Panel();
            this.dgUsers = new System.Windows.Forms.DataGridView();
            this.panelToolbar = new System.Windows.Forms.Panel();
            this.inputSearch = new AutoLedger.App.Controls.ModernTextBox();
            this.btnRefresh = new AutoLedger.App.Controls.ModernButton();
            this.btnEditUser = new AutoLedger.App.Controls.ModernButton();
            this.btnNewUser = new AutoLedger.App.Controls.ModernButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnUsersNextPage = new System.Windows.Forms.ToolStripButton();
            this.btnUsersBackPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.cbReceptinoCount = new System.Windows.Forms.ToolStripComboBox();
            this.labelReceptionsDetails = new System.Windows.Forms.ToolStripLabel();
            this.btnDeleteUser = new AutoLedger.App.Controls.ModernButton();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).BeginInit();
            this.panelToolbar.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.dgUsers);
            this.panelRight.Controls.Add(this.panelToolbar);
            this.panelRight.Controls.Add(this.toolStrip2);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(10, 10);
            this.panelRight.Margin = new System.Windows.Forms.Padding(0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panelRight.Size = new System.Drawing.Size(886, 710);
            this.panelRight.TabIndex = 23;
            // 
            // dgUsers
            // 
            this.dgUsers.AllowUserToAddRows = false;
            this.dgUsers.AllowUserToDeleteRows = false;
            this.dgUsers.AllowUserToResizeRows = false;
            this.dgUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgUsers.BackgroundColor = System.Drawing.Color.Snow;
            this.dgUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgUsers.ColumnHeadersHeight = 25;
            this.dgUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.Id,
            this.FullName,
            this.PhoneNumber,
            this.Description,
            this.Address,
            this.NationalId,
            this.CreatedAt});
            this.dgUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgUsers.GridColor = System.Drawing.SystemColors.Control;
            this.dgUsers.Location = new System.Drawing.Point(5, 38);
            this.dgUsers.Margin = new System.Windows.Forms.Padding(0);
            this.dgUsers.MultiSelect = false;
            this.dgUsers.Name = "dgUsers";
            this.dgUsers.ReadOnly = true;
            this.dgUsers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgUsers.RowHeadersVisible = false;
            this.dgUsers.RowHeadersWidth = 40;
            this.dgUsers.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgUsers.RowTemplate.DefaultCellStyle.NullValue = "[تعریف نشده]";
            this.dgUsers.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.dgUsers.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgUsers.RowTemplate.Height = 40;
            this.dgUsers.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUsers.Size = new System.Drawing.Size(881, 631);
            this.dgUsers.TabIndex = 15;
            // 
            // panelToolbar
            // 
            this.panelToolbar.Controls.Add(this.btnRefresh);
            this.panelToolbar.Controls.Add(this.inputSearch);
            this.panelToolbar.Controls.Add(this.btnDeleteUser);
            this.panelToolbar.Controls.Add(this.btnEditUser);
            this.panelToolbar.Controls.Add(this.btnNewUser);
            this.panelToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolbar.Location = new System.Drawing.Point(5, 0);
            this.panelToolbar.Margin = new System.Windows.Forms.Padding(0);
            this.panelToolbar.Name = "panelToolbar";
            this.panelToolbar.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.panelToolbar.Size = new System.Drawing.Size(881, 38);
            this.panelToolbar.TabIndex = 16;
            // 
            // inputSearch
            // 
            this.inputSearch.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.inputSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inputSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.inputSearch.CornerRadius = 2;
            this.inputSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.inputSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.inputSearch.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.inputSearch.Icon = global::AutoLedger.App.Properties.Resources.zoom_to_fit_128;
            this.inputSearch.Location = new System.Drawing.Point(278, 0);
            this.inputSearch.Margin = new System.Windows.Forms.Padding(0);
            this.inputSearch.Name = "inputSearch";
            this.inputSearch.Placeholder = "جستوجو";
            this.inputSearch.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.inputSearch.Size = new System.Drawing.Size(298, 36);
            this.inputSearch.TabIndex = 0;
            this.inputSearch.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.btnRefresh.BaseBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefresh.BorderColor = System.Drawing.Color.Transparent;
            this.btnRefresh.CornerRadius = 3;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnRefresh.Icon = global::AutoLedger.App.Properties.Resources.sync_128;
            this.btnRefresh.IconSize = 23;
            this.btnRefresh.IconSpacing = 0;
            this.btnRefresh.Location = new System.Drawing.Point(168, 0);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnRefresh.Size = new System.Drawing.Size(110, 36);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "رفرش";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnEditUser
            // 
            this.btnEditUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.btnEditUser.BaseBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditUser.BorderColor = System.Drawing.Color.Transparent;
            this.btnEditUser.CornerRadius = 3;
            this.btnEditUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEditUser.FlatAppearance.BorderSize = 0;
            this.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUser.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUser.ForeColor = System.Drawing.Color.Black;
            this.btnEditUser.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnEditUser.Icon = global::AutoLedger.App.Properties.Resources.verified_badge_128;
            this.btnEditUser.IconSize = 23;
            this.btnEditUser.IconSpacing = 0;
            this.btnEditUser.Location = new System.Drawing.Point(673, 0);
            this.btnEditUser.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnEditUser.Size = new System.Drawing.Size(97, 36);
            this.btnEditUser.TabIndex = 3;
            this.btnEditUser.Text = "ویرایش";
            this.btnEditUser.UseVisualStyleBackColor = false;
            // 
            // btnNewUser
            // 
            this.btnNewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.btnNewUser.BaseBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewUser.BorderColor = System.Drawing.Color.Transparent;
            this.btnNewUser.CornerRadius = 3;
            this.btnNewUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNewUser.FlatAppearance.BorderSize = 0;
            this.btnNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewUser.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewUser.ForeColor = System.Drawing.Color.Black;
            this.btnNewUser.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnNewUser.Icon = global::AutoLedger.App.Properties.Resources.checked_user;
            this.btnNewUser.IconSize = 23;
            this.btnNewUser.IconSpacing = 0;
            this.btnNewUser.Location = new System.Drawing.Point(770, 0);
            this.btnNewUser.Margin = new System.Windows.Forms.Padding(0);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnNewUser.Size = new System.Drawing.Size(111, 36);
            this.btnNewUser.TabIndex = 2;
            this.btnNewUser.Text = "کاربر جدید";
            this.btnNewUser.UseVisualStyleBackColor = false;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(80, 80);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator4,
            this.btnUsersNextPage,
            this.btnUsersBackPage,
            this.toolStripSeparator5,
            this.cbReceptinoCount,
            this.labelReceptionsDetails});
            this.toolStrip2.Location = new System.Drawing.Point(5, 669);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toolStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip2.Size = new System.Drawing.Size(881, 41);
            this.toolStrip2.TabIndex = 18;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // btnUsersNextPage
            // 
            this.btnUsersNextPage.AutoSize = false;
            this.btnUsersNextPage.Image = global::AutoLedger.App.Properties.Resources.forward_button_128;
            this.btnUsersNextPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUsersNextPage.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.btnUsersNextPage.Name = "btnUsersNextPage";
            this.btnUsersNextPage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnUsersNextPage.Size = new System.Drawing.Size(90, 30);
            this.btnUsersNextPage.Text = "صفحه بعد";
            // 
            // btnUsersBackPage
            // 
            this.btnUsersBackPage.AutoSize = false;
            this.btnUsersBackPage.Image = global::AutoLedger.App.Properties.Resources.back_arrow_128;
            this.btnUsersBackPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUsersBackPage.Margin = new System.Windows.Forms.Padding(0, 1, 5, 0);
            this.btnUsersBackPage.Name = "btnUsersBackPage";
            this.btnUsersBackPage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUsersBackPage.Size = new System.Drawing.Size(90, 30);
            this.btnUsersBackPage.Text = "صفحه قبل";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // cbReceptinoCount
            // 
            this.cbReceptinoCount.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cbReceptinoCount.DropDownHeight = 250;
            this.cbReceptinoCount.DropDownWidth = 80;
            this.cbReceptinoCount.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cbReceptinoCount.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReceptinoCount.IntegralHeight = false;
            this.cbReceptinoCount.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.cbReceptinoCount.MaxDropDownItems = 10;
            this.cbReceptinoCount.Name = "cbReceptinoCount";
            this.cbReceptinoCount.Size = new System.Drawing.Size(121, 31);
            this.cbReceptinoCount.Text = "تعداد ردیف";
            // 
            // labelReceptionsDetails
            // 
            this.labelReceptionsDetails.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelReceptionsDetails.Name = "labelReceptionsDetails";
            this.labelReceptionsDetails.Size = new System.Drawing.Size(20, 28);
            this.labelReceptionsDetails.Text = "..";
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.btnDeleteUser.BaseBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteUser.BorderColor = System.Drawing.Color.Transparent;
            this.btnDeleteUser.CornerRadius = 3;
            this.btnDeleteUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDeleteUser.FlatAppearance.BorderSize = 0;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteUser.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnDeleteUser.Icon = global::AutoLedger.App.Properties.Resources.erase_128;
            this.btnDeleteUser.IconSize = 23;
            this.btnDeleteUser.IconSpacing = 0;
            this.btnDeleteUser.Location = new System.Drawing.Point(576, 0);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnDeleteUser.Size = new System.Drawing.Size(97, 36);
            this.btnDeleteUser.TabIndex = 4;
            this.btnDeleteUser.Text = "حذف";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            // 
            // Index
            // 
            this.Index.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Index.DefaultCellStyle = dataGridViewCellStyle1;
            this.Index.HeaderText = "R";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.Width = 42;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "شناسه";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "نام و نام خانوادگی";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "شماره تماس";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "توضیحات";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "آدرس";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // NationalId
            // 
            this.NationalId.DataPropertyName = "NationalId";
            this.NationalId.HeaderText = "کد ملی";
            this.NationalId.Name = "NationalId";
            this.NationalId.ReadOnly = true;
            // 
            // CreatedAt
            // 
            this.CreatedAt.DataPropertyName = "CreatedAt";
            this.CreatedAt.HeaderText = "تاریخ ثبت نام";
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.ReadOnly = true;
            // 
            // UsersManagerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panelRight);
            this.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UsersManagerPage";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(906, 730);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).EndInit();
            this.panelToolbar.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.DataGridView dgUsers;
        private System.Windows.Forms.Panel panelToolbar;
        private Controls.ModernTextBox inputSearch;
        private Controls.ModernButton btnRefresh;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnUsersNextPage;
        private System.Windows.Forms.ToolStripButton btnUsersBackPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private Controls.ModernButton btnEditUser;
        private Controls.ModernButton btnNewUser;
        private System.Windows.Forms.ToolStripComboBox cbReceptinoCount;
        private System.Windows.Forms.ToolStripLabel labelReceptionsDetails;
        private Controls.ModernButton btnDeleteUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
    }
}
