using System.Windows.Forms;

namespace AutoLedger.App.Forms
{
    partial class CarReceptionForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarReceptionForm));
            this.dgCarRequests = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnActionCurrentUser = new System.Windows.Forms.ToolStrip();
            this.btnDeleteCurrentRequest = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteAllRequests = new System.Windows.Forms.ToolStripButton();
            this.labelTotalCost = new System.Windows.Forms.ToolStripLabel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelFactor = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.inputCreatedAt = new AutoLedger.App.Controls.ModernTextBox();
            this.inputReceptionId = new AutoLedger.App.Controls.ModernTextBox();
            this.inputMileage = new AutoLedger.App.Controls.ModernTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPayment = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSubmit = new AutoLedger.App.Controls.ModernButton();
            this.cbIsRepaired = new System.Windows.Forms.CheckBox();
            this.cbIsReleased = new System.Windows.Forms.CheckBox();
            this.toolbarFormControl1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormControl();
            this.toolbarFormManager1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgCarRequests)).BeginInit();
            this.BtnActionCurrentUser.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelFactor.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCarRequests
            // 
            this.dgCarRequests.AllowUserToOrderColumns = true;
            this.dgCarRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgCarRequests.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgCarRequests.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgCarRequests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgCarRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCarRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.Id,
            this.Title,
            this.Description,
            this.Cost,
            this.CreatedAt,
            this.UpdatedAt});
            this.dgCarRequests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCarRequests.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgCarRequests.GridColor = System.Drawing.Color.DimGray;
            this.dgCarRequests.Location = new System.Drawing.Point(4, 5);
            this.dgCarRequests.Margin = new System.Windows.Forms.Padding(0);
            this.dgCarRequests.MultiSelect = false;
            this.dgCarRequests.Name = "dgCarRequests";
            this.dgCarRequests.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgCarRequests.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCarRequests.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgCarRequests.RowHeadersVisible = false;
            this.dgCarRequests.RowHeadersWidth = 50;
            this.dgCarRequests.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgCarRequests.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dgCarRequests.RowTemplate.DividerHeight = 1;
            this.dgCarRequests.RowTemplate.Height = 50;
            this.dgCarRequests.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCarRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgCarRequests.Size = new System.Drawing.Size(895, 422);
            this.dgCarRequests.StandardTab = true;
            this.dgCarRequests.TabIndex = 10;
            // 
            // Index
            // 
            this.Index.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.NullValue = "[سیستم]";
            this.Index.DefaultCellStyle = dataGridViewCellStyle1;
            this.Index.HeaderText = "R";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Index.Width = 52;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Id.DataPropertyName = "Id";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle2.NullValue = "[سیستم]";
            this.Id.DefaultCellStyle = dataGridViewCellStyle2;
            this.Id.HeaderText = "شناسه";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.Width = 66;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "عنوان";
            this.Title.Name = "Title";
            this.Title.Width = 61;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "توضیحات";
            this.Description.Name = "Description";
            // 
            // Cost
            // 
            this.Cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cost.DataPropertyName = "Cost";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Vazirmatn", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Format = "#,0 تومان";
            dataGridViewCellStyle3.NullValue = "0";
            this.Cost.DefaultCellStyle = dataGridViewCellStyle3;
            this.Cost.FillWeight = 200F;
            this.Cost.HeaderText = "هزینه";
            this.Cost.MinimumWidth = 150;
            this.Cost.Name = "Cost";
            this.Cost.Width = 150;
            // 
            // CreatedAt
            // 
            this.CreatedAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CreatedAt.DataPropertyName = "CreatedAt";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Vazirmatn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.NullValue = "[سیستم]";
            this.CreatedAt.DefaultCellStyle = dataGridViewCellStyle4;
            this.CreatedAt.HeaderText = "تاریخ ثبت";
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.ReadOnly = true;
            this.CreatedAt.Width = 80;
            // 
            // UpdatedAt
            // 
            this.UpdatedAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UpdatedAt.DataPropertyName = "UpdatedAt";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Vazirmatn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.NullValue = "[سیستم]";
            this.UpdatedAt.DefaultCellStyle = dataGridViewCellStyle5;
            this.UpdatedAt.HeaderText = "آخرین ویرایش";
            this.UpdatedAt.Name = "UpdatedAt";
            this.UpdatedAt.ReadOnly = true;
            this.UpdatedAt.Width = 102;
            // 
            // BtnActionCurrentUser
            // 
            this.BtnActionCurrentUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnActionCurrentUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnActionCurrentUser.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActionCurrentUser.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.BtnActionCurrentUser.ImageScalingSize = new System.Drawing.Size(80, 80);
            this.BtnActionCurrentUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDeleteCurrentRequest,
            this.btnDeleteAllRequests,
            this.labelTotalCost});
            this.BtnActionCurrentUser.Location = new System.Drawing.Point(4, 427);
            this.BtnActionCurrentUser.Name = "BtnActionCurrentUser";
            this.BtnActionCurrentUser.Padding = new System.Windows.Forms.Padding(5);
            this.BtnActionCurrentUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnActionCurrentUser.Size = new System.Drawing.Size(895, 39);
            this.BtnActionCurrentUser.TabIndex = 16;
            this.BtnActionCurrentUser.Text = "toolStrip1";
            // 
            // btnDeleteCurrentRequest
            // 
            this.btnDeleteCurrentRequest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDeleteCurrentRequest.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDeleteCurrentRequest.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDeleteCurrentRequest.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCurrentRequest.Image")));
            this.btnDeleteCurrentRequest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteCurrentRequest.Name = "btnDeleteCurrentRequest";
            this.btnDeleteCurrentRequest.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnDeleteCurrentRequest.Size = new System.Drawing.Size(51, 26);
            this.btnDeleteCurrentRequest.Text = "حذف";
            // 
            // btnDeleteAllRequests
            // 
            this.btnDeleteAllRequests.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDeleteAllRequests.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDeleteAllRequests.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDeleteAllRequests.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteAllRequests.Name = "btnDeleteAllRequests";
            this.btnDeleteAllRequests.Size = new System.Drawing.Size(67, 26);
            this.btnDeleteAllRequests.Text = "حذف همه";
            // 
            // labelTotalCost
            // 
            this.labelTotalCost.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.labelTotalCost.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalCost.Name = "labelTotalCost";
            this.labelTotalCost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTotalCost.Size = new System.Drawing.Size(92, 26);
            this.labelTotalCost.Text = "[جمع کل هزینه]";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Transparent;
            this.panelLeft.Controls.Add(this.panelFactor);
            this.panelLeft.Controls.Add(this.panelTop);
            this.panelLeft.Controls.Add(this.panelPayment);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 33);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelLeft.Size = new System.Drawing.Size(911, 577);
            this.panelLeft.TabIndex = 17;
            // 
            // panelFactor
            // 
            this.panelFactor.Controls.Add(this.dgCarRequests);
            this.panelFactor.Controls.Add(this.BtnActionCurrentUser);
            this.panelFactor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFactor.Location = new System.Drawing.Point(4, 40);
            this.panelFactor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelFactor.Name = "panelFactor";
            this.panelFactor.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelFactor.Size = new System.Drawing.Size(903, 471);
            this.panelFactor.TabIndex = 20;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelTop.Controls.Add(this.inputCreatedAt);
            this.panelTop.Controls.Add(this.inputReceptionId);
            this.panelTop.Controls.Add(this.inputMileage);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(4, 5);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(903, 35);
            this.panelTop.TabIndex = 142;
            // 
            // inputCreatedAt
            // 
            this.inputCreatedAt.AccentColor = System.Drawing.Color.Empty;
            this.inputCreatedAt.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.inputCreatedAt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.inputCreatedAt.CornerRadius = 2;
            this.inputCreatedAt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputCreatedAt.Dock = System.Windows.Forms.DockStyle.Left;
            this.inputCreatedAt.Enabled = false;
            this.inputCreatedAt.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCreatedAt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.inputCreatedAt.HoverColor = System.Drawing.Color.Empty;
            this.inputCreatedAt.Icon = global::AutoLedger.App.Properties.Resources.calendar_1_128;
            this.inputCreatedAt.Location = new System.Drawing.Point(173, 0);
            this.inputCreatedAt.Margin = new System.Windows.Forms.Padding(0);
            this.inputCreatedAt.Name = "inputCreatedAt";
            this.inputCreatedAt.Placeholder = "[تاریخ ایجاد]";
            this.inputCreatedAt.PlaceholderColor = System.Drawing.Color.BlanchedAlmond;
            this.inputCreatedAt.ShowClearButton = false;
            this.inputCreatedAt.Size = new System.Drawing.Size(211, 35);
            this.inputCreatedAt.TabIndex = 12;
            this.inputCreatedAt.Text = "[تاریخ]";
            this.inputCreatedAt.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputReceptionId
            // 
            this.inputReceptionId.AccentColor = System.Drawing.Color.Empty;
            this.inputReceptionId.BackColor = System.Drawing.Color.DarkRed;
            this.inputReceptionId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.inputReceptionId.CornerRadius = 0;
            this.inputReceptionId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputReceptionId.Dock = System.Windows.Forms.DockStyle.Left;
            this.inputReceptionId.Enabled = false;
            this.inputReceptionId.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputReceptionId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.inputReceptionId.HoverColor = System.Drawing.Color.Empty;
            this.inputReceptionId.Icon = global::AutoLedger.App.Properties.Resources.security_lock_128;
            this.inputReceptionId.Location = new System.Drawing.Point(0, 0);
            this.inputReceptionId.Name = "inputReceptionId";
            this.inputReceptionId.Placeholder = "[شماره فاکتور]";
            this.inputReceptionId.PlaceholderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inputReceptionId.ShowClearButton = false;
            this.inputReceptionId.Size = new System.Drawing.Size(173, 35);
            this.inputReceptionId.TabIndex = 11;
            this.inputReceptionId.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputMileage
            // 
            this.inputMileage.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.inputMileage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.inputMileage.BorderColor = System.Drawing.Color.LightGray;
            this.inputMileage.CornerRadius = 2;
            this.inputMileage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputMileage.Dock = System.Windows.Forms.DockStyle.Right;
            this.inputMileage.ForeColor = System.Drawing.Color.Black;
            this.inputMileage.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.inputMileage.Icon = global::AutoLedger.App.Properties.Resources.speed_128;
            this.inputMileage.Location = new System.Drawing.Point(603, 0);
            this.inputMileage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputMileage.Name = "inputMileage";
            this.inputMileage.NumbersOnly = true;
            this.inputMileage.Placeholder = "کارکرد فعلی (کیلومتر)";
            this.inputMileage.PlaceholderColor = System.Drawing.SystemColors.Desktop;
            this.inputMileage.Size = new System.Drawing.Size(182, 35);
            this.inputMileage.TabIndex = 5;
            this.inputMileage.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(785, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "فرم پذیرش خودرو";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelPayment
            // 
            this.panelPayment.BackColor = System.Drawing.Color.Beige;
            this.panelPayment.Controls.Add(this.btnBack);
            this.panelPayment.Controls.Add(this.btnSubmit);
            this.panelPayment.Controls.Add(this.cbIsRepaired);
            this.panelPayment.Controls.Add(this.cbIsReleased);
            this.panelPayment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPayment.Location = new System.Drawing.Point(4, 511);
            this.panelPayment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelPayment.Name = "panelPayment";
            this.panelPayment.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.panelPayment.Size = new System.Drawing.Size(903, 61);
            this.panelPayment.TabIndex = 20;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Location = new System.Drawing.Point(642, 12);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 39);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "لغو";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSubmit.BaseBackColor = System.Drawing.Color.DarkGreen;
            this.btnSubmit.BorderColor = System.Drawing.Color.Gray;
            this.btnSubmit.CornerRadius = 2;
            this.btnSubmit.FlatAppearance.BorderSize = 6;
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.HoverBackColor = System.Drawing.Color.LightGray;
            this.btnSubmit.Icon = global::AutoLedger.App.Properties.Resources.approval_128;
            this.btnSubmit.IconSize = 20;
            this.btnSubmit.Location = new System.Drawing.Point(734, 10);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.PressedBackColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSubmit.Size = new System.Drawing.Size(161, 43);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "ثبت و تایید اطلاعات";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // cbIsRepaired
            // 
            this.cbIsRepaired.BackColor = System.Drawing.Color.Beige;
            this.cbIsRepaired.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbIsRepaired.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbIsRepaired.Location = new System.Drawing.Point(186, 0);
            this.cbIsRepaired.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbIsRepaired.Name = "cbIsRepaired";
            this.cbIsRepaired.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbIsRepaired.Size = new System.Drawing.Size(134, 61);
            this.cbIsRepaired.TabIndex = 19;
            this.cbIsRepaired.Text = "پایان تعمیرات";
            this.cbIsRepaired.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbIsRepaired.UseVisualStyleBackColor = false;
            // 
            // cbIsReleased
            // 
            this.cbIsReleased.BackColor = System.Drawing.Color.Beige;
            this.cbIsReleased.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbIsReleased.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsReleased.ForeColor = System.Drawing.Color.SeaGreen;
            this.cbIsReleased.Location = new System.Drawing.Point(20, 0);
            this.cbIsReleased.Margin = new System.Windows.Forms.Padding(0);
            this.cbIsReleased.Name = "cbIsReleased";
            this.cbIsReleased.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbIsReleased.Size = new System.Drawing.Size(166, 61);
            this.cbIsReleased.TabIndex = 10;
            this.cbIsReleased.Text = "ترخیص و تحویل خودرو";
            this.cbIsReleased.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbIsReleased.UseVisualStyleBackColor = false;
            // 
            // toolbarFormControl1
            // 
            this.toolbarFormControl1.Location = new System.Drawing.Point(0, 0);
            this.toolbarFormControl1.Manager = this.toolbarFormManager1;
            this.toolbarFormControl1.Name = "toolbarFormControl1";
            this.toolbarFormControl1.Size = new System.Drawing.Size(911, 33);
            this.toolbarFormControl1.TabIndex = 18;
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
            this.barDockControlTop.Size = new System.Drawing.Size(911, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 610);
            this.barDockControlBottom.Manager = this.toolbarFormManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(911, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 33);
            this.barDockControlLeft.Manager = this.toolbarFormManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 577);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(911, 33);
            this.barDockControlRight.Manager = this.toolbarFormManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 577);
            // 
            // CarReceptionForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 610);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.toolbarFormControl1);
            this.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("CarReceptionForm.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "CarReceptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم پذیرش خودرو";
            this.ToolbarFormControl = this.toolbarFormControl1;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dgCarRequests)).EndInit();
            this.BtnActionCurrentUser.ResumeLayout(false);
            this.BtnActionCurrentUser.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelFactor.ResumeLayout(false);
            this.panelFactor.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelPayment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgCarRequests;
        private System.Windows.Forms.ToolStrip BtnActionCurrentUser;
        private System.Windows.Forms.Panel panelLeft;
        private Controls.ModernTextBox inputMileage;
        private Controls.ModernButton btnSubmit;
        private System.Windows.Forms.ToolStripButton btnDeleteCurrentRequest;
        private System.Windows.Forms.ToolStripButton btnDeleteAllRequests;
        private Panel panelFactor;
        private CheckBox cbIsReleased;
        private Button btnBack;
        private Panel panelPayment;
        private ToolStripLabel labelTotalCost;
        private CheckBox cbIsRepaired;
        private DataGridViewTextBoxColumn Index;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Cost;
        private DataGridViewTextBoxColumn CreatedAt;
        private DataGridViewTextBoxColumn UpdatedAt;
        private Panel panelTop;
        private Controls.ModernTextBox inputCreatedAt;
        private Controls.ModernTextBox inputReceptionId;
        private Label label1;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormControl toolbarFormControl1;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormManager toolbarFormManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}