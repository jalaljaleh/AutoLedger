// CarReceptionExpenseForm.Designer.cs
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using AutoLedger.App.Controls;

namespace AutoLedger.App.Forms
{
    partial class CarReceptionExpenseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            var dataGridViewCellStyle1 = new DataGridViewCellStyle();
            var dataGridViewCellStyle2 = new DataGridViewCellStyle();
            var dataGridViewCellStyle3 = new DataGridViewCellStyle();
            var dataGridViewCellStyle4 = new DataGridViewCellStyle();
            var dataGridViewCellStyle5 = new DataGridViewCellStyle();
            var dataGridViewCellStyle6 = new DataGridViewCellStyle();
            var dataGridViewCellStyle7 = new DataGridViewCellStyle();
            var dataGridViewCellStyle8 = new DataGridViewCellStyle();
            var dataGridViewCellStyle9 = new DataGridViewCellStyle();
            var resources = new ComponentResourceManager(typeof(CarReceptionExpenseForm));

            // Instantiate controls
            this.panelLeft = new Panel();
            this.panelFactor = new Panel();
            this.paneldatagridExpenses = new Panel();
            this.dgCarExpenses = new DataGridView();
            this.paneldatagirdReeuests = new Panel();
            this.dgCarRequests = new DataGridView();
            this.BtnActionCurrentUser = new ToolStrip();
            this.btnDeleteCurrentRequest = new ToolStripButton();
            this.btnDeleteAllRequests = new ToolStripButton();
            this.labelTotalCost = new ToolStripLabel();
            this.panelTop = new Panel();
            this.inputReceptionId = new ModernTextBox();
            this.label1 = new Label();
            this.panelBottom = new Panel();
            this.btnCancel = new ModernButton();
            this.btnSubmit = new ModernButton();
            this.labelTittle = new Label();

            // Columns for requests grid (reused names from original)
            this.dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();

            // Columns for expenses grid
            this.Index = new DataGridViewTextBoxColumn();
            this.Id = new DataGridViewTextBoxColumn();
            this.Title = new DataGridViewTextBoxColumn();
            this.Description = new DataGridViewTextBoxColumn();
            this.Amount = new DataGridViewTextBoxColumn();
            this.CreatedAt = new DataGridViewTextBoxColumn();
            this.UpdatedAt = new DataGridViewTextBoxColumn();

            // 
            // dgCarRequests
            // 
            ((ISupportInitialize)(this.dgCarRequests)).BeginInit();
            this.dgCarRequests.AllowUserToAddRows = false;
            this.dgCarRequests.AllowUserToDeleteRows = false;
            this.dgCarRequests.AllowUserToResizeColumns = false;
            this.dgCarRequests.AllowUserToResizeRows = false;
            this.dgCarRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgCarRequests.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dgCarRequests.BackgroundColor = Color.DarkKhaki;
            this.dgCarRequests.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.dgCarRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCarRequests.Columns.AddRange(new DataGridViewColumn[] {
                this.dataGridViewTextBoxColumn1,
                this.dataGridViewTextBoxColumn3,
                this.dataGridViewTextBoxColumn4,
                this.dataGridViewTextBoxColumn5
            });
            this.dgCarRequests.Dock = DockStyle.Fill;
            this.dgCarRequests.EditMode = DataGridViewEditMode.EditOnEnter;
            this.dgCarRequests.EnableHeadersVisualStyles = false;
            this.dgCarRequests.GridColor = Color.DimGray;
            this.dgCarRequests.Location = new Point(5, 5);
            this.dgCarRequests.Margin = new Padding(5);
            this.dgCarRequests.MultiSelect = false;
            this.dgCarRequests.Name = "dgCarRequests";
            this.dgCarRequests.ReadOnly = true;
            this.dgCarRequests.RightToLeft = RightToLeft.Yes;

            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Vazirmatn", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            this.dgCarRequests.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;

            this.dgCarRequests.RowHeadersVisible = false;
            this.dgCarRequests.RowHeadersWidth = 50;
            this.dgCarRequests.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgCarRequests.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgCarRequests.RowTemplate.DefaultCellStyle.Padding = new Padding(5);
            this.dgCarRequests.RowTemplate.DividerHeight = 1;
            this.dgCarRequests.RowTemplate.Height = 30;
            this.dgCarRequests.RowTemplate.Resizable = DataGridViewTriState.False;
            this.dgCarRequests.SelectionMode = DataGridViewSelectionMode.CellSelect;
            this.dgCarRequests.Size = new Size(877, 177);
            this.dgCarRequests.StandardTab = true;
            this.dgCarRequests.TabIndex = 18;
            ((ISupportInitialize)(this.dgCarRequests)).EndInit();

            // dataGridViewTextBoxColumn1
            this.dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.BackColor = Color.MistyRose;
            dataGridViewCellStyle1.NullValue = "[سیستم]";
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn1.HeaderText = "R";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.False;

            // dataGridViewTextBoxColumn3
            this.dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn3.HeaderText = "عنوان";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;

            // dataGridViewTextBoxColumn4
            this.dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn4.HeaderText = "توضیحات";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;

            // dataGridViewTextBoxColumn5
            this.dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Cost";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.Format = "#,0 تومان";
            dataGridViewCellStyle2.NullValue = "0";
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn5.FillWeight = 200F;
            this.dataGridViewTextBoxColumn5.HeaderText = "هزینه";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;

            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = Color.Transparent;
            this.panelLeft.Controls.Add(this.panelFactor);
            this.panelLeft.Controls.Add(this.panelBottom);
            this.panelLeft.Dock = DockStyle.Fill;
            this.panelLeft.Location = new Point(0, 0);
            this.panelLeft.Margin = new Padding(0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new Padding(5);
            this.panelLeft.Size = new Size(907, 657);
            this.panelLeft.TabIndex = 18;

            // 
            // panelFactor
            // 
            this.panelFactor.Controls.Add(this.paneldatagridExpenses);
            this.panelFactor.Controls.Add(this.paneldatagirdReeuests);
            this.panelFactor.Controls.Add(this.BtnActionCurrentUser);
            this.panelFactor.Controls.Add(this.panelTop);
            this.panelFactor.Dock = DockStyle.Fill;
            this.panelFactor.Location = new Point(5, 5);
            this.panelFactor.Margin = new Padding(0);
            this.panelFactor.Name = "panelFactor";
            this.panelFactor.Padding = new Padding(5);
            this.panelFactor.Size = new Size(897, 594);
            this.panelFactor.TabIndex = 20;

            // 
            // paneldatagridExpenses
            // 
            this.paneldatagridExpenses.Controls.Add(this.dgCarExpenses);
            this.paneldatagridExpenses.Dock = DockStyle.Fill;
            this.paneldatagridExpenses.Location = new Point(5, 240);
            this.paneldatagridExpenses.Name = "paneldatagridExpenses";
            this.paneldatagridExpenses.Padding = new Padding(5);
            this.paneldatagridExpenses.Size = new Size(887, 320);
            this.paneldatagridExpenses.TabIndex = 19;

            // 
            // dgCarExpenses
            // 
            ((ISupportInitialize)(this.dgCarExpenses)).BeginInit();
            this.dgCarExpenses.AllowUserToOrderColumns = true;
            this.dgCarExpenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgCarExpenses.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dgCarExpenses.BackgroundColor = Color.Salmon;
            this.dgCarExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCarExpenses.Columns.AddRange(new DataGridViewColumn[] {
                this.Index,
                this.Id,
                this.Title,
                this.Description,
                this.Amount,
                this.CreatedAt,
                this.UpdatedAt
            });
            this.dgCarExpenses.Dock = DockStyle.Fill;
            this.dgCarExpenses.EditMode = DataGridViewEditMode.EditOnEnter;
            this.dgCarExpenses.GridColor = Color.DimGray;
            this.dgCarExpenses.Location = new Point(5, 5);
            this.dgCarExpenses.Margin = new Padding(10);
            this.dgCarExpenses.MultiSelect = false;
            this.dgCarExpenses.Name = "dgCarExpenses";
            this.dgCarExpenses.RightToLeft = RightToLeft.Yes;
            this.dgCarExpenses.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Vazirmatn", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            this.dgCarExpenses.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;

            this.dgCarExpenses.RowHeadersVisible = false;
            this.dgCarExpenses.RowHeadersWidth = 50;
            this.dgCarExpenses.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgCarExpenses.RowTemplate.DefaultCellStyle.Padding = new Padding(5);
            this.dgCarExpenses.RowTemplate.DividerHeight = 1;
            this.dgCarExpenses.RowTemplate.Height = 50;
            this.dgCarExpenses.RowTemplate.Resizable = DataGridViewTriState.False;
            this.dgCarExpenses.SelectionMode = DataGridViewSelectionMode.CellSelect;
            this.dgCarExpenses.Size = new Size(877, 310);
            this.dgCarExpenses.StandardTab = true;
            this.dgCarExpenses.TabIndex = 10;
            ((ISupportInitialize)(this.dgCarExpenses)).EndInit();

            // 
            // paneldatagirdReeuests
            // 
            this.paneldatagirdReeuests.Controls.Add(this.dgCarRequests);
            this.paneldatagirdReeuests.Dock = DockStyle.Top;
            this.paneldatagirdReeuests.Location = new Point(5, 53);
            this.paneldatagirdReeuests.Name = "paneldatagirdReeuests";
            this.paneldatagirdReeuests.Padding = new Padding(5);
            this.paneldatagirdReeuests.Size = new Size(887, 187);
            this.paneldatagirdReeuests.TabIndex = 20;

            // 
            // BtnActionCurrentUser (ToolStrip)
            // 
            this.BtnActionCurrentUser.BackColor = SystemColors.ButtonHighlight;
            this.BtnActionCurrentUser.Dock = DockStyle.Bottom;
            this.BtnActionCurrentUser.Font = new Font("Vazirmatn", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.BtnActionCurrentUser.GripStyle = ToolStripGripStyle.Hidden;
            this.BtnActionCurrentUser.ImageScalingSize = new Size(80, 80);
            this.BtnActionCurrentUser.Items.AddRange(new ToolStripItem[] {
                this.btnDeleteCurrentRequest,
                this.btnDeleteAllRequests,
                this.labelTotalCost
            });
            this.BtnActionCurrentUser.Location = new Point(5, 560);
            this.BtnActionCurrentUser.Name = "BtnActionCurrentUser";
            this.BtnActionCurrentUser.Padding = new Padding(0);
            this.BtnActionCurrentUser.RightToLeft = RightToLeft.Yes;
            this.BtnActionCurrentUser.Size = new Size(887, 29);
            this.BtnActionCurrentUser.TabIndex = 16;
            this.BtnActionCurrentUser.Text = "toolStrip1";

            // btnDeleteCurrentRequest
            this.btnDeleteCurrentRequest.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.btnDeleteCurrentRequest.Font = new Font("Vazirmatn", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 178);
            this.btnDeleteCurrentRequest.ForeColor = Color.DarkRed;
            this.btnDeleteCurrentRequest.Image = ((Image)(resources.GetObject("btnDeleteCurrentRequest.Image")));
            this.btnDeleteCurrentRequest.ImageTransparentColor = Color.Magenta;
            this.btnDeleteCurrentRequest.Name = "btnDeleteCurrentRequest";
            this.btnDeleteCurrentRequest.Padding = new Padding(0, 0, 10, 0);
            this.btnDeleteCurrentRequest.Size = new Size(52, 26);
            this.btnDeleteCurrentRequest.Text = "حذف";

            // btnDeleteAllRequests
            this.btnDeleteAllRequests.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.btnDeleteAllRequests.Font = new Font("Vazirmatn", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 178);
            this.btnDeleteAllRequests.ForeColor = Color.DarkRed;
            this.btnDeleteAllRequests.Name = "btnDeleteAllRequests";
            this.btnDeleteAllRequests.Size = new Size(68, 26);
            this.btnDeleteAllRequests.Text = "حذف همه";

            // labelTotalCost
            this.labelTotalCost.Alignment = ToolStripItemAlignment.Right;
            this.labelTotalCost.Font = new Font("Vazirmatn", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.labelTotalCost.Name = "labelTotalCost";
            this.labelTotalCost.RightToLeft = RightToLeft.No;
            this.labelTotalCost.Size = new Size(92, 26);
            this.labelTotalCost.Text = "[جمع کل هزینه]";

            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.inputReceptionId);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = DockStyle.Top;
            this.panelTop.Location = new Point(5, 5);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new Size(887, 48);
            this.panelTop.TabIndex = 19;

            // inputReceptionId
            this.inputReceptionId.AccentColor = Color.FromArgb(0, 120, 215);
            this.inputReceptionId.BackColor = Color.MistyRose;
            this.inputReceptionId.BorderColor = Color.FromArgb(200, 200, 200);
            this.inputReceptionId.CornerRadius = 2;
            this.inputReceptionId.Cursor = Cursors.IBeam;
            this.inputReceptionId.Enabled = false;
            this.inputReceptionId.ForeColor = Color.FromArgb(30, 30, 30);
            this.inputReceptionId.HoverColor = Color.FromArgb(230, 230, 230);
            this.inputReceptionId.Icon = null;
            this.inputReceptionId.Location = new Point(6, 9);
            this.inputReceptionId.Name = "inputReceptionId";
            this.inputReceptionId.Placeholder = "[شماره فاکتور]";
            this.inputReceptionId.PlaceholderColor = Color.Black;
            this.inputReceptionId.ShowClearButton = false;
            this.inputReceptionId.Size = new Size(116, 31);
            this.inputReceptionId.TabIndex = 11;
            this.inputReceptionId.TextAlignment = HorizontalAlignment.Center;

            // label1
            this.label1.Dock = DockStyle.Right;
            this.label1.Font = new Font("Vazirmatn SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(518, 0);
            this.label1.Name = "label1";
            this.label1.Size = new Size(369, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "فرم ثبت هزینه های تعمیر  تقویت خودرو";
            this.label1.TextAlign = ContentAlignment.MiddleRight;

            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = SystemColors.ControlLightLight;
            this.panelBottom.Controls.Add(this.btnCancel);
            this.panelBottom.Controls.Add(this.btnSubmit);
            this.panelBottom.Dock = DockStyle.Bottom;
            this.panelBottom.Location = new Point(5, 599);
            this.panelBottom.Margin = new Padding(3, 4, 3, 4);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new Size(897, 53);
            this.panelBottom.TabIndex = 142;

            // btnCancel
            this.btnCancel.BackColor = Color.FromArgb(0, 120, 212);
            this.btnCancel.BaseBackColor = Color.MistyRose;
            this.btnCancel.BorderColor = Color.Transparent;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.Font = new Font("Vazirmatn", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btnCancel.ForeColor = SystemColors.WindowText;
            this.btnCancel.HoverBackColor = Color.FromArgb(10, 132, 255);
            this.btnCancel.Icon = global::AutoLedger.App.Properties.Resources.info_128;
            this.btnCancel.IconSize = 25;
            this.btnCancel.Location = new Point(608, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PressedBackColor = Color.FromArgb(0, 102, 204);
            this.btnCancel.Size = new Size(92, 40);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "لغو";
            this.btnCancel.UseVisualStyleBackColor = false;

            // btnSubmit
            this.btnSubmit.BackColor = Color.FromArgb(0, 120, 212);
            this.btnSubmit.BaseBackColor = Color.Green;
            this.btnSubmit.BorderColor = Color.Transparent;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = FlatStyle.Flat;
            this.btnSubmit.Font = new Font("Vazirmatn", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btnSubmit.ForeColor = Color.White;
            this.btnSubmit.HoverBackColor = Color.FromArgb(10, 132, 255);
            this.btnSubmit.Icon = global::AutoLedger.App.Properties.Resources.approval_128;
            this.btnSubmit.IconSize = 25;
            this.btnSubmit.Location = new Point(706, 6);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.PressedBackColor = Color.FromArgb(0, 102, 204);
            this.btnSubmit.Size = new Size(181, 40);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "ثبت مخارج خودرو";
            this.btnSubmit.UseVisualStyleBackColor = false;

            // labelTittle
            this.labelTittle.BackColor = Color.Transparent;
            this.labelTittle.Font = new Font("Vazirmatn", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 178);
            this.labelTittle.ForeColor = SystemColors.ActiveCaptionText;
            this.labelTittle.Location = new Point(429, 1);
            this.labelTittle.Margin = new Padding(10, 17, 10, 17);
            this.labelTittle.Name = "labelTittle";
            this.labelTittle.Padding = new Padding(2, 3, 2, 3);
            this.labelTittle.Size = new Size(454, 35);
            this.labelTittle.TabIndex = 17;
            this.labelTittle.Text = "فهرست خدمات و هزینه ها";
            this.labelTittle.TextAlign = ContentAlignment.TopRight;

            // Index column
            this.Index.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.BackColor = Color.MistyRose;
            dataGridViewCellStyle4.NullValue = "[سیستم]";
            this.Index.DefaultCellStyle = dataGridViewCellStyle4;
            this.Index.HeaderText = "R";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.Resizable = DataGridViewTriState.False;

            // Id column
            this.Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.Id.DataPropertyName = "Id";
            dataGridViewCellStyle5.BackColor = Color.MistyRose;
            dataGridViewCellStyle5.NullValue = "[سیستم]";
            this.Id.DefaultCellStyle = dataGridViewCellStyle5;
            this.Id.HeaderText = "شناسه";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = DataGridViewTriState.False;

            // Title column
            this.Title.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "بابت";
            this.Title.Name = "Title";

            // Description column
            this.Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "شرح";
            this.Description.Name = "Description";

            // Amount column
            this.Amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.Amount.DataPropertyName = "Amount";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.Format = "#,0 تومان";
            dataGridViewCellStyle6.NullValue = "0";
            this.Amount.DefaultCellStyle = dataGridViewCellStyle6;
            this.Amount.FillWeight = 200F;
            this.Amount.HeaderText = "مبلغ";
            this.Amount.MinimumWidth = 150;
            this.Amount.Name = "Amount";

            // CreatedAt column
            this.CreatedAt.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.CreatedAt.DataPropertyName = "CreatedAt";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.MistyRose;
            dataGridViewCellStyle7.Font = new Font("Vazirmatn", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.NullValue = "[سیستم]";
            this.CreatedAt.DefaultCellStyle = dataGridViewCellStyle7;
            this.CreatedAt.HeaderText = "تاریخ ثبت";
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.ReadOnly = true;

            // UpdatedAt column
            this.UpdatedAt.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.UpdatedAt.DataPropertyName = "UpdatedAt";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.MistyRose;
            dataGridViewCellStyle8.Font = new Font("Vazirmatn", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.NullValue = "[سیستم]";
            this.UpdatedAt.DefaultCellStyle = dataGridViewCellStyle8;
            this.UpdatedAt.HeaderText = "آخرین ویرایش";
            this.UpdatedAt.Name = "UpdatedAt";
            this.UpdatedAt.ReadOnly = true;

            // 
            // CarReceptionExpenseForm (this)
            // 
            this.AutoScaleDimensions = new SizeF(7F, 22F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = SystemColors.ButtonHighlight;
            this.ClientSize = new Size(907, 657);
            this.ControlBox = false;
            this.Controls.Add(this.panelLeft);
            this.Font = new Font("Vazirmatn", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Margin = new Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "CarReceptionExpenseForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "فرم مخارج خودروی پذیرفته شده";
            this.TopMost = true;
        }

        #endregion

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

        // Designer fields (controls)
        private Panel panelLeft;
        private Panel panelFactor;
        private Panel paneldatagridExpenses;
        private Panel paneldatagirdReeuests;
        private Panel panelTop;
        private Panel panelBottom;
        private DataGridView dgCarExpenses;
        private DataGridView dgCarRequests;
        private ToolStrip BtnActionCurrentUser;
        private ToolStripButton btnDeleteCurrentRequest;
        private ToolStripButton btnDeleteAllRequests;
        private ToolStripLabel labelTotalCost;
        private Label labelTittle;
        private ModernButton btnSubmit;
        private ModernButton btnCancel;
        private Label label1;
        private ModernTextBox inputReceptionId;

        // Columns for requests grid
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;

        // Columns for expenses grid
        private DataGridViewTextBoxColumn Index;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn CreatedAt;
        private DataGridViewTextBoxColumn UpdatedAt;
    }
}
