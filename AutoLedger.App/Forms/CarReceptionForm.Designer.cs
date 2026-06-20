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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.panelRight = new System.Windows.Forms.Panel();
            this.btnCarReception = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.inputMileage = new AutoLedger.App.Controls.ModernTextBox();
            this.carIdControl = new AutoLedger.App.Controls.CarIdControl();
            this.inputUserCardId = new AutoLedger.App.Controls.ModernTextBox();
            this.inputFullName = new AutoLedger.App.Controls.ModernTextBox();
            this.inputPhoneNumber = new AutoLedger.App.Controls.ModernTextBox();
            this.inputColor = new AutoLedger.App.Controls.ModernTextBox();
            this.inputTip = new AutoLedger.App.Controls.ModernTextBox();
            this.inputBrand = new AutoLedger.App.Controls.ModernTextBox();
            this.inputModel = new AutoLedger.App.Controls.ModernTextBox();
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
            this.dgCarRequests.BackgroundColor = System.Drawing.Color.PeachPuff;
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
            this.dgCarRequests.Location = new System.Drawing.Point(4, 49);
            this.dgCarRequests.Margin = new System.Windows.Forms.Padding(0);
            this.dgCarRequests.MultiSelect = false;
            this.dgCarRequests.Name = "dgCarRequests";
            this.dgCarRequests.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgCarRequests.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCarRequests.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgCarRequests.RowHeadersVisible = false;
            this.dgCarRequests.RowHeadersWidth = 50;
            this.dgCarRequests.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgCarRequests.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dgCarRequests.RowTemplate.DividerHeight = 1;
            this.dgCarRequests.RowTemplate.Height = 50;
            this.dgCarRequests.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCarRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgCarRequests.Size = new System.Drawing.Size(749, 413);
            this.dgCarRequests.StandardTab = true;
            this.dgCarRequests.TabIndex = 10;
            // 
            // Index
            // 
            this.Index.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle7.NullValue = "[سیستم]";
            this.Index.DefaultCellStyle = dataGridViewCellStyle7;
            this.Index.HeaderText = "R";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Index.Width = 66;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Id.DataPropertyName = "Id";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle8.NullValue = "[سیستم]";
            this.Id.DefaultCellStyle = dataGridViewCellStyle8;
            this.Id.HeaderText = "شناسه";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.Width = 69;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "عنوان";
            this.Title.Name = "Title";
            this.Title.Width = 64;
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Format = "#,0 تومان";
            dataGridViewCellStyle9.NullValue = "0";
            this.Cost.DefaultCellStyle = dataGridViewCellStyle9;
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle10.NullValue = "[سیستم]";
            this.CreatedAt.DefaultCellStyle = dataGridViewCellStyle10;
            this.CreatedAt.HeaderText = "تاریخ ثبت";
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.ReadOnly = true;
            this.CreatedAt.Width = 84;
            // 
            // UpdatedAt
            // 
            this.UpdatedAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UpdatedAt.DataPropertyName = "UpdatedAt";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle11.NullValue = "[سیستم]";
            this.UpdatedAt.DefaultCellStyle = dataGridViewCellStyle11;
            this.UpdatedAt.HeaderText = "آخرین ویرایش";
            this.UpdatedAt.Name = "UpdatedAt";
            this.UpdatedAt.ReadOnly = true;
            this.UpdatedAt.Width = 105;
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
            this.BtnActionCurrentUser.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.BtnActionCurrentUser.Location = new System.Drawing.Point(4, 462);
            this.BtnActionCurrentUser.Name = "BtnActionCurrentUser";
            this.BtnActionCurrentUser.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnActionCurrentUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnActionCurrentUser.Size = new System.Drawing.Size(749, 37);
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
            this.btnDeleteCurrentRequest.Size = new System.Drawing.Size(52, 26);
            this.btnDeleteCurrentRequest.Text = "حذف";
            // 
            // btnDeleteAllRequests
            // 
            this.btnDeleteAllRequests.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDeleteAllRequests.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDeleteAllRequests.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDeleteAllRequests.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteAllRequests.Name = "btnDeleteAllRequests";
            this.btnDeleteAllRequests.Size = new System.Drawing.Size(68, 26);
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
            this.panelLeft.Controls.Add(this.panelPayment);
            this.panelLeft.Controls.Add(this.panelDetails);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(9, 10);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelLeft.Size = new System.Drawing.Size(765, 588);
            this.panelLeft.TabIndex = 17;
            // 
            // panelFactor
            // 
            this.panelFactor.Controls.Add(this.dgCarRequests);
            this.panelFactor.Controls.Add(this.BtnActionCurrentUser);
            this.panelFactor.Controls.Add(this.labelTittle);
            this.panelFactor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFactor.Location = new System.Drawing.Point(4, 42);
            this.panelFactor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelFactor.Name = "panelFactor";
            this.panelFactor.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelFactor.Size = new System.Drawing.Size(757, 504);
            this.panelFactor.TabIndex = 20;
            // 
            // labelTittle
            // 
            this.labelTittle.BackColor = System.Drawing.SystemColors.Window;
            this.labelTittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTittle.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelTittle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTittle.Location = new System.Drawing.Point(4, 5);
            this.labelTittle.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.labelTittle.Name = "labelTittle";
            this.labelTittle.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.labelTittle.Size = new System.Drawing.Size(749, 44);
            this.labelTittle.TabIndex = 17;
            this.labelTittle.Text = "فهرست و هزینه ها";
            this.labelTittle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panelPayment
            // 
            this.panelPayment.BackColor = System.Drawing.Color.Beige;
            this.panelPayment.Controls.Add(this.cbIsReleased);
            this.panelPayment.Controls.Add(this.cbIsRepaired);
            this.panelPayment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPayment.Location = new System.Drawing.Point(4, 546);
            this.panelPayment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelPayment.Name = "panelPayment";
            this.panelPayment.Size = new System.Drawing.Size(757, 37);
            this.panelPayment.TabIndex = 20;
            // 
            // cbIsReleased
            // 
            this.cbIsReleased.BackColor = System.Drawing.Color.Beige;
            this.cbIsReleased.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbIsReleased.ForeColor = System.Drawing.Color.SeaGreen;
            this.cbIsReleased.Location = new System.Drawing.Point(353, 0);
            this.cbIsReleased.Margin = new System.Windows.Forms.Padding(0);
            this.cbIsReleased.Name = "cbIsReleased";
            this.cbIsReleased.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbIsReleased.Size = new System.Drawing.Size(209, 37);
            this.cbIsReleased.TabIndex = 10;
            this.cbIsReleased.Text = "ترخیص و تحویل خودرو";
            this.cbIsReleased.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbIsReleased.UseVisualStyleBackColor = false;
            // 
            // cbIsRepaired
            // 
            this.cbIsRepaired.BackColor = System.Drawing.Color.Beige;
            this.cbIsRepaired.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbIsRepaired.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbIsRepaired.Location = new System.Drawing.Point(562, 0);
            this.cbIsRepaired.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbIsRepaired.Name = "cbIsRepaired";
            this.cbIsRepaired.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbIsRepaired.Size = new System.Drawing.Size(195, 37);
            this.cbIsRepaired.TabIndex = 19;
            this.cbIsRepaired.Text = "پایان تعمیرات";
            this.cbIsRepaired.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbIsRepaired.UseVisualStyleBackColor = false;
            // 
            // panelDetails
            // 
            this.panelDetails.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelDetails.Controls.Add(this.dateReceptionAt);
            this.panelDetails.Controls.Add(this.label1);
            this.panelDetails.Controls.Add(this.inputMileage);
            this.panelDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDetails.Location = new System.Drawing.Point(4, 5);
            this.panelDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(757, 37);
            this.panelDetails.TabIndex = 21;
            // 
            // dateReceptionAt
            // 
            this.dateReceptionAt.Location = new System.Drawing.Point(4, 4);
            this.dateReceptionAt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateReceptionAt.Name = "dateReceptionAt";
            this.dateReceptionAt.Size = new System.Drawing.Size(176, 28);
            this.dateReceptionAt.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 7);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "تاریخ پذیرش:";
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelRight.Controls.Add(this.inputBrand);
            this.panelRight.Controls.Add(this.btnCarReception);
            this.panelRight.Controls.Add(this.label2);
            this.panelRight.Controls.Add(this.label4);
            this.panelRight.Controls.Add(this.carIdControl);
            this.panelRight.Controls.Add(this.inputUserCardId);
            this.panelRight.Controls.Add(this.inputFullName);
            this.panelRight.Controls.Add(this.inputPhoneNumber);
            this.panelRight.Controls.Add(this.inputColor);
            this.panelRight.Controls.Add(this.inputTip);
            this.panelRight.Controls.Add(this.inputModel);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(774, 10);
            this.panelRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(281, 588);
            this.panelRight.TabIndex = 18;
            // 
            // btnCarReception
            // 
            this.btnCarReception.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCarReception.BackgroundImage = global::AutoLedger.App.Properties.Resources.checklist;
            this.btnCarReception.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCarReception.FlatAppearance.BorderSize = 0;
            this.btnCarReception.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarReception.Location = new System.Drawing.Point(182, 0);
            this.btnCarReception.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCarReception.Name = "btnCarReception";
            this.btnCarReception.Size = new System.Drawing.Size(88, 90);
            this.btnCarReception.TabIndex = 2;
            this.btnCarReception.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(14, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "فرم پذیرش خودرو";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(31, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 48);
            this.label4.TabIndex = 17;
            this.label4.Text = "آیرون تیونینگ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelBottom.Controls.Add(this.btnBack);
            this.panelBottom.Controls.Add(this.btnSubmit);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(9, 598);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1046, 53);
            this.panelBottom.TabIndex = 141;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Location = new System.Drawing.Point(765, 7);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 41);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "لغو";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // inputMileage
            // 
            this.inputMileage.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.inputMileage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputMileage.BackColor = System.Drawing.SystemColors.Window;
            this.inputMileage.BorderColor = System.Drawing.Color.LightGray;
            this.inputMileage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputMileage.ForeColor = System.Drawing.Color.Black;
            this.inputMileage.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.inputMileage.Icon = global::AutoLedger.App.Properties.Resources.speed_128;
            this.inputMileage.Location = new System.Drawing.Point(578, 4);
            this.inputMileage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputMileage.Name = "inputMileage";
            this.inputMileage.NumbersOnly = true;
            this.inputMileage.Placeholder = "کارکرد فعلی (کیلومتر)";
            this.inputMileage.PlaceholderColor = System.Drawing.SystemColors.Desktop;
            this.inputMileage.Size = new System.Drawing.Size(175, 28);
            this.inputMileage.TabIndex = 5;
            this.inputMileage.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // carIdControl
            // 
            this.carIdControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.carIdControl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.carIdControl.Enabled = false;
            this.carIdControl.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carIdControl.Location = new System.Drawing.Point(7, 75);
            this.carIdControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.carIdControl.Name = "carIdControl";
            this.carIdControl.Size = new System.Drawing.Size(263, 95);
            this.carIdControl.TabIndex = 1;
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
            this.inputUserCardId.Location = new System.Drawing.Point(14, 404);
            this.inputUserCardId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputUserCardId.MaxLength = 10;
            this.inputUserCardId.Name = "inputUserCardId";
            this.inputUserCardId.Placeholder = "کد ملی";
            this.inputUserCardId.PlaceholderColor = System.Drawing.Color.Black;
            this.inputUserCardId.Size = new System.Drawing.Size(256, 39);
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
            this.inputFullName.Location = new System.Drawing.Point(14, 356);
            this.inputFullName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputFullName.MaxLength = 150;
            this.inputFullName.Name = "inputFullName";
            this.inputFullName.Placeholder = "نام و نام خانوادگی";
            this.inputFullName.PlaceholderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inputFullName.Size = new System.Drawing.Size(256, 39);
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
            this.inputPhoneNumber.Location = new System.Drawing.Point(14, 451);
            this.inputPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputPhoneNumber.MaxLength = 15;
            this.inputPhoneNumber.Name = "inputPhoneNumber";
            this.inputPhoneNumber.Placeholder = "تلفن همراه";
            this.inputPhoneNumber.PlaceholderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inputPhoneNumber.Size = new System.Drawing.Size(256, 39);
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
            this.inputColor.Location = new System.Drawing.Point(58, 247);
            this.inputColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputColor.MaxLength = 30;
            this.inputColor.Name = "inputColor";
            this.inputColor.Placeholder = "رنگ";
            this.inputColor.PlaceholderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inputColor.Size = new System.Drawing.Size(205, 39);
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
            this.inputTip.Location = new System.Drawing.Point(58, 294);
            this.inputTip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputTip.MaxLength = 100;
            this.inputTip.Name = "inputTip";
            this.inputTip.Placeholder = "تیپ";
            this.inputTip.PlaceholderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inputTip.Size = new System.Drawing.Size(205, 39);
            this.inputTip.TabIndex = 4;
            this.inputTip.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.inputBrand.Location = new System.Drawing.Point(58, 154);
            this.inputBrand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputBrand.MaxLength = 50;
            this.inputBrand.Name = "inputBrand";
            this.inputBrand.Placeholder = "برند";
            this.inputBrand.PlaceholderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inputBrand.Size = new System.Drawing.Size(205, 39);
            this.inputBrand.TabIndex = 2;
            this.inputBrand.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.inputModel.Location = new System.Drawing.Point(58, 200);
            this.inputModel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputModel.MaxLength = 4;
            this.inputModel.Name = "inputModel";
            this.inputModel.NumbersOnly = true;
            this.inputModel.Placeholder = "مدل";
            this.inputModel.PlaceholderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inputModel.Size = new System.Drawing.Size(205, 39);
            this.inputModel.TabIndex = 2;
            this.inputModel.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSubmit.BaseBackColor = System.Drawing.Color.DarkGreen;
            this.btnSubmit.BorderColor = System.Drawing.Color.Gray;
            this.btnSubmit.FlatAppearance.BorderSize = 6;
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.HoverBackColor = System.Drawing.Color.LightGray;
            this.btnSubmit.Icon = global::AutoLedger.App.Properties.Resources.approval_128;
            this.btnSubmit.IconSize = 25;
            this.btnSubmit.Location = new System.Drawing.Point(857, 4);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.PressedBackColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSubmit.Size = new System.Drawing.Size(178, 45);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "ثبت و تایید اطلاعات";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // CarReceptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1064, 661);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelBottom);
            this.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CarReceptionForm";
            this.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
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
        private Panel panelDetails;
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