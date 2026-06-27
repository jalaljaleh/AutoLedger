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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarReceptionExpenseForm));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelFactor = new System.Windows.Forms.Panel();
            this.paneldatagridExpenses = new System.Windows.Forms.Panel();
            this.dgCarExpenses = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnActionCurrentUser = new System.Windows.Forms.ToolStrip();
            this.btnDeleteCurrentRequest = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteAllRequests = new System.Windows.Forms.ToolStripButton();
            this.labelTotalCost = new System.Windows.Forms.ToolStripLabel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.inputReceptionId = new AutoLedger.App.Controls.ModernTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnCancel = new AutoLedger.App.Controls.ModernButton();
            this.btnSubmit = new AutoLedger.App.Controls.ModernButton();
            this.labelTittle = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            this.panelFactor.SuspendLayout();
            this.paneldatagridExpenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCarExpenses)).BeginInit();
            this.BtnActionCurrentUser.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Transparent;
            this.panelLeft.Controls.Add(this.panelFactor);
            this.panelLeft.Controls.Add(this.panelBottom);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(5);
            this.panelLeft.Size = new System.Drawing.Size(839, 573);
            this.panelLeft.TabIndex = 18;
            // 
            // panelFactor
            // 
            this.panelFactor.Controls.Add(this.paneldatagridExpenses);
            this.panelFactor.Controls.Add(this.BtnActionCurrentUser);
            this.panelFactor.Controls.Add(this.panelTop);
            this.panelFactor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFactor.Location = new System.Drawing.Point(5, 5);
            this.panelFactor.Margin = new System.Windows.Forms.Padding(0);
            this.panelFactor.Name = "panelFactor";
            this.panelFactor.Padding = new System.Windows.Forms.Padding(5);
            this.panelFactor.Size = new System.Drawing.Size(829, 512);
            this.panelFactor.TabIndex = 20;
            // 
            // paneldatagridExpenses
            // 
            this.paneldatagridExpenses.Controls.Add(this.dgCarExpenses);
            this.paneldatagridExpenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneldatagridExpenses.Location = new System.Drawing.Point(5, 29);
            this.paneldatagridExpenses.Name = "paneldatagridExpenses";
            this.paneldatagridExpenses.Padding = new System.Windows.Forms.Padding(5);
            this.paneldatagridExpenses.Size = new System.Drawing.Size(819, 449);
            this.paneldatagridExpenses.TabIndex = 19;
            // 
            // dgCarExpenses
            // 
            this.dgCarExpenses.AllowUserToOrderColumns = true;
            this.dgCarExpenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgCarExpenses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgCarExpenses.BackgroundColor = System.Drawing.Color.Salmon;
            this.dgCarExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCarExpenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.Id,
            this.Title,
            this.Description,
            this.Amount,
            this.CreatedAt,
            this.UpdatedAt});
            this.dgCarExpenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCarExpenses.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgCarExpenses.GridColor = System.Drawing.Color.DimGray;
            this.dgCarExpenses.Location = new System.Drawing.Point(5, 5);
            this.dgCarExpenses.Margin = new System.Windows.Forms.Padding(10);
            this.dgCarExpenses.MultiSelect = false;
            this.dgCarExpenses.Name = "dgCarExpenses";
            this.dgCarExpenses.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgCarExpenses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCarExpenses.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgCarExpenses.RowHeadersVisible = false;
            this.dgCarExpenses.RowHeadersWidth = 50;
            this.dgCarExpenses.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgCarExpenses.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dgCarExpenses.RowTemplate.DividerHeight = 1;
            this.dgCarExpenses.RowTemplate.Height = 50;
            this.dgCarExpenses.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCarExpenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgCarExpenses.Size = new System.Drawing.Size(809, 439);
            this.dgCarExpenses.StandardTab = true;
            this.dgCarExpenses.TabIndex = 10;
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
            this.Title.HeaderText = "بابت";
            this.Title.Name = "Title";
            this.Title.Width = 57;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "شرح";
            this.Description.Name = "Description";
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Amount.DataPropertyName = "Amount";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Format = "#,0 تومان";
            dataGridViewCellStyle3.NullValue = "0";
            this.Amount.DefaultCellStyle = dataGridViewCellStyle3;
            this.Amount.FillWeight = 200F;
            this.Amount.HeaderText = "مبلغ";
            this.Amount.MinimumWidth = 150;
            this.Amount.Name = "Amount";
            this.Amount.Width = 150;
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
            this.BtnActionCurrentUser.Location = new System.Drawing.Point(5, 478);
            this.BtnActionCurrentUser.Name = "BtnActionCurrentUser";
            this.BtnActionCurrentUser.Padding = new System.Windows.Forms.Padding(0);
            this.BtnActionCurrentUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnActionCurrentUser.Size = new System.Drawing.Size(819, 29);
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
            // panelTop
            // 
            this.panelTop.Controls.Add(this.inputReceptionId);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(5, 5);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(819, 24);
            this.panelTop.TabIndex = 19;
            // 
            // inputReceptionId
            // 
            this.inputReceptionId.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.inputReceptionId.BackColor = System.Drawing.Color.White;
            this.inputReceptionId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.inputReceptionId.CornerRadius = 0;
            this.inputReceptionId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputReceptionId.Dock = System.Windows.Forms.DockStyle.Left;
            this.inputReceptionId.Enabled = false;
            this.inputReceptionId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.inputReceptionId.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.inputReceptionId.Icon = null;
            this.inputReceptionId.Location = new System.Drawing.Point(0, 0);
            this.inputReceptionId.Name = "inputReceptionId";
            this.inputReceptionId.Placeholder = "[شماره فاکتور]";
            this.inputReceptionId.PlaceholderColor = System.Drawing.Color.Black;
            this.inputReceptionId.ShowClearButton = false;
            this.inputReceptionId.Size = new System.Drawing.Size(95, 24);
            this.inputReceptionId.TabIndex = 11;
            this.inputReceptionId.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Vazirmatn SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(450, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "فرم ثبت هزینه های تعمیر  تقویت خودرو";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelBottom.Controls.Add(this.btnCancel);
            this.panelBottom.Controls.Add(this.btnSubmit);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(5, 517);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(829, 51);
            this.panelBottom.TabIndex = 142;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.btnCancel.BaseBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCancel.BorderColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnCancel.Icon = global::AutoLedger.App.Properties.Resources.info_128;
            this.btnCancel.IconSize = 25;
            this.btnCancel.Location = new System.Drawing.Point(540, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnCancel.Size = new System.Drawing.Size(92, 37);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "لغو";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.btnSubmit.BaseBackColor = System.Drawing.Color.SeaGreen;
            this.btnSubmit.BorderColor = System.Drawing.Color.Transparent;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubmit.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnSubmit.Icon = global::AutoLedger.App.Properties.Resources.approval_128;
            this.btnSubmit.IconSize = 25;
            this.btnSubmit.Location = new System.Drawing.Point(638, 7);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSubmit.Size = new System.Drawing.Size(181, 38);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "ثبت مخارج خودرو";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // labelTittle
            // 
            this.labelTittle.BackColor = System.Drawing.Color.Transparent;
            this.labelTittle.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelTittle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTittle.Location = new System.Drawing.Point(429, 1);
            this.labelTittle.Margin = new System.Windows.Forms.Padding(10, 17, 10, 17);
            this.labelTittle.Name = "labelTittle";
            this.labelTittle.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelTittle.Size = new System.Drawing.Size(454, 35);
            this.labelTittle.TabIndex = 17;
            this.labelTittle.Text = "فهرست خدمات و هزینه ها";
            this.labelTittle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CarReceptionExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(839, 573);
            this.ControlBox = false;
            this.Controls.Add(this.panelLeft);
            this.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "CarReceptionExpenseForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "فرم مخارج خودروی پذیرفته شده";
            this.TopMost = true;
            this.panelLeft.ResumeLayout(false);
            this.panelFactor.ResumeLayout(false);
            this.panelFactor.PerformLayout();
            this.paneldatagridExpenses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCarExpenses)).EndInit();
            this.BtnActionCurrentUser.ResumeLayout(false);
            this.BtnActionCurrentUser.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private Panel panelTop;
        private Panel panelBottom;
        private DataGridView dgCarExpenses;
        private ToolStrip BtnActionCurrentUser;
        private ToolStripButton btnDeleteCurrentRequest;
        private ToolStripButton btnDeleteAllRequests;
        private ToolStripLabel labelTotalCost;
        private Label labelTittle;
        private ModernButton btnSubmit;
        private ModernButton btnCancel;
        private Label label1;
        private ModernTextBox inputReceptionId;

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
