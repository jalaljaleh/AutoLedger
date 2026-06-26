namespace AutoLedger.App.FormsView
{
    partial class ExpensesManagerPage
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
            this.panelFactor = new System.Windows.Forms.Panel();
            this.dgExpenses = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnActionCurrentUser = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnFilterAllTimes = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFilterMonth = new System.Windows.Forms.ToolStripButton();
            this.btnFilterWeek = new System.Windows.Forms.ToolStripButton();
            this.btnFilterToday = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cbCount = new System.Windows.Forms.ToolStripComboBox();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNextPage = new System.Windows.Forms.ToolStripButton();
            this.btnBackPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.labelDetails = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.labelTotalExpenses = new System.Windows.Forms.ToolStripLabel();
            this.panelFactor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgExpenses)).BeginInit();
            this.BtnActionCurrentUser.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFactor
            // 
            this.panelFactor.Controls.Add(this.dgExpenses);
            this.panelFactor.Controls.Add(this.BtnActionCurrentUser);
            this.panelFactor.Controls.Add(this.toolStrip1);
            this.panelFactor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFactor.Location = new System.Drawing.Point(2, 2);
            this.panelFactor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelFactor.Name = "panelFactor";
            this.panelFactor.Padding = new System.Windows.Forms.Padding(5);
            this.panelFactor.Size = new System.Drawing.Size(1076, 695);
            this.panelFactor.TabIndex = 22;
            // 
            // dgExpenses
            // 
            this.dgExpenses.AllowUserToAddRows = false;
            this.dgExpenses.AllowUserToDeleteRows = false;
            this.dgExpenses.AllowUserToResizeRows = false;
            this.dgExpenses.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgExpenses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgExpenses.ColumnHeadersHeight = 35;
            this.dgExpenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.Id,
            this.Title,
            this.Description,
            this.Amount,
            this.CreatedAt,
            this.extra});
            this.dgExpenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgExpenses.GridColor = System.Drawing.Color.DimGray;
            this.dgExpenses.Location = new System.Drawing.Point(5, 48);
            this.dgExpenses.Margin = new System.Windows.Forms.Padding(0);
            this.dgExpenses.MultiSelect = false;
            this.dgExpenses.Name = "dgExpenses";
            this.dgExpenses.ReadOnly = true;
            this.dgExpenses.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgExpenses.RowHeadersVisible = false;
            this.dgExpenses.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgExpenses.RowTemplate.DefaultCellStyle.NullValue = "[تعریف نشده]";
            this.dgExpenses.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dgExpenses.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Snow;
            this.dgExpenses.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgExpenses.RowTemplate.DividerHeight = 1;
            this.dgExpenses.RowTemplate.Height = 40;
            this.dgExpenses.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgExpenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgExpenses.Size = new System.Drawing.Size(1066, 599);
            this.dgExpenses.TabIndex = 10;
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
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "شناسه";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 69;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "بابت";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 58;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "توضیحات";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 84;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Amount.DataPropertyName = "Amount";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Format = "#,0 تومان";
            this.Amount.DefaultCellStyle = dataGridViewCellStyle3;
            this.Amount.HeaderText = "مبلغ";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 59;
            // 
            // CreatedAt
            // 
            this.CreatedAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CreatedAt.DataPropertyName = "CreatedAt";
            dataGridViewCellStyle4.Format = "f";
            dataGridViewCellStyle4.NullValue = null;
            this.CreatedAt.DefaultCellStyle = dataGridViewCellStyle4;
            this.CreatedAt.HeaderText = "تاریخ پرداخت";
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.ReadOnly = true;
            this.CreatedAt.Width = 101;
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
            this.btnNew,
            this.toolStripSeparator5,
            this.btnEdit,
            this.btnDelete,
            this.btnFilterAllTimes,
            this.toolStripSeparator2,
            this.btnFilterMonth,
            this.btnFilterWeek,
            this.btnFilterToday});
            this.BtnActionCurrentUser.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.BtnActionCurrentUser.Location = new System.Drawing.Point(5, 5);
            this.BtnActionCurrentUser.Name = "BtnActionCurrentUser";
            this.BtnActionCurrentUser.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnActionCurrentUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnActionCurrentUser.Size = new System.Drawing.Size(1066, 43);
            this.BtnActionCurrentUser.TabIndex = 16;
            this.BtnActionCurrentUser.Text = "toolStrip1";
            // 
            // btnNew
            // 
            this.btnNew.AutoSize = false;
            this.btnNew.Image = global::AutoLedger.App.Properties.Resources.credit_card_128;
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(105, 30);
            this.btnNew.Text = "پرداخت جدید";
            this.btnNew.ToolTipText = "خرید جدید";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 33);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = false;
            this.btnEdit.Image = global::AutoLedger.App.Properties.Resources.four_squares_128;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 30);
            this.btnEdit.Text = "ویرایش";
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = false;
            this.btnDelete.Image = global::AutoLedger.App.Properties.Resources.erase_128;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 30);
            this.btnDelete.Text = "حذف";
            this.btnDelete.ToolTipText = "حذف";
            // 
            // btnFilterAllTimes
            // 
            this.btnFilterAllTimes.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnFilterAllTimes.AutoSize = false;
            this.btnFilterAllTimes.Image = global::AutoLedger.App.Properties.Resources.today_1281;
            this.btnFilterAllTimes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFilterAllTimes.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.btnFilterAllTimes.Name = "btnFilterAllTimes";
            this.btnFilterAllTimes.Size = new System.Drawing.Size(105, 30);
            this.btnFilterAllTimes.Text = "همه زمان ها";
            this.btnFilterAllTimes.ToolTipText = "همه";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(5);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // btnFilterMonth
            // 
            this.btnFilterMonth.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnFilterMonth.AutoSize = false;
            this.btnFilterMonth.Image = global::AutoLedger.App.Properties.Resources.calendar_week30_128;
            this.btnFilterMonth.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFilterMonth.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.btnFilterMonth.Name = "btnFilterMonth";
            this.btnFilterMonth.Size = new System.Drawing.Size(80, 30);
            this.btnFilterMonth.Text = "ماه اخیر";
            this.btnFilterMonth.ToolTipText = "ماه اخیر";
            // 
            // btnFilterWeek
            // 
            this.btnFilterWeek.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnFilterWeek.AutoSize = false;
            this.btnFilterWeek.Image = global::AutoLedger.App.Properties.Resources.calendar_7_128;
            this.btnFilterWeek.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFilterWeek.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.btnFilterWeek.Name = "btnFilterWeek";
            this.btnFilterWeek.Size = new System.Drawing.Size(90, 30);
            this.btnFilterWeek.Text = "هفته اخیر";
            this.btnFilterWeek.ToolTipText = "نتایج امروز فقط";
            // 
            // btnFilterToday
            // 
            this.btnFilterToday.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnFilterToday.AutoSize = false;
            this.btnFilterToday.Image = global::AutoLedger.App.Properties.Resources.calendar_1_128;
            this.btnFilterToday.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFilterToday.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.btnFilterToday.Name = "btnFilterToday";
            this.btnFilterToday.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnFilterToday.Size = new System.Drawing.Size(65, 30);
            this.btnFilterToday.Text = "امروز";
            this.btnFilterToday.ToolTipText = "نتایج امروز فقط";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(80, 80);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbCount,
            this.btnRefresh,
            this.toolStripSeparator3,
            this.btnNextPage,
            this.btnBackPage,
            this.toolStripSeparator1,
            this.labelDetails,
            this.toolStripSeparator4,
            this.labelTotalExpenses});
            this.toolStrip1.Location = new System.Drawing.Point(5, 647);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(1066, 43);
            this.toolStrip1.TabIndex = 17;
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
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = false;
            this.btnRefresh.Image = global::AutoLedger.App.Properties.Resources.sync_128;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 30);
            this.btnRefresh.Text = "بروزرسانی";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 33);
            // 
            // btnNextPage
            // 
            this.btnNextPage.AutoSize = false;
            this.btnNextPage.Image = global::AutoLedger.App.Properties.Resources.next;
            this.btnNextPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNextPage.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnNextPage.Size = new System.Drawing.Size(92, 30);
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
            this.btnBackPage.Size = new System.Drawing.Size(94, 30);
            this.btnBackPage.Text = "صفحه قبل";
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
            this.labelTotalExpenses.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelTotalExpenses.Name = "labelTotalExpenses";
            this.labelTotalExpenses.Size = new System.Drawing.Size(69, 30);
            this.labelTotalExpenses.Text = "[جمع کل]";
            // 
            // ExpensesManagerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.Controls.Add(this.panelFactor);
            this.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ExpensesManagerPage";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(1080, 699);
            this.panelFactor.ResumeLayout(false);
            this.panelFactor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgExpenses)).EndInit();
            this.BtnActionCurrentUser.ResumeLayout(false);
            this.BtnActionCurrentUser.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFactor;
        private System.Windows.Forms.DataGridView dgExpenses;
        private System.Windows.Forms.ToolStrip BtnActionCurrentUser;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnNextPage;
        private System.Windows.Forms.ToolStripButton btnBackPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel labelDetails;
        private System.Windows.Forms.ToolStripComboBox cbCount;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnFilterToday;
        private System.Windows.Forms.ToolStripButton btnFilterWeek;
        private System.Windows.Forms.ToolStripButton btnFilterMonth;
        private System.Windows.Forms.ToolStripButton btnFilterAllTimes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn extra;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel labelTotalExpenses;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;

    }
}
