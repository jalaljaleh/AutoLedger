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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideStackedBarSeriesView sideBySideStackedBarSeriesView1 = new DevExpress.XtraCharts.SideBySideStackedBarSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideStackedBarSeriesView sideBySideStackedBarSeriesView2 = new DevExpress.XtraCharts.SideBySideStackedBarSeriesView();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideStackedBarSeriesView sideBySideStackedBarSeriesView3 = new DevExpress.XtraCharts.SideBySideStackedBarSeriesView();
            this.dgExpenses = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expenses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Revenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cbCount = new System.Windows.Forms.ToolStripComboBox();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNextPage = new System.Windows.Forms.ToolStripButton();
            this.btnBackPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.labelDetails = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnActionCurrentUser = new System.Windows.Forms.ToolStrip();
            this.panelTitleStatus = new System.Windows.Forms.SplitContainer();
            this.chartDaily = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgExpenses)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelTitleStatus)).BeginInit();
            this.panelTitleStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDaily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideStackedBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideStackedBarSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideStackedBarSeriesView3)).BeginInit();
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
            this.dgExpenses.Location = new System.Drawing.Point(5, 330);
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
            this.dgExpenses.Size = new System.Drawing.Size(998, 591);
            this.dgExpenses.TabIndex = 11;
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
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(5, 921);
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
            // BtnActionCurrentUser
            // 
            this.BtnActionCurrentUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnActionCurrentUser.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnActionCurrentUser.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.BtnActionCurrentUser.ImageScalingSize = new System.Drawing.Size(80, 80);
            this.BtnActionCurrentUser.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.BtnActionCurrentUser.Location = new System.Drawing.Point(5, 305);
            this.BtnActionCurrentUser.Name = "BtnActionCurrentUser";
            this.BtnActionCurrentUser.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnActionCurrentUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnActionCurrentUser.Size = new System.Drawing.Size(998, 25);
            this.BtnActionCurrentUser.TabIndex = 19;
            this.BtnActionCurrentUser.Text = "toolStrip1";
            // 
            // panelTitleStatus
            // 
            this.panelTitleStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleStatus.Location = new System.Drawing.Point(5, 5);
            this.panelTitleStatus.Name = "panelTitleStatus";
            // 
            // panelTitleStatus.Panel1
            // 
            this.panelTitleStatus.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            // 
            // panelTitleStatus.Panel2
            // 
            this.panelTitleStatus.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelTitleStatus.Size = new System.Drawing.Size(998, 100);
            this.panelTitleStatus.SplitterDistance = 498;
            this.panelTitleStatus.TabIndex = 0;
            // 
            // chartDaily
            // 
            this.chartDaily.BorderOptions.Color = System.Drawing.Color.Transparent;
            this.chartDaily.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Alignment = DevExpress.XtraCharts.AxisAlignment.Far;
            xyDiagram1.AxisY.GridLines.Visible = false;
            xyDiagram1.AxisY.Title.Text = "";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.Default;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartDaily.Diagram = xyDiagram1;
            this.chartDaily.Dock = System.Windows.Forms.DockStyle.Top;
            this.chartDaily.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right;
            this.chartDaily.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside;
            this.chartDaily.Legend.Direction = DevExpress.XtraCharts.LegendDirection.RightToLeft;
            this.chartDaily.Location = new System.Drawing.Point(5, 105);
            this.chartDaily.Name = "chartDaily";
            this.chartDaily.PaletteName = "Blue II";
            this.chartDaily.SelectionMode = DevExpress.XtraCharts.ElementSelectionMode.Single;
            series1.Name = "هزینه ها";
            series1.SeriesID = 12;
            sideBySideStackedBarSeriesView1.Color = System.Drawing.Color.Brown;
            sideBySideStackedBarSeriesView1.Transparency = ((byte)(50));
            series1.View = sideBySideStackedBarSeriesView1;
            series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series2.Name = "درآمد ها";
            series2.SeriesID = 13;
            sideBySideStackedBarSeriesView2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(60)))));
            series2.View = sideBySideStackedBarSeriesView2;
            series3.Name = "سود";
            series3.SeriesID = 14;
            sideBySideStackedBarSeriesView3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(214)))), ((int)(((byte)(155)))));
            sideBySideStackedBarSeriesView3.Transparency = ((byte)(50));
            series3.View = sideBySideStackedBarSeriesView3;
            this.chartDaily.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2,
        series3};
            this.chartDaily.Size = new System.Drawing.Size(998, 200);
            this.chartDaily.TabIndex = 0;
            // 
            // AccountingReportsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.Controls.Add(this.dgExpenses);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.BtnActionCurrentUser);
            this.Controls.Add(this.chartDaily);
            this.Controls.Add(this.panelTitleStatus);
            this.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AccountingReportsPage";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1008, 969);
            ((System.ComponentModel.ISupportInitialize)(this.dgExpenses)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelTitleStatus)).EndInit();
            this.panelTitleStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideStackedBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideStackedBarSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideStackedBarSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDaily)).EndInit();
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
        private System.Windows.Forms.ToolStrip BtnActionCurrentUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expenses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Revenue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.SplitContainer panelTitleStatus;
        private DevExpress.XtraCharts.ChartControl chartDaily;
    }
}
