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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.TextBoxName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFactor = new System.Windows.Forms.Panel();
            this.dgCarReceptions = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mileage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsRepaired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsReleased = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RepairedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleasedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnActionCurrentUser = new System.Windows.Forms.ToolStrip();
            this.btnReceptionNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnReceptionEdit = new System.Windows.Forms.ToolStripButton();
            this.btnReceptionDelete = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSelectedCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCars)).BeginInit();
            this.panelFactor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCarReceptions)).BeginInit();
            this.BtnActionCurrentUser.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.dataGridSelectedCar.ColumnHeadersHeight = 35;
            this.dataGridSelectedCar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._index,
            this.OwnerPhoneNumber,
            this.OwnerCardId,
            this.Color,
            this.Tip,
            this.Model,
            this.Brand});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.NullValue = "[عبارت پر نشده]";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridSelectedCar.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridSelectedCar.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridSelectedCar.Enabled = false;
            this.dataGridSelectedCar.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridSelectedCar.Location = new System.Drawing.Point(5, 6);
            this.dataGridSelectedCar.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridSelectedCar.MultiSelect = false;
            this.dataGridSelectedCar.Name = "dataGridSelectedCar";
            this.dataGridSelectedCar.ReadOnly = true;
            this.dataGridSelectedCar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSelectedCar.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridSelectedCar.RowHeadersVisible = false;
            this.dataGridSelectedCar.RowHeadersWidth = 40;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridSelectedCar.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridSelectedCar.RowTemplate.Height = 40;
            this.dataGridSelectedCar.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridSelectedCar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridSelectedCar.Size = new System.Drawing.Size(806, 98);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGreen;
            this.OwnerPhoneNumber.DefaultCellStyle = dataGridViewCellStyle1;
            this.OwnerPhoneNumber.HeaderText = "شماره تماس";
            this.OwnerPhoneNumber.Name = "OwnerPhoneNumber";
            this.OwnerPhoneNumber.ReadOnly = true;
            // 
            // OwnerCardId
            // 
            this.OwnerCardId.DataPropertyName = "OwnerCardId";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGreen;
            this.OwnerCardId.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.dgCars.ColumnHeadersHeight = 35;
            this.dgCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.TextBoxName,
            this.OwnerFullName});
            this.dgCars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCars.GridColor = System.Drawing.SystemColors.Control;
            this.dgCars.Location = new System.Drawing.Point(5, 29);
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
            this.dgCars.Size = new System.Drawing.Size(294, 870);
            this.dgCars.TabIndex = 15;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Id.DataPropertyName = "Id";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id.DefaultCellStyle = dataGridViewCellStyle6;
            this.Id.HeaderText = "R";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 43;
            // 
            // TextBoxName
            // 
            this.TextBoxName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TextBoxName.DataPropertyName = "PlateId";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxName.DefaultCellStyle = dataGridViewCellStyle7;
            this.TextBoxName.HeaderText = "پلاک";
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.ReadOnly = true;
            this.TextBoxName.Width = 58;
            // 
            // OwnerFullName
            // 
            this.OwnerFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OwnerFullName.DataPropertyName = "OwnerFullName";
            this.OwnerFullName.HeaderText = "مالک";
            this.OwnerFullName.Name = "OwnerFullName";
            this.OwnerFullName.ReadOnly = true;
            // 
            // panelFactor
            // 
            this.panelFactor.Controls.Add(this.dgCarReceptions);
            this.panelFactor.Controls.Add(this.BtnActionCurrentUser);
            this.panelFactor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFactor.Location = new System.Drawing.Point(5, 104);
            this.panelFactor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelFactor.Name = "panelFactor";
            this.panelFactor.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.panelFactor.Size = new System.Drawing.Size(806, 801);
            this.panelFactor.TabIndex = 21;
            // 
            // dgCarReceptions
            // 
            this.dgCarReceptions.AllowUserToAddRows = false;
            this.dgCarReceptions.AllowUserToDeleteRows = false;
            this.dgCarReceptions.AllowUserToOrderColumns = true;
            this.dgCarReceptions.AllowUserToResizeRows = false;
            this.dgCarReceptions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCarReceptions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgCarReceptions.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgCarReceptions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgCarReceptions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgCarReceptions.ColumnHeadersHeight = 35;
            this.dgCarReceptions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.Title,
            this.Mileage,
            this.TotalCost,
            this.IsRepaired,
            this.IsReleased,
            this.CreatedAt,
            this.RepairedAt,
            this.ReleasedAt,
            this.UpdatedAt,
            this.extra});
            this.dgCarReceptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCarReceptions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgCarReceptions.GridColor = System.Drawing.Color.DimGray;
            this.dgCarReceptions.Location = new System.Drawing.Point(0, 49);
            this.dgCarReceptions.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.dgCarReceptions.MultiSelect = false;
            this.dgCarReceptions.Name = "dgCarReceptions";
            this.dgCarReceptions.ReadOnly = true;
            this.dgCarReceptions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgCarReceptions.RowHeadersVisible = false;
            this.dgCarReceptions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgCarReceptions.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgCarReceptions.RowTemplate.DefaultCellStyle.NullValue = "[تعریف نشده]";
            this.dgCarReceptions.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dgCarReceptions.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.dgCarReceptions.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgCarReceptions.RowTemplate.DividerHeight = 1;
            this.dgCarReceptions.RowTemplate.Height = 40;
            this.dgCarReceptions.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCarReceptions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCarReceptions.Size = new System.Drawing.Size(806, 752);
            this.dgCarReceptions.StandardTab = true;
            this.dgCarReceptions.TabIndex = 10;
            // 
            // Index
            // 
            this.Index.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Index.DataPropertyName = "Index";
            this.Index.HeaderText = "R";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Index.Width = 43;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Title.DataPropertyName = "Id";
            this.Title.HeaderText = "شناسه";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 69;
            // 
            // Mileage
            // 
            this.Mileage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Mileage.DataPropertyName = "Mileage";
            this.Mileage.HeaderText = "کیلومتر";
            this.Mileage.Name = "Mileage";
            this.Mileage.ReadOnly = true;
            this.Mileage.Width = 73;
            // 
            // TotalCost
            // 
            this.TotalCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TotalCost.DataPropertyName = "TotalCost";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Format = "#,0 تومان";
            dataGridViewCellStyle8.NullValue = "0";
            this.TotalCost.DefaultCellStyle = dataGridViewCellStyle8;
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
            this.IsRepaired.Width = 89;
            // 
            // IsReleased
            // 
            this.IsReleased.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IsReleased.DataPropertyName = "IsReleased";
            this.IsReleased.HeaderText = "ترخیص شده";
            this.IsReleased.Name = "IsReleased";
            this.IsReleased.ReadOnly = true;
            // 
            // CreatedAt
            // 
            this.CreatedAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CreatedAt.DataPropertyName = "CreatedAt";
            dataGridViewCellStyle9.Format = "D";
            dataGridViewCellStyle9.NullValue = null;
            this.CreatedAt.DefaultCellStyle = dataGridViewCellStyle9;
            this.CreatedAt.HeaderText = "تاریخ پذیرش";
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.ReadOnly = true;
            this.CreatedAt.Width = 97;
            // 
            // RepairedAt
            // 
            this.RepairedAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RepairedAt.DataPropertyName = "RepairedAt";
            this.RepairedAt.HeaderText = "تاریخ تعمیر";
            this.RepairedAt.Name = "RepairedAt";
            this.RepairedAt.ReadOnly = true;
            this.RepairedAt.Width = 91;
            // 
            // ReleasedAt
            // 
            this.ReleasedAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ReleasedAt.DataPropertyName = "ReleasedAt";
            this.ReleasedAt.HeaderText = "تاریخ ترخیص";
            this.ReleasedAt.Name = "ReleasedAt";
            this.ReleasedAt.ReadOnly = true;
            this.ReleasedAt.Width = 102;
            // 
            // UpdatedAt
            // 
            this.UpdatedAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UpdatedAt.DataPropertyName = "UpdatedAt";
            this.UpdatedAt.HeaderText = "تاریخ ویرایش";
            this.UpdatedAt.Name = "UpdatedAt";
            this.UpdatedAt.ReadOnly = true;
            // 
            // extra
            // 
            this.extra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.extra.HeaderText = "";
            this.extra.Name = "extra";
            this.extra.ReadOnly = true;
            this.extra.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // BtnActionCurrentUser
            // 
            this.BtnActionCurrentUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnActionCurrentUser.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnActionCurrentUser.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.BtnActionCurrentUser.ImageScalingSize = new System.Drawing.Size(80, 80);
            this.BtnActionCurrentUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReceptionNew,
            this.toolStripSeparator1,
            this.btnReceptionEdit,
            this.btnReceptionDelete});
            this.BtnActionCurrentUser.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.BtnActionCurrentUser.Location = new System.Drawing.Point(0, 6);
            this.BtnActionCurrentUser.Name = "BtnActionCurrentUser";
            this.BtnActionCurrentUser.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnActionCurrentUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnActionCurrentUser.Size = new System.Drawing.Size(806, 43);
            this.BtnActionCurrentUser.TabIndex = 16;
            this.BtnActionCurrentUser.Text = "toolStrip1";
            // 
            // btnReceptionNew
            // 
            this.btnReceptionNew.AutoSize = false;
            this.btnReceptionNew.Image = global::AutoLedger.App.Properties.Resources.hitfilm_pro_128;
            this.btnReceptionNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReceptionNew.Name = "btnReceptionNew";
            this.btnReceptionNew.Size = new System.Drawing.Size(100, 30);
            this.btnReceptionNew.Text = "فاکتور جدید";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // btnReceptionEdit
            // 
            this.btnReceptionEdit.AutoSize = false;
            this.btnReceptionEdit.Image = global::AutoLedger.App.Properties.Resources.four_squares_128;
            this.btnReceptionEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReceptionEdit.Name = "btnReceptionEdit";
            this.btnReceptionEdit.Size = new System.Drawing.Size(75, 30);
            this.btnReceptionEdit.Text = "ویرایش";
            // 
            // btnReceptionDelete
            // 
            this.btnReceptionDelete.AutoSize = false;
            this.btnReceptionDelete.Image = global::AutoLedger.App.Properties.Resources.erase_128;
            this.btnReceptionDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReceptionDelete.Name = "btnReceptionDelete";
            this.btnReceptionDelete.Size = new System.Drawing.Size(70, 30);
            this.btnReceptionDelete.Text = "حذف";
            this.btnReceptionDelete.ToolTipText = "حذف";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgCars);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(811, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(299, 899);
            this.panel1.TabIndex = 22;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip1.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(80, 80);
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(5, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(294, 29);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // CarsManagerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Controls.Add(this.panelFactor);
            this.Controls.Add(this.dataGridSelectedCar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CarsManagerPage";
            this.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Size = new System.Drawing.Size(1115, 911);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSelectedCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCars)).EndInit();
            this.panelFactor.ResumeLayout(false);
            this.panelFactor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCarReceptions)).EndInit();
            this.BtnActionCurrentUser.ResumeLayout(false);
            this.BtnActionCurrentUser.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridSelectedCar;
        private System.Windows.Forms.DataGridView dgCars;
        private System.Windows.Forms.Panel panelFactor;
        private System.Windows.Forms.ToolStrip BtnActionCurrentUser;
        private System.Windows.Forms.DataGridView dgCarReceptions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TextBoxName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerFullName;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mileage;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsRepaired;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsReleased;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepairedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleasedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn extra;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}
