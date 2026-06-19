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
            this.labelTittle = new System.Windows.Forms.Label();
            this.panelPayment = new System.Windows.Forms.Panel();
            this.cbIsReleased = new System.Windows.Forms.CheckBox();
            this.cbIsRepaired = new System.Windows.Forms.CheckBox();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.dateReceptionAt = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.inputMileage = new AutoLedger.App.Controls.ModernTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCarReception = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.carIdControl = new AutoLedger.App.Controls.CarIdControl();
            this.inputUserCardId = new AutoLedger.App.Controls.ModernTextBox();
            this.inputFullName = new AutoLedger.App.Controls.ModernTextBox();
            this.inputPhoneNumber = new AutoLedger.App.Controls.ModernTextBox();
            this.inputColor = new AutoLedger.App.Controls.ModernTextBox();
            this.inputTip = new AutoLedger.App.Controls.ModernTextBox();
            this.inputBrand = new AutoLedger.App.Controls.ModernTextBox();
            this.inputModel = new AutoLedger.App.Controls.ModernTextBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSubmit = new AutoLedger.App.Controls.ModernButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgCarRequests)).BeginInit();
            this.BtnActionCurrentUser.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelFactor.SuspendLayout();
            this.panelPayment.SuspendLayout();
            this.panelDetails.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgCarRequests
            // 
            this.dgCarRequests.AllowUserToOrderColumns = true;
            this.dgCarRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgCarRequests.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgCarRequests.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgCarRequests.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgCarRequests.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgCarRequests.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
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
            this.dgCarRequests.Location = new System.Drawing.Point(5, 69);
            this.dgCarRequests.Margin = new System.Windows.Forms.Padding(0);
            this.dgCarRequests.MultiSelect = false;
            this.dgCarRequests.Name = "dgCarRequests";
            this.dgCarRequests.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgCarRequests.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dgCarRequests.Size = new System.Drawing.Size(766, 343);
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
            this.Index.Width = 65;
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
            this.Id.Width = 78;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "عنوان";
            this.Title.Name = "Title";
            this.Title.Width = 70;
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
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle4.NullValue = "[سیستم]";
            this.CreatedAt.DefaultCellStyle = dataGridViewCellStyle4;
            this.CreatedAt.HeaderText = "تاریخ ثبت";
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.ReadOnly = true;
            this.CreatedAt.Width = 94;
            // 
            // UpdatedAt
            // 
            this.UpdatedAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UpdatedAt.DataPropertyName = "UpdatedAt";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle5.NullValue = "[سیستم]";
            this.UpdatedAt.DefaultCellStyle = dataGridViewCellStyle5;
            this.UpdatedAt.HeaderText = "آخرین ویرایش";
            this.UpdatedAt.Name = "UpdatedAt";
            this.UpdatedAt.ReadOnly = true;
            this.UpdatedAt.Width = 120;
            // 
            // BtnActionCurrentUser
            // 
            this.BtnActionCurrentUser.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnActionCurrentUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnActionCurrentUser.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnActionCurrentUser.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.BtnActionCurrentUser.ImageScalingSize = new System.Drawing.Size(80, 80);
            this.BtnActionCurrentUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDeleteCurrentRequest,
            this.btnDeleteAllRequests,
            this.labelTotalCost});
            this.BtnActionCurrentUser.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.BtnActionCurrentUser.Location = new System.Drawing.Point(5, 412);
            this.BtnActionCurrentUser.Name = "BtnActionCurrentUser";
            this.BtnActionCurrentUser.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnActionCurrentUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnActionCurrentUser.Size = new System.Drawing.Size(766, 40);
            this.BtnActionCurrentUser.TabIndex = 16;
            this.BtnActionCurrentUser.Text = "toolStrip1";
            // 
            // btnDeleteCurrentRequest
            // 
            this.btnDeleteCurrentRequest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDeleteCurrentRequest.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDeleteCurrentRequest.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDeleteCurrentRequest.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCurrentRequest.Image")));
            this.btnDeleteCurrentRequest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteCurrentRequest.Name = "btnDeleteCurrentRequest";
            this.btnDeleteCurrentRequest.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnDeleteCurrentRequest.Size = new System.Drawing.Size(52, 27);
            this.btnDeleteCurrentRequest.Text = "حذف";
            // 
            // btnDeleteAllRequests
            // 
            this.btnDeleteAllRequests.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDeleteAllRequests.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDeleteAllRequests.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDeleteAllRequests.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteAllRequests.Name = "btnDeleteAllRequests";
            this.btnDeleteAllRequests.Size = new System.Drawing.Size(68, 27);
            this.btnDeleteAllRequests.Text = "حذف همه";
            // 
            // labelTotalCost
            // 
            this.labelTotalCost.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.labelTotalCost.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelTotalCost.Name = "labelTotalCost";
            this.labelTotalCost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTotalCost.Size = new System.Drawing.Size(112, 27);
            this.labelTotalCost.Text = "[جمع کل هزینه]";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Transparent;
            this.panelLeft.Controls.Add(this.panelFactor);
            this.panelLeft.Controls.Add(this.panelPayment);
            this.panelLeft.Controls.Add(this.panelDetails);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(10, 12);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panelLeft.Size = new System.Drawing.Size(786, 660);
            this.panelLeft.TabIndex = 17;
            // 
            // panelFactor
            // 
            this.panelFactor.Controls.Add(this.dgCarRequests);
            this.panelFactor.Controls.Add(this.BtnActionCurrentUser);
            this.panelFactor.Controls.Add(this.labelTittle);
            this.panelFactor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFactor.Location = new System.Drawing.Point(5, 119);
            this.panelFactor.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panelFactor.Name = "panelFactor";
            this.panelFactor.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panelFactor.Size = new System.Drawing.Size(776, 458);
            this.panelFactor.TabIndex = 20;
            // 
            // labelTittle
            // 
            this.labelTittle.BackColor = System.Drawing.SystemColors.Window;
            this.labelTittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTittle.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelTittle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTittle.Location = new System.Drawing.Point(5, 6);
            this.labelTittle.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.labelTittle.Name = "labelTittle";
            this.labelTittle.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.labelTittle.Size = new System.Drawing.Size(766, 63);
            this.labelTittle.TabIndex = 17;
            this.labelTittle.Text = "فهرست و هزینه ها";
            this.labelTittle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panelPayment
            // 
            this.panelPayment.Controls.Add(this.cbIsReleased);
            this.panelPayment.Controls.Add(this.cbIsRepaired);
            this.panelPayment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPayment.Location = new System.Drawing.Point(5, 577);
            this.panelPayment.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panelPayment.Name = "panelPayment";
            this.panelPayment.Padding = new System.Windows.Forms.Padding(20);
            this.panelPayment.Size = new System.Drawing.Size(776, 77);
            this.panelPayment.TabIndex = 20;
            // 
            // cbIsReleased
            // 
            this.cbIsReleased.BackColor = System.Drawing.Color.Beige;
            this.cbIsReleased.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbIsReleased.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsReleased.ForeColor = System.Drawing.Color.SeaGreen;
            this.cbIsReleased.Location = new System.Drawing.Point(294, 20);
            this.cbIsReleased.Margin = new System.Windows.Forms.Padding(0);
            this.cbIsReleased.Name = "cbIsReleased";
            this.cbIsReleased.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbIsReleased.Size = new System.Drawing.Size(239, 37);
            this.cbIsReleased.TabIndex = 10;
            this.cbIsReleased.Text = "ترخیص و تحویل خودرو";
            this.cbIsReleased.UseVisualStyleBackColor = false;
            // 
            // cbIsRepaired
            // 
            this.cbIsRepaired.BackColor = System.Drawing.Color.Beige;
            this.cbIsRepaired.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbIsRepaired.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsRepaired.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbIsRepaired.Location = new System.Drawing.Point(533, 20);
            this.cbIsRepaired.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cbIsRepaired.Name = "cbIsRepaired";
            this.cbIsRepaired.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbIsRepaired.Size = new System.Drawing.Size(223, 37);
            this.cbIsRepaired.TabIndex = 19;
            this.cbIsRepaired.Text = "پایان تعمیرات";
            this.cbIsRepaired.UseVisualStyleBackColor = false;
            // 
            // panelDetails
            // 
            this.panelDetails.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelDetails.Controls.Add(this.dateReceptionAt);
            this.panelDetails.Controls.Add(this.label1);
            this.panelDetails.Controls.Add(this.inputMileage);
            this.panelDetails.Controls.Add(this.label3);
            this.panelDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDetails.Location = new System.Drawing.Point(5, 6);
            this.panelDetails.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(776, 113);
            this.panelDetails.TabIndex = 21;
            // 
            // dateReceptionAt
            // 
            this.dateReceptionAt.Location = new System.Drawing.Point(18, 64);
            this.dateReceptionAt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dateReceptionAt.Name = "dateReceptionAt";
            this.dateReceptionAt.Size = new System.Drawing.Size(201, 31);
            this.dateReceptionAt.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 31);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(90, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "تاریخ پذیرش:";
            // 
            // inputMileage
            // 
            this.inputMileage.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.inputMileage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputMileage.BackColor = System.Drawing.SystemColors.Window;
            this.inputMileage.BorderColor = System.Drawing.Color.LightGray;
            this.inputMileage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputMileage.ForeColor = System.Drawing.Color.Black;
            this.inputMileage.Icon = global::AutoLedger.App.Properties.Resources.speed_128;
            this.inputMileage.Location = new System.Drawing.Point(558, 57);
            this.inputMileage.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.inputMileage.Name = "inputMileage";
            this.inputMileage.NumbersOnly = true;
            this.inputMileage.PasswordChar = '\0';
            this.inputMileage.Placeholder = "کارکرد فعلی (کیلومتر)";
            this.inputMileage.PlaceholderColor = System.Drawing.SystemColors.Desktop;
            this.inputMileage.Size = new System.Drawing.Size(200, 37);
            this.inputMileage.TabIndex = 5;
            this.inputMileage.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.label3.Size = new System.Drawing.Size(776, 63);
            this.label3.TabIndex = 18;
            this.label3.Text = "اطلاعات پذیرش خودرو";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelRight.Controls.Add(this.label4);
            this.panelRight.Controls.Add(this.button1);
            this.panelRight.Controls.Add(this.btnCarReception);
            this.panelRight.Controls.Add(this.label2);
            this.panelRight.Controls.Add(this.carIdControl);
            this.panelRight.Controls.Add(this.inputUserCardId);
            this.panelRight.Controls.Add(this.inputFullName);
            this.panelRight.Controls.Add(this.inputPhoneNumber);
            this.panelRight.Controls.Add(this.inputColor);
            this.panelRight.Controls.Add(this.inputTip);
            this.panelRight.Controls.Add(this.inputBrand);
            this.panelRight.Controls.Add(this.inputModel);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(796, 12);
            this.panelRight.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(337, 660);
            this.panelRight.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Vazirmatn", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(94, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 57);
            this.label4.TabIndex = 17;
            this.label4.Text = "آیرون تیونینگ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::AutoLedger.App.Properties.Resources.add_car;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(22, 26);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 93);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCarReception
            // 
            this.btnCarReception.BackgroundImage = global::AutoLedger.App.Properties.Resources.add_car;
            this.btnCarReception.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCarReception.FlatAppearance.BorderSize = 0;
            this.btnCarReception.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarReception.Location = new System.Drawing.Point(255, 26);
            this.btnCarReception.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCarReception.Name = "btnCarReception";
            this.btnCarReception.Size = new System.Drawing.Size(70, 93);
            this.btnCarReception.TabIndex = 2;
            this.btnCarReception.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Vazirmatn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(61, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 57);
            this.label2.TabIndex = 15;
            this.label2.Text = "فرم پذیرش خودرو";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // carIdControl
            // 
            this.carIdControl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.carIdControl.Enabled = false;
            this.carIdControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.carIdControl.Location = new System.Drawing.Point(17, 139);
            this.carIdControl.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.carIdControl.Name = "carIdControl";
            this.carIdControl.Size = new System.Drawing.Size(302, 74);
            this.carIdControl.TabIndex = 1;
            // 
            // inputUserCardId
            // 
            this.inputUserCardId.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.inputUserCardId.BackColor = System.Drawing.Color.White;
            this.inputUserCardId.BorderColor = System.Drawing.Color.LightGray;
            this.inputUserCardId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputUserCardId.ForeColor = System.Drawing.Color.Black;
            this.inputUserCardId.Icon = global::AutoLedger.App.Properties.Resources.verified_badge_128;
            this.inputUserCardId.Location = new System.Drawing.Point(17, 449);
            this.inputUserCardId.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.inputUserCardId.MaxLength = 10;
            this.inputUserCardId.Name = "inputUserCardId";
            this.inputUserCardId.PasswordChar = '\0';
            this.inputUserCardId.Placeholder = "کد ملی";
            this.inputUserCardId.PlaceholderColor = System.Drawing.Color.Black;
            this.inputUserCardId.Size = new System.Drawing.Size(293, 46);
            this.inputUserCardId.TabIndex = 6;
            this.inputUserCardId.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputFullName
            // 
            this.inputFullName.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.inputFullName.BackColor = System.Drawing.SystemColors.Window;
            this.inputFullName.BorderColor = System.Drawing.Color.LightGray;
            this.inputFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputFullName.ForeColor = System.Drawing.Color.Black;
            this.inputFullName.Icon = global::AutoLedger.App.Properties.Resources.bussiness_man;
            this.inputFullName.Location = new System.Drawing.Point(17, 393);
            this.inputFullName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.inputFullName.MaxLength = 150;
            this.inputFullName.Name = "inputFullName";
            this.inputFullName.PasswordChar = '\0';
            this.inputFullName.Placeholder = "نام و نام خانوادگی";
            this.inputFullName.PlaceholderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inputFullName.Size = new System.Drawing.Size(293, 46);
            this.inputFullName.TabIndex = 7;
            this.inputFullName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputPhoneNumber
            // 
            this.inputPhoneNumber.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.inputPhoneNumber.BackColor = System.Drawing.Color.White;
            this.inputPhoneNumber.BorderColor = System.Drawing.Color.LightGray;
            this.inputPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.inputPhoneNumber.Icon = global::AutoLedger.App.Properties.Resources.phone_128;
            this.inputPhoneNumber.Location = new System.Drawing.Point(17, 505);
            this.inputPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.inputPhoneNumber.MaxLength = 15;
            this.inputPhoneNumber.Name = "inputPhoneNumber";
            this.inputPhoneNumber.PasswordChar = '\0';
            this.inputPhoneNumber.Placeholder = "تلفن همراه";
            this.inputPhoneNumber.PlaceholderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inputPhoneNumber.Size = new System.Drawing.Size(293, 46);
            this.inputPhoneNumber.TabIndex = 8;
            this.inputPhoneNumber.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputColor
            // 
            this.inputColor.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.inputColor.BackColor = System.Drawing.SystemColors.Window;
            this.inputColor.BorderColor = System.Drawing.Color.LightGray;
            this.inputColor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputColor.ForeColor = System.Drawing.Color.Black;
            this.inputColor.Icon = global::AutoLedger.App.Properties.Resources.color_wheel_128;
            this.inputColor.Location = new System.Drawing.Point(170, 314);
            this.inputColor.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.inputColor.MaxLength = 30;
            this.inputColor.Name = "inputColor";
            this.inputColor.PasswordChar = '\0';
            this.inputColor.Placeholder = "رنگ";
            this.inputColor.PlaceholderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inputColor.Size = new System.Drawing.Size(145, 46);
            this.inputColor.TabIndex = 3;
            this.inputColor.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputTip
            // 
            this.inputTip.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.inputTip.BackColor = System.Drawing.SystemColors.Window;
            this.inputTip.BorderColor = System.Drawing.Color.LightGray;
            this.inputTip.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputTip.ForeColor = System.Drawing.Color.Black;
            this.inputTip.Icon = global::AutoLedger.App.Properties.Resources.info_128;
            this.inputTip.Location = new System.Drawing.Point(19, 314);
            this.inputTip.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.inputTip.MaxLength = 100;
            this.inputTip.Name = "inputTip";
            this.inputTip.PasswordChar = '\0';
            this.inputTip.Placeholder = "تیپ";
            this.inputTip.PlaceholderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inputTip.Size = new System.Drawing.Size(145, 46);
            this.inputTip.TabIndex = 4;
            this.inputTip.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputBrand
            // 
            this.inputBrand.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.inputBrand.BackColor = System.Drawing.SystemColors.Window;
            this.inputBrand.BorderColor = System.Drawing.Color.LightGray;
            this.inputBrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputBrand.ForeColor = System.Drawing.Color.Black;
            this.inputBrand.Icon = global::AutoLedger.App.Properties.Resources.mercedes_benz_128;
            this.inputBrand.Location = new System.Drawing.Point(170, 259);
            this.inputBrand.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.inputBrand.MaxLength = 50;
            this.inputBrand.Name = "inputBrand";
            this.inputBrand.PasswordChar = '\0';
            this.inputBrand.Placeholder = "برند";
            this.inputBrand.PlaceholderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inputBrand.Size = new System.Drawing.Size(145, 46);
            this.inputBrand.TabIndex = 2;
            this.inputBrand.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputModel
            // 
            this.inputModel.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.inputModel.BackColor = System.Drawing.SystemColors.Window;
            this.inputModel.BorderColor = System.Drawing.Color.LightGray;
            this.inputModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputModel.ForeColor = System.Drawing.Color.Black;
            this.inputModel.Icon = global::AutoLedger.App.Properties.Resources.tesla_model_x_128;
            this.inputModel.Location = new System.Drawing.Point(19, 259);
            this.inputModel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.inputModel.MaxLength = 4;
            this.inputModel.Name = "inputModel";
            this.inputModel.NumbersOnly = true;
            this.inputModel.PasswordChar = '\0';
            this.inputModel.Placeholder = "مدل";
            this.inputModel.PlaceholderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inputModel.Size = new System.Drawing.Size(145, 46);
            this.inputModel.TabIndex = 2;
            this.inputModel.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelBottom.Controls.Add(this.btnBack);
            this.panelBottom.Controls.Add(this.btnSubmit);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(10, 672);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1123, 55);
            this.panelBottom.TabIndex = 141;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(786, 5);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(116, 45);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "لغو";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.btnSubmit.BaseBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.btnSubmit.BorderColor = System.Drawing.Color.Gray;
            this.btnSubmit.FlatAppearance.BorderSize = 6;
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.HoverBackColor = System.Drawing.Color.LightGray;
            this.btnSubmit.Icon = global::AutoLedger.App.Properties.Resources.approval_128;
            this.btnSubmit.IconSize = 25;
            this.btnSubmit.Location = new System.Drawing.Point(908, 5);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.PressedBackColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSubmit.Size = new System.Drawing.Size(203, 45);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "ثبت و تایید اطلاعات";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // CarReceptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1143, 739);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelBottom);
            this.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CarReceptionForm";
            this.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم پذیرش خودرو";
            ((System.ComponentModel.ISupportInitialize)(this.dgCarRequests)).EndInit();
            this.BtnActionCurrentUser.ResumeLayout(false);
            this.BtnActionCurrentUser.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelFactor.ResumeLayout(false);
            this.panelFactor.PerformLayout();
            this.panelPayment.ResumeLayout(false);
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgCarRequests;
        private System.Windows.Forms.ToolStrip BtnActionCurrentUser;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateReceptionAt;
        private Controls.ModernTextBox inputMileage;
        private Controls.ModernButton btnSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTittle;
        private System.Windows.Forms.ToolStripButton btnDeleteCurrentRequest;
        private System.Windows.Forms.ToolStripButton btnDeleteAllRequests;
        private Controls.ModernTextBox inputColor;
        private Controls.ModernTextBox inputTip;
        private Controls.ModernTextBox inputBrand;
        private Controls.CarIdControl carIdControl;
        private Controls.ModernTextBox inputModel;
        private Controls.ModernTextBox inputPhoneNumber;
        private Controls.ModernTextBox inputFullName;
        private Controls.ModernTextBox inputUserCardId;
        private Panel panelBottom;
        private Panel panelFactor;
        private CheckBox cbIsReleased;
        private Button btnBack;
        private Panel panelPayment;
        private ToolStripLabel labelTotalCost;
        private Button btnCarReception;
        private Button button1;
        private Panel panelDetails;
        private Label label3;
        private Label label4;
        private CheckBox cbIsRepaired;
        private DataGridViewTextBoxColumn Index;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Cost;
        private DataGridViewTextBoxColumn CreatedAt;
        private DataGridViewTextBoxColumn UpdatedAt;
    }
}