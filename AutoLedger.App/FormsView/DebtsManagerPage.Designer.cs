namespace AutoLedger.App.FormsView
{
    partial class DebtsManagerPage
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
            this.panelFactor = new System.Windows.Forms.Panel();
            this.dgDebts = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DebtTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelToolbar = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cbCount = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.labelDetails = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.labelTotalExpenses = new System.Windows.Forms.ToolStripLabel();
            this.chkIsSettled = new DevExpress.XtraEditors.CheckEdit();
            this.chkType = new DevExpress.XtraEditors.CheckEdit();
            this.btnNextPage = new System.Windows.Forms.ToolStripButton();
            this.btnBackPage = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new AutoLedger.App.Controls.ModernButton();
            this.inputSearch = new AutoLedger.App.Controls.ModernTextBox();
            this.btnDelete = new AutoLedger.App.Controls.ModernButton();
            this.btnEdit = new AutoLedger.App.Controls.ModernButton();
            this.btnNew = new AutoLedger.App.Controls.ModernButton();
            this.panelFactor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDebts)).BeginInit();
            this.panelToolbar.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsSettled.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFactor
            // 
            this.panelFactor.Controls.Add(this.dgDebts);
            this.panelFactor.Controls.Add(this.panelToolbar);
            this.panelFactor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFactor.Location = new System.Drawing.Point(0, 0);
            this.panelFactor.Margin = new System.Windows.Forms.Padding(0);
            this.panelFactor.Name = "panelFactor";
            this.panelFactor.Size = new System.Drawing.Size(1062, 624);
            this.panelFactor.TabIndex = 22;
            // 
            // dgDebts
            // 
            this.dgDebts.AllowUserToAddRows = false;
            this.dgDebts.AllowUserToDeleteRows = false;
            this.dgDebts.AllowUserToResizeRows = false;
            this.dgDebts.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgDebts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgDebts.ColumnHeadersHeight = 35;
            this.dgDebts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.Id,
            this.DebtTo,
            this.Title,
            this.Amount,
            this.Type,
            this.Description,
            this.CreatedAt});
            this.dgDebts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDebts.GridColor = System.Drawing.Color.DimGray;
            this.dgDebts.Location = new System.Drawing.Point(0, 45);
            this.dgDebts.Margin = new System.Windows.Forms.Padding(0);
            this.dgDebts.MultiSelect = false;
            this.dgDebts.Name = "dgDebts";
            this.dgDebts.ReadOnly = true;
            this.dgDebts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgDebts.RowHeadersVisible = false;
            this.dgDebts.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgDebts.RowTemplate.DefaultCellStyle.NullValue = "[تعریف نشده]";
            this.dgDebts.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dgDebts.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Snow;
            this.dgDebts.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgDebts.RowTemplate.DividerHeight = 1;
            this.dgDebts.RowTemplate.Height = 40;
            this.dgDebts.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDebts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDebts.Size = new System.Drawing.Size(1062, 579);
            this.dgDebts.TabIndex = 10;
            // 
            // Index
            // 
            this.Index.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Index.HeaderText = "R";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Index.Width = 42;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "شناسه";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 66;
            // 
            // DebtTo
            // 
            this.DebtTo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DebtTo.DataPropertyName = "DebtTo";
            this.DebtTo.HeaderText = "طرف حساب";
            this.DebtTo.Name = "DebtTo";
            this.DebtTo.ReadOnly = true;
            this.DebtTo.Width = 91;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "بابت";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 57;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Amount.DataPropertyName = "Amount";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.Format = "#,0 تومان";
            this.Amount.DefaultCellStyle = dataGridViewCellStyle1;
            this.Amount.HeaderText = "مبلغ";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 56;
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "نوع";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 50;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "توضیحات";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // CreatedAt
            // 
            this.CreatedAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CreatedAt.DataPropertyName = "CreatedAt";
            dataGridViewCellStyle2.Format = "f";
            dataGridViewCellStyle2.NullValue = null;
            this.CreatedAt.DefaultCellStyle = dataGridViewCellStyle2;
            this.CreatedAt.HeaderText = "تاریخ پرداخت";
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.ReadOnly = true;
            this.CreatedAt.Width = 97;
            // 
            // panelToolbar
            // 
            this.panelToolbar.Controls.Add(this.chkIsSettled);
            this.panelToolbar.Controls.Add(this.chkType);
            this.panelToolbar.Controls.Add(this.btnRefresh);
            this.panelToolbar.Controls.Add(this.inputSearch);
            this.panelToolbar.Controls.Add(this.btnDelete);
            this.panelToolbar.Controls.Add(this.btnEdit);
            this.panelToolbar.Controls.Add(this.btnNew);
            this.panelToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolbar.Location = new System.Drawing.Point(0, 0);
            this.panelToolbar.Margin = new System.Windows.Forms.Padding(0);
            this.panelToolbar.Name = "panelToolbar";
            this.panelToolbar.Padding = new System.Windows.Forms.Padding(5);
            this.panelToolbar.Size = new System.Drawing.Size(1062, 45);
            this.panelToolbar.TabIndex = 18;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(80, 80);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbCount,
            this.btnNextPage,
            this.btnBackPage,
            this.toolStripSeparator1,
            this.labelDetails,
            this.toolStripSeparator4,
            this.labelTotalExpenses});
            this.toolStrip1.Location = new System.Drawing.Point(0, 624);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(1062, 43);
            this.toolStrip1.TabIndex = 23;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cbCount
            // 
            this.cbCount.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cbCount.DropDownHeight = 250;
            this.cbCount.DropDownWidth = 80;
            this.cbCount.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cbCount.Font = new System.Drawing.Font("Vazirmatn SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCount.IntegralHeight = false;
            this.cbCount.Items.AddRange(new object[] {
            "50",
            "100",
            "200",
            "300",
            "400",
            "500",
            "600"});
            this.cbCount.MaxDropDownItems = 10;
            this.cbCount.Name = "cbCount";
            this.cbCount.Size = new System.Drawing.Size(121, 33);
            this.cbCount.Text = "تعداد ردیف";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // labelDetails
            // 
            this.labelDetails.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(20, 30);
            this.labelDetails.Text = "..";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 33);
            // 
            // labelTotalExpenses
            // 
            this.labelTotalExpenses.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.labelTotalExpenses.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelTotalExpenses.Name = "labelTotalExpenses";
            this.labelTotalExpenses.Size = new System.Drawing.Size(60, 30);
            this.labelTotalExpenses.Text = "[جمع کل]";
            // 
            // chkIsSettled
            // 
            this.chkIsSettled.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkIsSettled.EditValue = true;
            this.chkIsSettled.Location = new System.Drawing.Point(70, 5);
            this.chkIsSettled.Name = "chkIsSettled";
            this.chkIsSettled.Properties.Appearance.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsSettled.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkIsSettled.Properties.Appearance.Options.UseFont = true;
            this.chkIsSettled.Properties.Appearance.Options.UseForeColor = true;
            this.chkIsSettled.Properties.Caption = "فقط تسویه نشده ها";
            this.chkIsSettled.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkIsSettled.Size = new System.Drawing.Size(135, 35);
            this.chkIsSettled.TabIndex = 6;
            // 
            // chkType
            // 
            this.chkType.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkType.Location = new System.Drawing.Point(205, 5);
            this.chkType.Name = "chkType";
            this.chkType.Properties.Appearance.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkType.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkType.Properties.Appearance.Options.UseFont = true;
            this.chkType.Properties.Appearance.Options.UseForeColor = true;
            this.chkType.Properties.Caption = "فقط بدهی ها";
            this.chkType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkType.Size = new System.Drawing.Size(114, 35);
            this.chkType.TabIndex = 5;
            // 
            // btnNextPage
            // 
            this.btnNextPage.AutoSize = false;
            this.btnNextPage.Image = global::AutoLedger.App.Properties.Resources.next;
            this.btnNextPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNextPage.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnNextPage.Size = new System.Drawing.Size(88, 30);
            this.btnNextPage.Text = "صفحه بعد";
            // 
            // btnBackPage
            // 
            this.btnBackPage.AutoSize = false;
            this.btnBackPage.Image = global::AutoLedger.App.Properties.Resources.back;
            this.btnBackPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBackPage.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.btnBackPage.Name = "btnBackPage";
            this.btnBackPage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBackPage.Size = new System.Drawing.Size(90, 30);
            this.btnBackPage.Text = "صفحه قبل";
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
            this.btnRefresh.Location = new System.Drawing.Point(319, 5);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnRefresh.Size = new System.Drawing.Size(110, 35);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "رفرش";
            this.btnRefresh.UseVisualStyleBackColor = false;
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
            this.inputSearch.Location = new System.Drawing.Point(429, 5);
            this.inputSearch.Margin = new System.Windows.Forms.Padding(0);
            this.inputSearch.Name = "inputSearch";
            this.inputSearch.Placeholder = "جستوجو";
            this.inputSearch.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.inputSearch.Size = new System.Drawing.Size(298, 35);
            this.inputSearch.TabIndex = 0;
            this.inputSearch.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.btnDelete.BaseBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.BorderColor = System.Drawing.Color.Transparent;
            this.btnDelete.CornerRadius = 3;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnDelete.Icon = global::AutoLedger.App.Properties.Resources.erase_128;
            this.btnDelete.IconSize = 23;
            this.btnDelete.IconSpacing = 0;
            this.btnDelete.Location = new System.Drawing.Point(727, 5);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnDelete.Size = new System.Drawing.Size(97, 35);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.btnEdit.BaseBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.BorderColor = System.Drawing.Color.Transparent;
            this.btnEdit.CornerRadius = 3;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnEdit.Icon = global::AutoLedger.App.Properties.Resources.verified_badge_128;
            this.btnEdit.IconSize = 23;
            this.btnEdit.IconSpacing = 0;
            this.btnEdit.Location = new System.Drawing.Point(824, 5);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnEdit.Size = new System.Drawing.Size(97, 35);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.btnNew.BaseBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNew.BorderColor = System.Drawing.Color.Transparent;
            this.btnNew.CornerRadius = 3;
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.Black;
            this.btnNew.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnNew.Icon = global::AutoLedger.App.Properties.Resources.coin;
            this.btnNew.IconSize = 20;
            this.btnNew.IconSpacing = 0;
            this.btnNew.Location = new System.Drawing.Point(921, 5);
            this.btnNew.Margin = new System.Windows.Forms.Padding(0);
            this.btnNew.Name = "btnNew";
            this.btnNew.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnNew.Size = new System.Drawing.Size(136, 35);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "ردیف جدید";
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // DebtsManagerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panelFactor);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DebtsManagerPage";
            this.Size = new System.Drawing.Size(1062, 667);
            this.panelFactor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDebts)).EndInit();
            this.panelToolbar.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsSettled.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkType.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFactor;
        private System.Windows.Forms.DataGridView dgDebts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DebtTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
        private System.Windows.Forms.Panel panelToolbar;
        private Controls.ModernTextBox inputSearch;
        private Controls.ModernButton btnRefresh;
        private Controls.ModernButton btnEdit;
        private Controls.ModernButton btnNew;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox cbCount;
        private System.Windows.Forms.ToolStripButton btnNextPage;
        private System.Windows.Forms.ToolStripButton btnBackPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel labelDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel labelTotalExpenses;
        private Controls.ModernButton btnDelete;
        private DevExpress.XtraEditors.CheckEdit chkIsSettled;
        private DevExpress.XtraEditors.CheckEdit chkType;
    }
}
