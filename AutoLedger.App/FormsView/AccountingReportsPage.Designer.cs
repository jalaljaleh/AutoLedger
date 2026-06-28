namespace AutoLedger.App.FormsView
{
    partial class AccountingReportsPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgExpenses = new System.Windows.Forms.DataGridView();
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
            this.BtnActionCurrentUser = new System.Windows.Forms.ToolStrip();
            this.btnFilterMonth = new System.Windows.Forms.ToolStripButton();
            this.btnFilterWeek = new System.Windows.Forms.ToolStripButton();
            this.btnFilterToday = new System.Windows.Forms.ToolStripButton();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expenses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Revenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgExpenses)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.BtnActionCurrentUser.SuspendLayout();
            this.SuspendLayout();
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
            this.CreatedAt,
            this.Day,
            this.Month,
            this.Expenses,
            this.Revenue,
            this.Profit,
            this.Column1});
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
            this.dgExpenses.Size = new System.Drawing.Size(998, 659);
            this.dgExpenses.TabIndex = 11;
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
            this.btnRefresh,
            this.toolStripSeparator3,
            this.btnNextPage,
            this.btnBackPage,
            this.toolStripSeparator1,
            this.labelDetails,
            this.toolStripSeparator4,
            this.labelTotalExpenses});
            this.toolStrip1.Location = new System.Drawing.Point(5, 707);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(998, 43);
            this.toolStrip1.TabIndex = 18;
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
            this.btnRefresh.Size = new System.Drawing.Size(85, 30);
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
            // BtnActionCurrentUser
            // 
            this.BtnActionCurrentUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnActionCurrentUser.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnActionCurrentUser.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.BtnActionCurrentUser.ImageScalingSize = new System.Drawing.Size(80, 80);
            this.BtnActionCurrentUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFilterMonth,
            this.btnFilterWeek,
            this.btnFilterToday});
            this.BtnActionCurrentUser.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.BtnActionCurrentUser.Location = new System.Drawing.Point(5, 5);
            this.BtnActionCurrentUser.Name = "BtnActionCurrentUser";
            this.BtnActionCurrentUser.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnActionCurrentUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnActionCurrentUser.Size = new System.Drawing.Size(998, 43);
            this.BtnActionCurrentUser.TabIndex = 19;
            this.BtnActionCurrentUser.Text = "toolStrip1";
            // 
            // btnFilterMonth
            // 
            this.btnFilterMonth.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnFilterMonth.AutoSize = false;
            this.btnFilterMonth.Image = global::AutoLedger.App.Properties.Resources.calendar_week30_128;
            this.btnFilterMonth.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFilterMonth.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.btnFilterMonth.Name = "btnFilterMonth";
            this.btnFilterMonth.Size = new System.Drawing.Size(70, 30);
            this.btnFilterMonth.Text = "ماهانه";
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
            this.btnFilterWeek.Size = new System.Drawing.Size(72, 30);
            this.btnFilterWeek.Text = "هفتگی";
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
            this.btnFilterToday.Size = new System.Drawing.Size(64, 30);
            this.btnFilterToday.Text = "روزانه";
            this.btnFilterToday.ToolTipText = "نتایج امروز فقط";
            // 
            // Index
            // 
            this.Index.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Index.DataPropertyName = "Id";
            this.Index.HeaderText = "R";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Index.Width = 42;
            // 
            // CreatedAt
            // 
            this.CreatedAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CreatedAt.DataPropertyName = "CreatedAt";
            dataGridViewCellStyle1.Format = "D";
            dataGridViewCellStyle1.NullValue = null;
            this.CreatedAt.DefaultCellStyle = dataGridViewCellStyle1;
            this.CreatedAt.HeaderText = "تاریخ";
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.ReadOnly = true;
            this.CreatedAt.Width = 58;
            // 
            // Day
            // 
            this.Day.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Day.DataPropertyName = "Day";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day.DefaultCellStyle = dataGridViewCellStyle2;
            this.Day.HeaderText = "روز";
            this.Day.Name = "Day";
            this.Day.ReadOnly = true;
            this.Day.Width = 48;
            // 
            // Month
            // 
            this.Month.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Month.DataPropertyName = "Month";
            this.Month.HeaderText = "ماه";
            this.Month.Name = "Month";
            this.Month.ReadOnly = true;
            this.Month.Width = 50;
            // 
            // Expenses
            // 
            this.Expenses.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Expenses.DataPropertyName = "Expenses";
            dataGridViewCellStyle3.Format = "#,0 تومان";
            this.Expenses.DefaultCellStyle = dataGridViewCellStyle3;
            this.Expenses.HeaderText = "هزینه ها";
            this.Expenses.Name = "Expenses";
            this.Expenses.ReadOnly = true;
            this.Expenses.Width = 76;
            // 
            // Revenue
            // 
            this.Revenue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Revenue.DataPropertyName = "Revenue";
            dataGridViewCellStyle4.Format = "#,0 تومان";
            this.Revenue.DefaultCellStyle = dataGridViewCellStyle4;
            this.Revenue.HeaderText = "درامد ها";
            this.Revenue.Name = "Revenue";
            this.Revenue.ReadOnly = true;
            this.Revenue.Width = 73;
            // 
            // Profit
            // 
            this.Profit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Profit.DataPropertyName = "Profit";
            dataGridViewCellStyle5.Format = "#,0 تومان";
            this.Profit.DefaultCellStyle = dataGridViewCellStyle5;
            this.Profit.HeaderText = "سود خالص";
            this.Profit.Name = "Profit";
            this.Profit.ReadOnly = true;
            this.Profit.Width = 87;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // AccountingReportsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.Controls.Add(this.dgExpenses);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.BtnActionCurrentUser);
            this.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AccountingReportsPage";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1008, 755);
            ((System.ComponentModel.ISupportInitialize)(this.dgExpenses)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.BtnActionCurrentUser.ResumeLayout(false);
            this.BtnActionCurrentUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgExpenses;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalExpenses;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalRevenue;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox cbCount;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnNextPage;
        private System.Windows.Forms.ToolStripButton btnBackPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel labelDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel labelTotalExpenses;
        private System.Windows.Forms.ToolStrip BtnActionCurrentUser;
        private System.Windows.Forms.ToolStripButton btnFilterMonth;
        private System.Windows.Forms.ToolStripButton btnFilterWeek;
        private System.Windows.Forms.ToolStripButton btnFilterToday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expenses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Revenue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}
