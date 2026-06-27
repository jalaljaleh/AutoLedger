namespace AutoLedger.App.FormsView
{
    partial class CarsManagerPage
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
                if (_searchTimer != null)
                {
                    _searchTimer.Tick -= SearchTimer_Tick;
                    _searchTimer.Stop();
                    _searchTimer.Dispose();
                    _searchTimer = null;
                }

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridSelectedCar = new System.Windows.Forms.DataGridView();
            this._index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerCardId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCars = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextBoxName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFactor = new System.Windows.Forms.Panel();
            this.dgCarReceptions = new System.Windows.Forms.DataGridView();
            this.BtnActionCurrentUser = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.labelReceptionsDetails = new System.Windows.Forms.ToolStripLabel();
            this.cbReceptinoCount = new System.Windows.Forms.ToolStripComboBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelToolbar = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.cbCurrentCars = new System.Windows.Forms.CheckBox();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mileage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsRepaired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsReleased = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsExpensesProvided = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RepairedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleasedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReceptionNew = new System.Windows.Forms.ToolStripButton();
            this.btnReceptionEdit = new System.Windows.Forms.ToolStripButton();
            this.btnReceptionDelete = new System.Windows.Forms.ToolStripButton();
            this.btnCarExpenses = new System.Windows.Forms.ToolStripButton();
            this.btnRefreshCarReceptions = new System.Windows.Forms.ToolStripButton();
            this.btnNextPageReceptions = new System.Windows.Forms.ToolStripButton();
            this.btnBackPageCarReceptions = new System.Windows.Forms.ToolStripButton();
            this.inputSearch = new AutoLedger.App.Controls.ModernTextBox();
            this.btnRefreshCars = new AutoLedger.App.Controls.ModernButton();
            this.btnCarsNextPage = new System.Windows.Forms.ToolStripButton();
            this.btnCarsBackPage = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSelectedCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCars)).BeginInit();
            this.panelFactor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCarReceptions)).BeginInit();
            this.BtnActionCurrentUser.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelToolbar.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridSelectedCar
            // 
            this.dataGridSelectedCar.AllowUserToAddRows = false;
            this.dataGridSelectedCar.AllowUserToDeleteRows = false;
            this.dataGridSelectedCar.AllowUserToResizeColumns = false;
            this.dataGridSelectedCar.AllowUserToResizeRows = false;
            this.dataGridSelectedCar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSelectedCar.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridSelectedCar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridSelectedCar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridSelectedCar.ColumnHeadersHeight = 25;
            this.dataGridSelectedCar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._index,
            this.OwnerPhoneNumber,
            this.OwnerCardId,
            this.Color,
            this.Tip,
            this.Model,
            this.Brand});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.NullValue = "[عبارت پر نشده]";
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridSelectedCar.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridSelectedCar.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridSelectedCar.Enabled = false;
            this.dataGridSelectedCar.EnableHeadersVisualStyles = false;
            this.dataGridSelectedCar.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridSelectedCar.Location = new System.Drawing.Point(5, 6);
            this.dataGridSelectedCar.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridSelectedCar.MultiSelect = false;
            this.dataGridSelectedCar.Name = "dataGridSelectedCar";
            this.dataGridSelectedCar.ReadOnly = true;
            this.dataGridSelectedCar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSelectedCar.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridSelectedCar.RowHeadersVisible = false;
            this.dataGridSelectedCar.RowHeadersWidth = 40;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridSelectedCar.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridSelectedCar.RowTemplate.Height = 40;
            this.dataGridSelectedCar.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridSelectedCar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridSelectedCar.Size = new System.Drawing.Size(820, 54);
            this.dataGridSelectedCar.TabIndex = 17;
            // 
            // _index
            // 
            this._index.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this._index.FillWeight = 2F;
            this._index.Frozen = true;
            this._index.HeaderText = "Column1";
            this._index.MinimumWidth = 2;
            this._index.Name = "_index";
            this._index.ReadOnly = true;
            this._index.Width = 2;
            // 
            // OwnerPhoneNumber
            // 
            this.OwnerPhoneNumber.DataPropertyName = "OwnerPhoneNumber";
            this.OwnerPhoneNumber.HeaderText = "شماره تماس";
            this.OwnerPhoneNumber.Name = "OwnerPhoneNumber";
            this.OwnerPhoneNumber.ReadOnly = true;
            // 
            // OwnerCardId
            // 
            this.OwnerCardId.DataPropertyName = "OwnerCardId";
            this.OwnerCardId.HeaderText = "کد ملی";
            this.OwnerCardId.Name = "OwnerCardId";
            this.OwnerCardId.ReadOnly = true;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "رنگ";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            // 
            // Tip
            // 
            this.Tip.DataPropertyName = "Tip";
            this.Tip.HeaderText = "تیپ";
            this.Tip.Name = "Tip";
            this.Tip.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "مدل";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // Brand
            // 
            this.Brand.DataPropertyName = "Brand";
            this.Brand.HeaderText = "برند";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
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
            this.Id,
            this.OwnerFullName,
            this.TextBoxName});
            this.dgCars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCars.GridColor = System.Drawing.SystemColors.Control;
            this.dgCars.Location = new System.Drawing.Point(5, 76);
            this.dgCars.Margin = new System.Windows.Forms.Padding(0);
            this.dgCars.MultiSelect = false;
            this.dgCars.Name = "dgCars";
            this.dgCars.ReadOnly = true;
            this.dgCars.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgCars.RowHeadersVisible = false;
            this.dgCars.RowHeadersWidth = 40;
            this.dgCars.RowTemplate.DefaultCellStyle.NullValue = "[تعریف نشده]";
            this.dgCars.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.dgCars.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgCars.RowTemplate.Height = 40;
            this.dgCars.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCars.Size = new System.Drawing.Size(245, 635);
            this.dgCars.TabIndex = 15;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Id.DataPropertyName = "Id";
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id.DefaultCellStyle = dataGridViewCellStyle11;
            this.Id.HeaderText = "R";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 42;
            // 
            // OwnerFullName
            // 
            this.OwnerFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OwnerFullName.DataPropertyName = "OwnerFullName";
            this.OwnerFullName.HeaderText = "مالک";
            this.OwnerFullName.Name = "OwnerFullName";
            this.OwnerFullName.ReadOnly = true;
            // 
            // TextBoxName
            // 
            this.TextBoxName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TextBoxName.DataPropertyName = "PlateId";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxName.DefaultCellStyle = dataGridViewCellStyle12;
            this.TextBoxName.HeaderText = "پلاک";
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.ReadOnly = true;
            // 
            // panelFactor
            // 
            this.panelFactor.Controls.Add(this.dgCarReceptions);
            this.panelFactor.Controls.Add(this.BtnActionCurrentUser);
            this.panelFactor.Controls.Add(this.toolStrip1);
            this.panelFactor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFactor.Location = new System.Drawing.Point(5, 60);
            this.panelFactor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelFactor.Name = "panelFactor";
            this.panelFactor.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.panelFactor.Size = new System.Drawing.Size(820, 698);
            this.panelFactor.TabIndex = 21;
            // 
            // dgCarReceptions
            // 
            this.dgCarReceptions.AllowUserToAddRows = false;
            this.dgCarReceptions.AllowUserToDeleteRows = false;
            this.dgCarReceptions.AllowUserToResizeRows = false;
            this.dgCarReceptions.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgCarReceptions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgCarReceptions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgCarReceptions.ColumnHeadersHeight = 35;
            this.dgCarReceptions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.Title,
            this.Mileage,
            this.TotalCost,
            this.IsRepaired,
            this.IsReleased,
            this.IsExpensesProvided,
            this.CreatedAt,
            this.RepairedAt,
            this.ReleasedAt,
            this.UpdatedAt,
            this.extra});
            this.dgCarReceptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCarReceptions.GridColor = System.Drawing.Color.DimGray;
            this.dgCarReceptions.Location = new System.Drawing.Point(0, 44);
            this.dgCarReceptions.Margin = new System.Windows.Forms.Padding(0);
            this.dgCarReceptions.MultiSelect = false;
            this.dgCarReceptions.Name = "dgCarReceptions";
            this.dgCarReceptions.ReadOnly = true;
            this.dgCarReceptions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgCarReceptions.RowHeadersVisible = false;
            this.dgCarReceptions.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgCarReceptions.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Vazirmatn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgCarReceptions.RowTemplate.DefaultCellStyle.NullValue = "[تعریف نشده]";
            this.dgCarReceptions.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dgCarReceptions.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Snow;
            this.dgCarReceptions.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgCarReceptions.RowTemplate.DividerHeight = 1;
            this.dgCarReceptions.RowTemplate.Height = 40;
            this.dgCarReceptions.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCarReceptions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCarReceptions.Size = new System.Drawing.Size(820, 620);
            this.dgCarReceptions.TabIndex = 10;
            // 
            // BtnActionCurrentUser
            // 
            this.BtnActionCurrentUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnActionCurrentUser.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActionCurrentUser.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.BtnActionCurrentUser.ImageScalingSize = new System.Drawing.Size(80, 80);
            this.BtnActionCurrentUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReceptionNew,
            this.btnReceptionEdit,
            this.btnReceptionDelete,
            this.toolStripSeparator2,
            this.btnCarExpenses});
            this.BtnActionCurrentUser.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.BtnActionCurrentUser.Location = new System.Drawing.Point(0, 6);
            this.BtnActionCurrentUser.Name = "BtnActionCurrentUser";
            this.BtnActionCurrentUser.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnActionCurrentUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnActionCurrentUser.Size = new System.Drawing.Size(820, 38);
            this.BtnActionCurrentUser.TabIndex = 16;
            this.BtnActionCurrentUser.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(80, 80);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRefreshCarReceptions,
            this.toolStripSeparator3,
            this.btnNextPageReceptions,
            this.btnBackPageCarReceptions,
            this.toolStripSeparator1,
            this.labelReceptionsDetails,
            this.cbReceptinoCount});
            this.toolStrip1.Location = new System.Drawing.Point(0, 664);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(2);
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(820, 34);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 30);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // labelReceptionsDetails
            // 
            this.labelReceptionsDetails.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelReceptionsDetails.Name = "labelReceptionsDetails";
            this.labelReceptionsDetails.Size = new System.Drawing.Size(20, 27);
            this.labelReceptionsDetails.Text = "..";
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
            this.cbReceptinoCount.Size = new System.Drawing.Size(121, 30);
            this.cbReceptinoCount.Text = "تعداد ردیف";
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.dgCars);
            this.panelRight.Controls.Add(this.panelToolbar);
            this.panelRight.Controls.Add(this.toolStrip2);
            this.panelRight.Controls.Add(this.panelFilter);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(825, 6);
            this.panelRight.Margin = new System.Windows.Forms.Padding(0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panelRight.Size = new System.Drawing.Size(250, 752);
            this.panelRight.TabIndex = 22;
            // 
            // panelToolbar
            // 
            this.panelToolbar.Controls.Add(this.inputSearch);
            this.panelToolbar.Controls.Add(this.btnRefreshCars);
            this.panelToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolbar.Location = new System.Drawing.Point(5, 38);
            this.panelToolbar.Margin = new System.Windows.Forms.Padding(0);
            this.panelToolbar.Name = "panelToolbar";
            this.panelToolbar.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.panelToolbar.Size = new System.Drawing.Size(245, 38);
            this.panelToolbar.TabIndex = 16;
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
            this.toolStripSeparator5});
            this.toolStrip2.Location = new System.Drawing.Point(5, 711);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toolStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip2.Size = new System.Drawing.Size(245, 41);
            this.toolStrip2.TabIndex = 18;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // panelFilter
            // 
            this.panelFilter.Controls.Add(this.cbCurrentCars);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Location = new System.Drawing.Point(5, 0);
            this.panelFilter.Margin = new System.Windows.Forms.Padding(0);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.panelFilter.Size = new System.Drawing.Size(245, 38);
            this.panelFilter.TabIndex = 19;
            // 
            // cbCurrentCars
            // 
            this.cbCurrentCars.AutoSize = true;
            this.cbCurrentCars.BackColor = System.Drawing.Color.Honeydew;
            this.cbCurrentCars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCurrentCars.Location = new System.Drawing.Point(0, 0);
            this.cbCurrentCars.Name = "cbCurrentCars";
            this.cbCurrentCars.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cbCurrentCars.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbCurrentCars.Size = new System.Drawing.Size(245, 36);
            this.cbCurrentCars.TabIndex = 0;
            this.cbCurrentCars.Text = "فقط خودروهای جاری";
            this.cbCurrentCars.UseVisualStyleBackColor = false;
            // 
            // Index
            // 
            this.Index.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Index.DataPropertyName = "Index";
            this.Index.HeaderText = "R";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Index.Width = 42;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Title.DataPropertyName = "Id";
            this.Title.HeaderText = "شناسه";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 66;
            // 
            // Mileage
            // 
            this.Mileage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Mileage.DataPropertyName = "Mileage";
            this.Mileage.HeaderText = "کیلومتر";
            this.Mileage.Name = "Mileage";
            this.Mileage.ReadOnly = true;
            this.Mileage.Width = 68;
            // 
            // TotalCost
            // 
            this.TotalCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TotalCost.DataPropertyName = "TotalCost";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.Format = "#,0 تومان";
            dataGridViewCellStyle13.NullValue = "0";
            this.TotalCost.DefaultCellStyle = dataGridViewCellStyle13;
            this.TotalCost.FillWeight = 200F;
            this.TotalCost.HeaderText = "مبلغ فاکتور";
            this.TotalCost.MinimumWidth = 150;
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.ReadOnly = true;
            this.TotalCost.Width = 150;
            // 
            // IsRepaired
            // 
            this.IsRepaired.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IsRepaired.DataPropertyName = "IsRepaired";
            this.IsRepaired.HeaderText = "تعمیر شده";
            this.IsRepaired.Name = "IsRepaired";
            this.IsRepaired.ReadOnly = true;
            this.IsRepaired.Width = 87;
            // 
            // IsReleased
            // 
            this.IsReleased.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IsReleased.DataPropertyName = "IsReleased";
            this.IsReleased.HeaderText = "ترخیص شده";
            this.IsReleased.Name = "IsReleased";
            this.IsReleased.ReadOnly = true;
            this.IsReleased.Width = 94;
            // 
            // IsExpensesProvided
            // 
            this.IsExpensesProvided.DataPropertyName = "IsExpensesProvided";
            this.IsExpensesProvided.HeaderText = "هزینه ها";
            this.IsExpensesProvided.Name = "IsExpensesProvided";
            this.IsExpensesProvided.ReadOnly = true;
            // 
            // CreatedAt
            // 
            this.CreatedAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CreatedAt.DataPropertyName = "CreatedAt";
            dataGridViewCellStyle14.Format = "D";
            dataGridViewCellStyle14.NullValue = null;
            this.CreatedAt.DefaultCellStyle = dataGridViewCellStyle14;
            this.CreatedAt.HeaderText = "تاریخ پذیرش";
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.ReadOnly = true;
            this.CreatedAt.Width = 93;
            // 
            // RepairedAt
            // 
            this.RepairedAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RepairedAt.DataPropertyName = "RepairedAt";
            this.RepairedAt.HeaderText = "تاریخ تعمیر";
            this.RepairedAt.Name = "RepairedAt";
            this.RepairedAt.ReadOnly = true;
            this.RepairedAt.Width = 89;
            // 
            // ReleasedAt
            // 
            this.ReleasedAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ReleasedAt.DataPropertyName = "ReleasedAt";
            this.ReleasedAt.HeaderText = "تاریخ ترخیص";
            this.ReleasedAt.Name = "ReleasedAt";
            this.ReleasedAt.ReadOnly = true;
            this.ReleasedAt.Width = 96;
            // 
            // UpdatedAt
            // 
            this.UpdatedAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UpdatedAt.DataPropertyName = "UpdatedAt";
            this.UpdatedAt.HeaderText = "تاریخ ویرایش";
            this.UpdatedAt.Name = "UpdatedAt";
            this.UpdatedAt.ReadOnly = true;
            this.UpdatedAt.Width = 96;
            // 
            // extra
            // 
            this.extra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.extra.HeaderText = "";
            this.extra.Name = "extra";
            this.extra.ReadOnly = true;
            this.extra.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnReceptionNew
            // 
            this.btnReceptionNew.AutoSize = false;
            this.btnReceptionNew.Image = global::AutoLedger.App.Properties.Resources.hitfilm_pro_128;
            this.btnReceptionNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReceptionNew.Name = "btnReceptionNew";
            this.btnReceptionNew.Size = new System.Drawing.Size(95, 25);
            this.btnReceptionNew.Text = "پذیرش جدید";
            this.btnReceptionNew.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReceptionNew.ToolTipText = "پذیرش جدید";
            // 
            // btnReceptionEdit
            // 
            this.btnReceptionEdit.AutoSize = false;
            this.btnReceptionEdit.Image = global::AutoLedger.App.Properties.Resources.four_squares_128;
            this.btnReceptionEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReceptionEdit.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.btnReceptionEdit.Name = "btnReceptionEdit";
            this.btnReceptionEdit.Size = new System.Drawing.Size(68, 25);
            this.btnReceptionEdit.Text = "ویرایش";
            this.btnReceptionEdit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnReceptionDelete
            // 
            this.btnReceptionDelete.AutoSize = false;
            this.btnReceptionDelete.Image = global::AutoLedger.App.Properties.Resources.erase_128;
            this.btnReceptionDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReceptionDelete.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.btnReceptionDelete.Name = "btnReceptionDelete";
            this.btnReceptionDelete.Size = new System.Drawing.Size(60, 25);
            this.btnReceptionDelete.Text = "حذف";
            this.btnReceptionDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReceptionDelete.ToolTipText = "حذف";
            // 
            // btnCarExpenses
            // 
            this.btnCarExpenses.AutoSize = false;
            this.btnCarExpenses.Image = global::AutoLedger.App.Properties.Resources.credit_card_128;
            this.btnCarExpenses.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCarExpenses.Name = "btnCarExpenses";
            this.btnCarExpenses.Size = new System.Drawing.Size(90, 25);
            this.btnCarExpenses.Text = "درج هزینه";
            this.btnCarExpenses.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCarExpenses.ToolTipText = "درج و ویرایش هزینه ها";
            // 
            // btnRefreshCarReceptions
            // 
            this.btnRefreshCarReceptions.AutoSize = false;
            this.btnRefreshCarReceptions.Image = global::AutoLedger.App.Properties.Resources.sync_128;
            this.btnRefreshCarReceptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefreshCarReceptions.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefreshCarReceptions.Name = "btnRefreshCarReceptions";
            this.btnRefreshCarReceptions.Size = new System.Drawing.Size(90, 30);
            this.btnRefreshCarReceptions.Text = "بروزرسانی";
            // 
            // btnNextPageReceptions
            // 
            this.btnNextPageReceptions.AutoSize = false;
            this.btnNextPageReceptions.Image = global::AutoLedger.App.Properties.Resources.next;
            this.btnNextPageReceptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNextPageReceptions.Margin = new System.Windows.Forms.Padding(0);
            this.btnNextPageReceptions.Name = "btnNextPageReceptions";
            this.btnNextPageReceptions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnNextPageReceptions.Size = new System.Drawing.Size(92, 30);
            this.btnNextPageReceptions.Text = "صفحه بعد";
            // 
            // btnBackPageCarReceptions
            // 
            this.btnBackPageCarReceptions.AutoSize = false;
            this.btnBackPageCarReceptions.Image = global::AutoLedger.App.Properties.Resources.back;
            this.btnBackPageCarReceptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBackPageCarReceptions.Margin = new System.Windows.Forms.Padding(0);
            this.btnBackPageCarReceptions.Name = "btnBackPageCarReceptions";
            this.btnBackPageCarReceptions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBackPageCarReceptions.Size = new System.Drawing.Size(94, 30);
            this.btnBackPageCarReceptions.Text = "صفحه قبل";
            // 
            // inputSearch
            // 
            this.inputSearch.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.inputSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inputSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.inputSearch.CornerRadius = 2;
            this.inputSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.inputSearch.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.inputSearch.Icon = global::AutoLedger.App.Properties.Resources.zoom_to_fit_128;
            this.inputSearch.Location = new System.Drawing.Point(0, 0);
            this.inputSearch.Margin = new System.Windows.Forms.Padding(0);
            this.inputSearch.Name = "inputSearch";
            this.inputSearch.Placeholder = "جستوجو";
            this.inputSearch.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.inputSearch.Size = new System.Drawing.Size(164, 36);
            this.inputSearch.TabIndex = 0;
            this.inputSearch.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRefreshCars
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
            this.btnRefreshCars.Location = new System.Drawing.Point(164, 0);
            this.btnRefreshCars.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefreshCars.Name = "btnRefreshCars";
            this.btnRefreshCars.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnRefreshCars.Size = new System.Drawing.Size(81, 36);
            this.btnRefreshCars.TabIndex = 1;
            this.btnRefreshCars.Text = "رفرش";
            this.btnRefreshCars.UseVisualStyleBackColor = false;
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
            // CarsManagerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Controls.Add(this.panelFactor);
            this.Controls.Add(this.dataGridSelectedCar);
            this.Controls.Add(this.panelRight);
            this.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CarsManagerPage";
            this.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Size = new System.Drawing.Size(1080, 764);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSelectedCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCars)).EndInit();
            this.panelFactor.ResumeLayout(false);
            this.panelFactor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCarReceptions)).EndInit();
            this.BtnActionCurrentUser.ResumeLayout(false);
            this.BtnActionCurrentUser.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.panelToolbar.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridSelectedCar;
        private System.Windows.Forms.DataGridView dgCars;
        private System.Windows.Forms.Panel panelFactor;
        private System.Windows.Forms.ToolStrip BtnActionCurrentUser;
        private System.Windows.Forms.DataGridView dgCarReceptions;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.ToolStripButton btnReceptionDelete;
        private System.Windows.Forms.ToolStripButton btnReceptionEdit;
        private System.Windows.Forms.ToolStripButton btnReceptionNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn _index;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerCardId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.Panel panelToolbar;
        private Controls.ModernTextBox inputSearch;
        private System.Windows.Forms.ToolStripButton btnCarExpenses;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnBackPageCarReceptions;
        private System.Windows.Forms.ToolStripButton btnNextPageReceptions;
        private System.Windows.Forms.ToolStripButton btnRefreshCarReceptions;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel labelReceptionsDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private Controls.ModernButton btnRefreshCars;
        private System.Windows.Forms.ToolStripButton btnCarsNextPage;
        private System.Windows.Forms.ToolStripButton btnCarsBackPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripComboBox cbReceptinoCount;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.CheckBox cbCurrentCars;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TextBoxName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mileage;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsRepaired;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsReleased;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsExpensesProvided;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepairedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleasedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn extra;
    }
}
