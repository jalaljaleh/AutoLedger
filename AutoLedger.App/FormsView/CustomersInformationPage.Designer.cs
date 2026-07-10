namespace AutoLedger.App.FormsView
{
    partial class CustomersInformationPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelRight = new System.Windows.Forms.Panel();
            this.dgCars = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerNationalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelToolbar = new System.Windows.Forms.Panel();
            this.inputSearch = new AutoLedger.App.Controls.ModernTextBox();
            this.btnRefreshCars = new AutoLedger.App.Controls.ModernButton();
            this.btnEditCar = new AutoLedger.App.Controls.ModernButton();
            this.btnNewCar = new AutoLedger.App.Controls.ModernButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCarsNextPage = new System.Windows.Forms.ToolStripButton();
            this.btnCarsBackPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.cbReceptinoCount = new System.Windows.Forms.ToolStripComboBox();
            this.labelReceptionsDetails = new System.Windows.Forms.ToolStripLabel();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCars)).BeginInit();
            this.panelToolbar.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.dgCars);
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
            // dgCars
            // 
            this.dgCars.AllowUserToAddRows = false;
            this.dgCars.AllowUserToDeleteRows = false;
            this.dgCars.AllowUserToResizeRows = false;
            this.dgCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCars.BackgroundColor = System.Drawing.Color.Snow;
            this.dgCars.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgCars.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgCars.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgCars.ColumnHeadersHeight = 25;
            this.dgCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.Id,
            this.OwnerFullName,
            this.OwnerPhoneNumber,
            this.OwnerNationalId,
            this.Brand,
            this.PlateId,
            this.Color,
            this.Tip,
            this.CreatedAt});
            this.dgCars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCars.GridColor = System.Drawing.SystemColors.Control;
            this.dgCars.Location = new System.Drawing.Point(5, 38);
            this.dgCars.Margin = new System.Windows.Forms.Padding(0);
            this.dgCars.MultiSelect = false;
            this.dgCars.Name = "dgCars";
            this.dgCars.ReadOnly = true;
            this.dgCars.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgCars.RowHeadersVisible = false;
            this.dgCars.RowHeadersWidth = 40;
            this.dgCars.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgCars.RowTemplate.DefaultCellStyle.NullValue = "[تعریف نشده]";
            this.dgCars.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.dgCars.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgCars.RowTemplate.Height = 40;
            this.dgCars.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCars.Size = new System.Drawing.Size(881, 631);
            this.dgCars.TabIndex = 15;
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
            // OwnerFullName
            // 
            this.OwnerFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OwnerFullName.DataPropertyName = "OwnerFullName";
            this.OwnerFullName.HeaderText = "نام و نام خانوادگی";
            this.OwnerFullName.Name = "OwnerFullName";
            this.OwnerFullName.ReadOnly = true;
            // 
            // OwnerPhoneNumber
            // 
            this.OwnerPhoneNumber.DataPropertyName = "OwnerPhoneNumber";
            this.OwnerPhoneNumber.HeaderText = "شماره تماس";
            this.OwnerPhoneNumber.Name = "OwnerPhoneNumber";
            this.OwnerPhoneNumber.ReadOnly = true;
            // 
            // OwnerNationalId
            // 
            this.OwnerNationalId.DataPropertyName = "OwnerNationalId";
            this.OwnerNationalId.HeaderText = "کد ملی";
            this.OwnerNationalId.Name = "OwnerNationalId";
            this.OwnerNationalId.ReadOnly = true;
            // 
            // Brand
            // 
            this.Brand.DataPropertyName = "Brand";
            this.Brand.HeaderText = "خودرو";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            // 
            // PlateId
            // 
            this.PlateId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PlateId.DataPropertyName = "PlateId";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlateId.DefaultCellStyle = dataGridViewCellStyle2;
            this.PlateId.HeaderText = "پلاک";
            this.PlateId.Name = "PlateId";
            this.PlateId.ReadOnly = true;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "رنگ خودرو";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            // 
            // Tip
            // 
            this.Tip.DataPropertyName = "Tip";
            this.Tip.HeaderText = "تیپ خودرو";
            this.Tip.Name = "Tip";
            this.Tip.ReadOnly = true;
            // 
            // CreatedAt
            // 
            this.CreatedAt.DataPropertyName = "CreatedAt";
            this.CreatedAt.HeaderText = "تاریخ ثبت نام";
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.ReadOnly = true;
            // 
            // panelToolbar
            // 
            this.panelToolbar.Controls.Add(this.inputSearch);
            this.panelToolbar.Controls.Add(this.btnRefreshCars);
            this.panelToolbar.Controls.Add(this.btnEditCar);
            this.panelToolbar.Controls.Add(this.btnNewCar);
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
            this.inputSearch.Location = new System.Drawing.Point(265, 0);
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
            this.btnRefreshCars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.btnRefreshCars.BaseBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefreshCars.BorderColor = System.Drawing.Color.Transparent;
            this.btnRefreshCars.CornerRadius = 3;
            this.btnRefreshCars.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRefreshCars.FlatAppearance.BorderSize = 0;
            this.btnRefreshCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshCars.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshCars.ForeColor = System.Drawing.Color.Black;
            this.btnRefreshCars.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnRefreshCars.Icon = global::AutoLedger.App.Properties.Resources.sync_128;
            this.btnRefreshCars.IconSize = 23;
            this.btnRefreshCars.IconSpacing = 0;
            this.btnRefreshCars.Location = new System.Drawing.Point(563, 0);
            this.btnRefreshCars.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefreshCars.Name = "btnRefresh";
            this.btnRefreshCars.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnRefreshCars.Size = new System.Drawing.Size(110, 36);
            this.btnRefreshCars.TabIndex = 1;
            this.btnRefreshCars.Text = "رفرش";
            this.btnRefreshCars.UseVisualStyleBackColor = false;
            // 
            // btnEditUser
            // 
            this.btnEditCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.btnEditCar.BaseBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditCar.BorderColor = System.Drawing.Color.Transparent;
            this.btnEditCar.CornerRadius = 3;
            this.btnEditCar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEditCar.FlatAppearance.BorderSize = 0;
            this.btnEditCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCar.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCar.ForeColor = System.Drawing.Color.Black;
            this.btnEditCar.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnEditCar.Icon = global::AutoLedger.App.Properties.Resources.verified_badge_128;
            this.btnEditCar.IconSize = 23;
            this.btnEditCar.IconSpacing = 0;
            this.btnEditCar.Location = new System.Drawing.Point(673, 0);
            this.btnEditCar.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditCar.Name = "btnEditUser";
            this.btnEditCar.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnEditCar.Size = new System.Drawing.Size(97, 36);
            this.btnEditCar.TabIndex = 3;
            this.btnEditCar.Text = "ویرایش";
            this.btnEditCar.UseVisualStyleBackColor = false;
            // 
            // btnNewUser
            // 
            this.btnNewCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.btnNewCar.BaseBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewCar.BorderColor = System.Drawing.Color.Transparent;
            this.btnNewCar.CornerRadius = 3;
            this.btnNewCar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNewCar.FlatAppearance.BorderSize = 0;
            this.btnNewCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewCar.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCar.ForeColor = System.Drawing.Color.Black;
            this.btnNewCar.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnNewCar.Icon = global::AutoLedger.App.Properties.Resources.checked_user;
            this.btnNewCar.IconSize = 23;
            this.btnNewCar.IconSpacing = 0;
            this.btnNewCar.Location = new System.Drawing.Point(770, 0);
            this.btnNewCar.Margin = new System.Windows.Forms.Padding(0);
            this.btnNewCar.Name = "btnNewUser";
            this.btnNewCar.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnNewCar.Size = new System.Drawing.Size(111, 36);
            this.btnNewCar.TabIndex = 2;
            this.btnNewCar.Text = "کاربر جدید";
            this.btnNewCar.UseVisualStyleBackColor = false;
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
            this.btnCarsNextPage,
            this.btnCarsBackPage,
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
            // btnCarsNextPage
            // 
            this.btnCarsNextPage.AutoSize = false;
            this.btnCarsNextPage.Image = global::AutoLedger.App.Properties.Resources.forward_button_128;
            this.btnCarsNextPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCarsNextPage.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.btnCarsNextPage.Name = "btnCarsNextPage";
            this.btnCarsNextPage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCarsNextPage.Size = new System.Drawing.Size(90, 30);
            this.btnCarsNextPage.Text = "صفحه بعد";
            // 
            // btnCarsBackPage
            // 
            this.btnCarsBackPage.AutoSize = false;
            this.btnCarsBackPage.Image = global::AutoLedger.App.Properties.Resources.back_arrow_128;
            this.btnCarsBackPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCarsBackPage.Margin = new System.Windows.Forms.Padding(0, 1, 5, 0);
            this.btnCarsBackPage.Name = "btnCarsBackPage";
            this.btnCarsBackPage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCarsBackPage.Size = new System.Drawing.Size(90, 30);
            this.btnCarsBackPage.Text = "صفحه قبل";
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
            // CustomersInformationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panelRight);
            this.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CustomersInformationPage";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(906, 730);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCars)).EndInit();
            this.panelToolbar.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.DataGridView dgCars;
        private System.Windows.Forms.Panel panelToolbar;
        private Controls.ModernTextBox inputSearch;
        private Controls.ModernButton btnRefreshCars;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnCarsNextPage;
        private System.Windows.Forms.ToolStripButton btnCarsBackPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private Controls.ModernButton btnEditCar;
        private Controls.ModernButton btnNewCar;
        private System.Windows.Forms.ToolStripComboBox cbReceptinoCount;
        private System.Windows.Forms.ToolStripLabel labelReceptionsDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerNationalId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlateId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tip;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
    }
}
