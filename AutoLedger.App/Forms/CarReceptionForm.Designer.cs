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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarReceptionForm));
            this.dgCarRequests = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnActionCurrentUser = new System.Windows.Forms.ToolStrip();
            this.btnDeleteCurrentRequest = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteAllRequests = new System.Windows.Forms.ToolStripButton();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.labelTotalCost = new System.Windows.Forms.Label();
            this.labelTittle = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnBackToUserDetails = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.carIdControl2 = new AutoLedger.App.Controls.CarIdControl();
            this.modernTextBox6 = new AutoLedger.App.Controls.ModernTextBox();
            this.modernTextBox1 = new AutoLedger.App.Controls.ModernTextBox();
            this.modernTextBox4 = new AutoLedger.App.Controls.ModernTextBox();
            this.inputColor = new AutoLedger.App.Controls.ModernTextBox();
            this.inputTip = new AutoLedger.App.Controls.ModernTextBox();
            this.inputBrand = new AutoLedger.App.Controls.ModernTextBox();
            this.inputUsage = new AutoLedger.App.Controls.ModernTextBox();
            this.inputModel = new AutoLedger.App.Controls.ModernTextBox();
            this.modernButton1 = new AutoLedger.App.Controls.ModernButton();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panelFactor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgCarRequests)).BeginInit();
            this.BtnActionCurrentUser.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.panelFactor.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgCarRequests
            // 
            this.dgCarRequests.AllowUserToOrderColumns = true;
            this.dgCarRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCarRequests.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgCarRequests.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgCarRequests.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgCarRequests.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgCarRequests.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgCarRequests.ColumnHeadersHeight = 35;
            this.dgCarRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.Title,
            this.Description,
            this.Cost});
            this.dgCarRequests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCarRequests.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgCarRequests.GridColor = System.Drawing.Color.DimGray;
            this.dgCarRequests.Location = new System.Drawing.Point(0, 48);
            this.dgCarRequests.Margin = new System.Windows.Forms.Padding(5);
            this.dgCarRequests.MultiSelect = false;
            this.dgCarRequests.Name = "dgCarRequests";
            this.dgCarRequests.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgCarRequests.RowHeadersVisible = false;
            this.dgCarRequests.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgCarRequests.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgCarRequests.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dgCarRequests.RowTemplate.DividerHeight = 1;
            this.dgCarRequests.RowTemplate.Height = 40;
            this.dgCarRequests.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCarRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgCarRequests.Size = new System.Drawing.Size(837, 395);
            this.dgCarRequests.StandardTab = true;
            this.dgCarRequests.TabIndex = 15;
            // 
            // Index
            // 
            this.Index.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Index.HeaderText = "R";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Index.Width = 32;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Title.HeaderText = "عنوان";
            this.Title.Name = "Title";
            this.Title.Width = 70;
            // 
            // Description
            // 
            this.Description.HeaderText = "توضیحات";
            this.Description.Name = "Description";
            // 
            // Cost
            // 
            this.Cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
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
            // BtnActionCurrentUser
            // 
            this.BtnActionCurrentUser.BackColor = System.Drawing.Color.GhostWhite;
            this.BtnActionCurrentUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnActionCurrentUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnActionCurrentUser.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.BtnActionCurrentUser.ImageScalingSize = new System.Drawing.Size(80, 80);
            this.BtnActionCurrentUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDeleteCurrentRequest,
            this.btnDeleteAllRequests});
            this.BtnActionCurrentUser.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.BtnActionCurrentUser.Location = new System.Drawing.Point(0, 443);
            this.BtnActionCurrentUser.Name = "BtnActionCurrentUser";
            this.BtnActionCurrentUser.Padding = new System.Windows.Forms.Padding(3);
            this.BtnActionCurrentUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnActionCurrentUser.Size = new System.Drawing.Size(837, 30);
            this.BtnActionCurrentUser.TabIndex = 16;
            this.BtnActionCurrentUser.Text = "toolStrip1";
            // 
            // btnDeleteCurrentRequest
            // 
            this.btnDeleteCurrentRequest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDeleteCurrentRequest.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDeleteCurrentRequest.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCurrentRequest.Image")));
            this.btnDeleteCurrentRequest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteCurrentRequest.Name = "btnDeleteCurrentRequest";
            this.btnDeleteCurrentRequest.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnDeleteCurrentRequest.Size = new System.Drawing.Size(50, 21);
            this.btnDeleteCurrentRequest.Text = "حذف";
            // 
            // btnDeleteAllRequests
            // 
            this.btnDeleteAllRequests.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDeleteAllRequests.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDeleteAllRequests.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteAllRequests.Name = "btnDeleteAllRequests";
            this.btnDeleteAllRequests.Size = new System.Drawing.Size(68, 21);
            this.btnDeleteAllRequests.Text = "حذف همه";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Transparent;
            this.panelLeft.Controls.Add(this.panelFactor);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(5);
            this.panelLeft.Size = new System.Drawing.Size(847, 861);
            this.panelLeft.TabIndex = 17;
            // 
            // labelTotalCost
            // 
            this.labelTotalCost.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalCost.Location = new System.Drawing.Point(0, 6);
            this.labelTotalCost.Name = "labelTotalCost";
            this.labelTotalCost.Size = new System.Drawing.Size(304, 36);
            this.labelTotalCost.TabIndex = 19;
            this.labelTotalCost.Text = "[جمع کل 0 تومان]";
            this.labelTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTittle
            // 
            this.labelTittle.BackColor = System.Drawing.SystemColors.Window;
            this.labelTittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTittle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelTittle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTittle.Location = new System.Drawing.Point(0, 0);
            this.labelTittle.Margin = new System.Windows.Forms.Padding(10);
            this.labelTittle.Name = "labelTittle";
            this.labelTittle.Padding = new System.Windows.Forms.Padding(10);
            this.labelTittle.Size = new System.Drawing.Size(837, 48);
            this.labelTittle.TabIndex = 17;
            this.labelTittle.Text = "فهرست و هزینه ها";
            this.labelTittle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.SystemColors.Window;
            this.panelRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRight.Controls.Add(this.panelBottom);
            this.panelRight.Controls.Add(this.label2);
            this.panelRight.Controls.Add(this.dateTimePicker2);
            this.panelRight.Controls.Add(this.label3);
            this.panelRight.Controls.Add(this.carIdControl2);
            this.panelRight.Controls.Add(this.modernTextBox6);
            this.panelRight.Controls.Add(this.modernTextBox1);
            this.panelRight.Controls.Add(this.modernTextBox4);
            this.panelRight.Controls.Add(this.inputColor);
            this.panelRight.Controls.Add(this.inputTip);
            this.panelRight.Controls.Add(this.inputBrand);
            this.panelRight.Controls.Add(this.inputUsage);
            this.panelRight.Controls.Add(this.dateTimePicker1);
            this.panelRight.Controls.Add(this.label1);
            this.panelRight.Controls.Add(this.inputModel);
            this.panelRight.Controls.Add(this.pictureBox1);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(847, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(337, 861);
            this.panelRight.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(83, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 44);
            this.label2.TabIndex = 15;
            this.label2.Text = "فرم پذیرش خودرو";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(21, 633);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // btnBackToUserDetails
            // 
            this.btnBackToUserDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBackToUserDetails.Location = new System.Drawing.Point(19, 13);
            this.btnBackToUserDetails.Name = "btnBackToUserDetails";
            this.btnBackToUserDetails.Size = new System.Drawing.Size(107, 39);
            this.btnBackToUserDetails.TabIndex = 135;
            this.btnBackToUserDetails.Text = "برگشت";
            this.btnBackToUserDetails.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 635);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "تاریخ پذیرش:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutoLedger.App.Properties.Resources.car_wash;
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 137;
            this.pictureBox1.TabStop = false;
            // 
            // carIdControl2
            // 
            this.carIdControl2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.carIdControl2.Location = new System.Drawing.Point(21, 266);
            this.carIdControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.carIdControl2.Name = "carIdControl2";
            this.carIdControl2.Size = new System.Drawing.Size(292, 70);
            this.carIdControl2.TabIndex = 136;
            // 
            // modernTextBox6
            // 
            this.modernTextBox6.BackColor = System.Drawing.Color.White;
            this.modernTextBox6.BorderColor = System.Drawing.Color.LightGray;
            this.modernTextBox6.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.modernTextBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.modernTextBox6.ForeColor = System.Drawing.Color.Black;
            this.modernTextBox6.Location = new System.Drawing.Point(19, 484);
            this.modernTextBox6.Name = "modernTextBox6";
            this.modernTextBox6.Placeholder = "کد ملی";
            this.modernTextBox6.PlaceholderColor = System.Drawing.Color.Black;
            this.modernTextBox6.Size = new System.Drawing.Size(292, 35);
            this.modernTextBox6.TabIndex = 140;
            this.modernTextBox6.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // modernTextBox1
            // 
            this.modernTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.modernTextBox1.BorderColor = System.Drawing.Color.LightGray;
            this.modernTextBox1.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.modernTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.modernTextBox1.ForeColor = System.Drawing.Color.Black;
            this.modernTextBox1.Location = new System.Drawing.Point(19, 441);
            this.modernTextBox1.Name = "modernTextBox1";
            this.modernTextBox1.Placeholder = "نام و نام خانوادگی تحویل دهنده";
            this.modernTextBox1.PlaceholderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.modernTextBox1.Size = new System.Drawing.Size(292, 35);
            this.modernTextBox1.TabIndex = 139;
            this.modernTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // modernTextBox4
            // 
            this.modernTextBox4.BackColor = System.Drawing.Color.White;
            this.modernTextBox4.BorderColor = System.Drawing.Color.LightGray;
            this.modernTextBox4.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.modernTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.modernTextBox4.ForeColor = System.Drawing.Color.Black;
            this.modernTextBox4.Location = new System.Drawing.Point(19, 527);
            this.modernTextBox4.Name = "modernTextBox4";
            this.modernTextBox4.Placeholder = "تلفن همراه";
            this.modernTextBox4.PlaceholderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.modernTextBox4.Size = new System.Drawing.Size(292, 35);
            this.modernTextBox4.TabIndex = 138;
            this.modernTextBox4.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputColor
            // 
            this.inputColor.BackColor = System.Drawing.SystemColors.Window;
            this.inputColor.BorderColor = System.Drawing.Color.LightGray;
            this.inputColor.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.inputColor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputColor.ForeColor = System.Drawing.Color.Black;
            this.inputColor.Location = new System.Drawing.Point(168, 393);
            this.inputColor.Name = "inputColor";
            this.inputColor.Placeholder = "رنگ";
            this.inputColor.PlaceholderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inputColor.Size = new System.Drawing.Size(145, 35);
            this.inputColor.TabIndex = 132;
            this.inputColor.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputTip
            // 
            this.inputTip.BackColor = System.Drawing.SystemColors.Window;
            this.inputTip.BorderColor = System.Drawing.Color.LightGray;
            this.inputTip.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.inputTip.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputTip.ForeColor = System.Drawing.Color.Black;
            this.inputTip.Location = new System.Drawing.Point(21, 344);
            this.inputTip.Name = "inputTip";
            this.inputTip.Placeholder = "تیپ";
            this.inputTip.PlaceholderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inputTip.Size = new System.Drawing.Size(145, 35);
            this.inputTip.TabIndex = 130;
            this.inputTip.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputBrand
            // 
            this.inputBrand.BackColor = System.Drawing.SystemColors.Window;
            this.inputBrand.BorderColor = System.Drawing.Color.LightGray;
            this.inputBrand.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.inputBrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputBrand.ForeColor = System.Drawing.Color.Black;
            this.inputBrand.Location = new System.Drawing.Point(168, 344);
            this.inputBrand.Name = "inputBrand";
            this.inputBrand.Placeholder = "برند";
            this.inputBrand.PlaceholderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inputBrand.Size = new System.Drawing.Size(145, 35);
            this.inputBrand.TabIndex = 129;
            this.inputBrand.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputUsage
            // 
            this.inputUsage.BackColor = System.Drawing.SystemColors.Window;
            this.inputUsage.BorderColor = System.Drawing.Color.LightGray;
            this.inputUsage.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.inputUsage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputUsage.ForeColor = System.Drawing.Color.Black;
            this.inputUsage.Location = new System.Drawing.Point(21, 576);
            this.inputUsage.Name = "inputUsage";
            this.inputUsage.Placeholder = "کارکرد فعلی (کیلومتر)";
            this.inputUsage.PlaceholderColor = System.Drawing.SystemColors.Desktop;
            this.inputUsage.Size = new System.Drawing.Size(292, 35);
            this.inputUsage.TabIndex = 13;
            this.inputUsage.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputModel
            // 
            this.inputModel.BackColor = System.Drawing.SystemColors.Window;
            this.inputModel.BorderColor = System.Drawing.Color.LightGray;
            this.inputModel.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.inputModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputModel.ForeColor = System.Drawing.Color.Black;
            this.inputModel.Location = new System.Drawing.Point(21, 393);
            this.inputModel.Name = "inputModel";
            this.inputModel.Placeholder = "مدل";
            this.inputModel.PlaceholderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inputModel.Size = new System.Drawing.Size(145, 35);
            this.inputModel.TabIndex = 131;
            this.inputModel.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // modernButton1
            // 
            this.modernButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.modernButton1.BorderColor = System.Drawing.Color.Gray;
            this.modernButton1.FlatAppearance.BorderSize = 0;
            this.modernButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.modernButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.modernButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modernButton1.ForeColor = System.Drawing.Color.White;
            this.modernButton1.HoverBackColor = System.Drawing.Color.LightGray;
            this.modernButton1.HoverBorderColor = System.Drawing.Color.Gray;
            this.modernButton1.Location = new System.Drawing.Point(147, 12);
            this.modernButton1.Name = "modernButton1";
            this.modernButton1.PressedBackColor = System.Drawing.Color.DarkGray;
            this.modernButton1.PressedBorderColor = System.Drawing.Color.Gray;
            this.modernButton1.Size = new System.Drawing.Size(177, 40);
            this.modernButton1.TabIndex = 14;
            this.modernButton1.Text = "ثبت و تایید اطلاعات";
            this.modernButton1.UseVisualStyleBackColor = false;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnBackToUserDetails);
            this.panelBottom.Controls.Add(this.modernButton1);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 796);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(335, 63);
            this.panelBottom.TabIndex = 141;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(21, 676);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker2.TabIndex = 142;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 678);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 143;
            this.label3.Text = "تاریخ ترخیص";
            // 
            // panelFactor
            // 
            this.panelFactor.Controls.Add(this.dgCarRequests);
            this.panelFactor.Controls.Add(this.labelTotalCost);
            this.panelFactor.Controls.Add(this.BtnActionCurrentUser);
            this.panelFactor.Controls.Add(this.labelTittle);
            this.panelFactor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFactor.Location = new System.Drawing.Point(5, 383);
            this.panelFactor.Name = "panelFactor";
            this.panelFactor.Size = new System.Drawing.Size(837, 473);
            this.panelFactor.TabIndex = 20;
            // 
            // CarReceptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelRight);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CarReceptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم پذیرش خودرو";
            ((System.ComponentModel.ISupportInitialize)(this.dgCarRequests)).EndInit();
            this.BtnActionCurrentUser.ResumeLayout(false);
            this.BtnActionCurrentUser.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelFactor.ResumeLayout(false);
            this.panelFactor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgCarRequests;
        private System.Windows.Forms.ToolStrip BtnActionCurrentUser;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Controls.ModernTextBox inputUsage;
        private Controls.ModernButton modernButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTittle;
        private System.Windows.Forms.ToolStripButton btnDeleteCurrentRequest;
        private System.Windows.Forms.ToolStripButton btnDeleteAllRequests;
        private Controls.ModernTextBox inputColor;
        private Controls.ModernTextBox inputTip;
        private Controls.ModernTextBox inputBrand;
        private System.Windows.Forms.Button btnBackToUserDetails;
        private Controls.CarIdControl carIdControl2;
        private Controls.ModernTextBox inputModel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Controls.ModernTextBox modernTextBox4;
        private Controls.ModernTextBox modernTextBox1;
        private Controls.ModernTextBox modernTextBox6;
        private System.Windows.Forms.Label labelTotalCost;
        private DataGridViewTextBoxColumn Index;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Cost;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private Panel panelBottom;
        private Panel panelFactor;
    }
}