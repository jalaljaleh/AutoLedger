namespace AutoLedger.App.FormsView
{
    partial class DailyReportPage
    {

            private System.ComponentModel.IContainer components = null;

            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

            private void InitializeComponent()
            {
            this.grpDate = new DevExpress.XtraEditors.GroupControl();
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            this.txtShamsiDate = new DevExpress.XtraEditors.TextEdit();
            this.lblYear = new DevExpress.XtraEditors.LabelControl();
            this.spnYear = new DevExpress.XtraEditors.SpinEdit();
            this.lblMonth = new DevExpress.XtraEditors.LabelControl();
            this.spnMonth = new DevExpress.XtraEditors.SpinEdit();
            this.lblDay = new DevExpress.XtraEditors.LabelControl();
            this.spnDay = new DevExpress.XtraEditors.SpinEdit();
            this.grpFinance = new DevExpress.XtraEditors.GroupControl();
            this.lblShopExpenses = new DevExpress.XtraEditors.LabelControl();
            this.spnShopExpenses = new DevExpress.XtraEditors.SpinEdit();
            this.lblReceptionExpenses = new DevExpress.XtraEditors.LabelControl();
            this.spnReceptionExpenses = new DevExpress.XtraEditors.SpinEdit();
            this.lblReceptionRevenue = new DevExpress.XtraEditors.LabelControl();
            this.spnReceptionRevenue = new DevExpress.XtraEditors.SpinEdit();
            this.lblTotalExpenses = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalExpenses = new DevExpress.XtraEditors.TextEdit();
            this.lblTotalRevenue = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalRevenue = new DevExpress.XtraEditors.TextEdit();
            this.lblProfit = new DevExpress.XtraEditors.LabelControl();
            this.txtProfit = new DevExpress.XtraEditors.TextEdit();
            this.grpStats = new DevExpress.XtraEditors.GroupControl();
            this.lblShopExpCount = new DevExpress.XtraEditors.LabelControl();
            this.spnShopExpensesCount = new DevExpress.XtraEditors.SpinEdit();
            this.lblNewCars = new DevExpress.XtraEditors.LabelControl();
            this.spnNewCars = new DevExpress.XtraEditors.SpinEdit();
            this.lblRecOpened = new DevExpress.XtraEditors.LabelControl();
            this.spnReceptionsOpened = new DevExpress.XtraEditors.SpinEdit();
            this.lblRecRepaired = new DevExpress.XtraEditors.LabelControl();
            this.spnReceptionsRepaired = new DevExpress.XtraEditors.SpinEdit();
            this.lblRecReleased = new DevExpress.XtraEditors.LabelControl();
            this.spnReceptionsReleased = new DevExpress.XtraEditors.SpinEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grpDate)).BeginInit();
            this.grpDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtShamsiDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpFinance)).BeginInit();
            this.grpFinance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnShopExpenses.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnReceptionExpenses.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnReceptionRevenue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalExpenses.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalRevenue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProfit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpStats)).BeginInit();
            this.grpStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnShopExpensesCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnNewCars.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnReceptionsOpened.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnReceptionsRepaired.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnReceptionsReleased.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDate
            // 
            this.grpDate.Controls.Add(this.lblDate);
            this.grpDate.Controls.Add(this.txtShamsiDate);
            this.grpDate.Controls.Add(this.lblYear);
            this.grpDate.Controls.Add(this.spnYear);
            this.grpDate.Controls.Add(this.lblMonth);
            this.grpDate.Controls.Add(this.spnMonth);
            this.grpDate.Controls.Add(this.lblDay);
            this.grpDate.Controls.Add(this.spnDay);
            this.grpDate.Location = new System.Drawing.Point(0, 14);
            this.grpDate.Name = "grpDate";
            this.grpDate.Size = new System.Drawing.Size(610, 80);
            this.grpDate.TabIndex = 0;
            this.grpDate.Text = "اطلاعات زمانی";
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(520, 40);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(63, 21);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "تاریخ شمسی:";
            // 
            // txtShamsiDate
            // 
            this.txtShamsiDate.Location = new System.Drawing.Point(380, 38);
            this.txtShamsiDate.Name = "txtShamsiDate";
            this.txtShamsiDate.Properties.ReadOnly = true;
            this.txtShamsiDate.Size = new System.Drawing.Size(130, 36);
            this.txtShamsiDate.TabIndex = 1;
            // 
            // lblYear
            // 
            this.lblYear.Location = new System.Drawing.Point(330, 40);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(23, 21);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "سال:";
            // 
            // spnYear
            // 
            this.spnYear.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnYear.Enabled = false;
            this.spnYear.Location = new System.Drawing.Point(260, 38);
            this.spnYear.Name = "spnYear";
            this.spnYear.Size = new System.Drawing.Size(60, 36);
            this.spnYear.TabIndex = 3;
            // 
            // lblMonth
            // 
            this.lblMonth.Location = new System.Drawing.Point(210, 40);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(18, 21);
            this.lblMonth.TabIndex = 4;
            this.lblMonth.Text = "ماه:";
            // 
            // spnMonth
            // 
            this.spnMonth.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnMonth.Enabled = false;
            this.spnMonth.Location = new System.Drawing.Point(140, 38);
            this.spnMonth.Name = "spnMonth";
            this.spnMonth.Size = new System.Drawing.Size(60, 36);
            this.spnMonth.TabIndex = 5;
            // 
            // lblDay
            // 
            this.lblDay.Location = new System.Drawing.Point(90, 40);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(16, 21);
            this.lblDay.TabIndex = 6;
            this.lblDay.Text = "روز:";
            // 
            // spnDay
            // 
            this.spnDay.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnDay.Enabled = false;
            this.spnDay.Location = new System.Drawing.Point(20, 38);
            this.spnDay.Name = "spnDay";
            this.spnDay.Size = new System.Drawing.Size(60, 36);
            this.spnDay.TabIndex = 7;
            // 
            // grpFinance
            // 
            this.grpFinance.Controls.Add(this.lblShopExpenses);
            this.grpFinance.Controls.Add(this.spnShopExpenses);
            this.grpFinance.Controls.Add(this.lblReceptionExpenses);
            this.grpFinance.Controls.Add(this.spnReceptionExpenses);
            this.grpFinance.Controls.Add(this.lblReceptionRevenue);
            this.grpFinance.Controls.Add(this.spnReceptionRevenue);
            this.grpFinance.Controls.Add(this.lblTotalExpenses);
            this.grpFinance.Controls.Add(this.txtTotalExpenses);
            this.grpFinance.Controls.Add(this.lblTotalRevenue);
            this.grpFinance.Controls.Add(this.txtTotalRevenue);
            this.grpFinance.Controls.Add(this.lblProfit);
            this.grpFinance.Controls.Add(this.txtProfit);
            this.grpFinance.Location = new System.Drawing.Point(0, 114);
            this.grpFinance.Name = "grpFinance";
            this.grpFinance.Size = new System.Drawing.Size(610, 164);
            this.grpFinance.TabIndex = 1;
            this.grpFinance.Text = "اطلاعات مالی (مبالغ به تومان)";
            this.grpFinance.Paint += new System.Windows.Forms.PaintEventHandler(this.grpFinance_Paint);
            // 
            // lblShopExpenses
            // 
            this.lblShopExpenses.Location = new System.Drawing.Point(490, 40);
            this.lblShopExpenses.Name = "lblShopExpenses";
            this.lblShopExpenses.Size = new System.Drawing.Size(93, 21);
            this.lblShopExpenses.TabIndex = 0;
            this.lblShopExpenses.Text = "هزینه‌های تعمیرگاه:";
            // 
            // spnShopExpenses
            // 
            this.spnShopExpenses.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnShopExpenses.Enabled = false;
            this.spnShopExpenses.Location = new System.Drawing.Point(320, 38);
            this.spnShopExpenses.Name = "spnShopExpenses";
            this.spnShopExpenses.Size = new System.Drawing.Size(160, 36);
            this.spnShopExpenses.TabIndex = 1;
            // 
            // lblReceptionExpenses
            // 
            this.lblReceptionExpenses.Location = new System.Drawing.Point(490, 78);
            this.lblReceptionExpenses.Name = "lblReceptionExpenses";
            this.lblReceptionExpenses.Size = new System.Drawing.Size(84, 21);
            this.lblReceptionExpenses.TabIndex = 2;
            this.lblReceptionExpenses.Text = "هزینه‌های پذیرش:";
            // 
            // spnReceptionExpenses
            // 
            this.spnReceptionExpenses.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnReceptionExpenses.Enabled = false;
            this.spnReceptionExpenses.Location = new System.Drawing.Point(320, 76);
            this.spnReceptionExpenses.Name = "spnReceptionExpenses";
            this.spnReceptionExpenses.Size = new System.Drawing.Size(160, 36);
            this.spnReceptionExpenses.TabIndex = 3;
            // 
            // lblReceptionRevenue
            // 
            this.lblReceptionRevenue.Location = new System.Drawing.Point(490, 116);
            this.lblReceptionRevenue.Name = "lblReceptionRevenue";
            this.lblReceptionRevenue.Size = new System.Drawing.Size(78, 21);
            this.lblReceptionRevenue.TabIndex = 4;
            this.lblReceptionRevenue.Text = "درآمد کل پذیرش:";
            // 
            // spnReceptionRevenue
            // 
            this.spnReceptionRevenue.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnReceptionRevenue.Enabled = false;
            this.spnReceptionRevenue.Location = new System.Drawing.Point(320, 114);
            this.spnReceptionRevenue.Name = "spnReceptionRevenue";
            this.spnReceptionRevenue.Size = new System.Drawing.Size(160, 36);
            this.spnReceptionRevenue.TabIndex = 5;
            // 
            // lblTotalExpenses
            // 
            this.lblTotalExpenses.Location = new System.Drawing.Point(190, 40);
            this.lblTotalExpenses.Name = "lblTotalExpenses";
            this.lblTotalExpenses.Size = new System.Drawing.Size(77, 21);
            this.lblTotalExpenses.TabIndex = 6;
            this.lblTotalExpenses.Text = "مجموع هزینه‌ها:";
            // 
            // txtTotalExpenses
            // 
            this.txtTotalExpenses.Location = new System.Drawing.Point(20, 38);
            this.txtTotalExpenses.Name = "txtTotalExpenses";
            this.txtTotalExpenses.Properties.ReadOnly = true;
            this.txtTotalExpenses.Size = new System.Drawing.Size(160, 36);
            this.txtTotalExpenses.TabIndex = 7;
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.Location = new System.Drawing.Point(190, 77);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(74, 21);
            this.lblTotalRevenue.TabIndex = 8;
            this.lblTotalRevenue.Text = "مجموع درآمدها:";
            // 
            // txtTotalRevenue
            // 
            this.txtTotalRevenue.Location = new System.Drawing.Point(20, 75);
            this.txtTotalRevenue.Name = "txtTotalRevenue";
            this.txtTotalRevenue.Properties.ReadOnly = true;
            this.txtTotalRevenue.Size = new System.Drawing.Size(160, 36);
            this.txtTotalRevenue.TabIndex = 9;
            // 
            // lblProfit
            // 
            this.lblProfit.Location = new System.Drawing.Point(190, 116);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(81, 21);
            this.lblProfit.TabIndex = 10;
            this.lblProfit.Text = "سود خالص (تراز):";
            // 
            // txtProfit
            // 
            this.txtProfit.Location = new System.Drawing.Point(20, 114);
            this.txtProfit.Name = "txtProfit";
            this.txtProfit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtProfit.Properties.Appearance.Options.UseFont = true;
            this.txtProfit.Properties.ReadOnly = true;
            this.txtProfit.Size = new System.Drawing.Size(160, 28);
            this.txtProfit.TabIndex = 11;
            // 
            // grpStats
            // 
            this.grpStats.Controls.Add(this.lblShopExpCount);
            this.grpStats.Controls.Add(this.spnShopExpensesCount);
            this.grpStats.Controls.Add(this.lblNewCars);
            this.grpStats.Controls.Add(this.spnNewCars);
            this.grpStats.Controls.Add(this.lblRecOpened);
            this.grpStats.Controls.Add(this.spnReceptionsOpened);
            this.grpStats.Controls.Add(this.lblRecRepaired);
            this.grpStats.Controls.Add(this.spnReceptionsRepaired);
            this.grpStats.Controls.Add(this.lblRecReleased);
            this.grpStats.Controls.Add(this.spnReceptionsReleased);
            this.grpStats.Location = new System.Drawing.Point(0, 284);
            this.grpStats.Name = "grpStats";
            this.grpStats.Size = new System.Drawing.Size(610, 162);
            this.grpStats.TabIndex = 2;
            this.grpStats.Text = "آمار عملیات (تعداد)";
            // 
            // lblShopExpCount
            // 
            this.lblShopExpCount.Location = new System.Drawing.Point(440, 40);
            this.lblShopExpCount.Name = "lblShopExpCount";
            this.lblShopExpCount.Size = new System.Drawing.Size(147, 21);
            this.lblShopExpCount.TabIndex = 0;
            this.lblShopExpCount.Text = "تعداد ردیف هزینه‌های فروشگاه:";
            // 
            // spnShopExpensesCount
            // 
            this.spnShopExpensesCount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnShopExpensesCount.Enabled = false;
            this.spnShopExpensesCount.Location = new System.Drawing.Point(340, 38);
            this.spnShopExpensesCount.Name = "spnShopExpensesCount";
            this.spnShopExpensesCount.Size = new System.Drawing.Size(80, 36);
            this.spnShopExpensesCount.TabIndex = 1;
            // 
            // lblNewCars
            // 
            this.lblNewCars.Location = new System.Drawing.Point(440, 80);
            this.lblNewCars.Name = "lblNewCars";
            this.lblNewCars.Size = new System.Drawing.Size(123, 21);
            this.lblNewCars.TabIndex = 2;
            this.lblNewCars.Text = "خودروهای جدید ثبت شده:";
            // 
            // spnNewCars
            // 
            this.spnNewCars.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnNewCars.Enabled = false;
            this.spnNewCars.Location = new System.Drawing.Point(340, 78);
            this.spnNewCars.Name = "spnNewCars";
            this.spnNewCars.Size = new System.Drawing.Size(80, 36);
            this.spnNewCars.TabIndex = 3;
            // 
            // lblRecOpened
            // 
            this.lblRecOpened.Location = new System.Drawing.Point(150, 40);
            this.lblRecOpened.Name = "lblRecOpened";
            this.lblRecOpened.Size = new System.Drawing.Size(92, 21);
            this.lblRecOpened.TabIndex = 4;
            this.lblRecOpened.Text = "پذیرش‌های باز شده:";
            // 
            // spnReceptionsOpened
            // 
            this.spnReceptionsOpened.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnReceptionsOpened.Enabled = false;
            this.spnReceptionsOpened.Location = new System.Drawing.Point(20, 38);
            this.spnReceptionsOpened.Name = "spnReceptionsOpened";
            this.spnReceptionsOpened.Size = new System.Drawing.Size(80, 36);
            this.spnReceptionsOpened.TabIndex = 5;
            // 
            // lblRecRepaired
            // 
            this.lblRecRepaired.Location = new System.Drawing.Point(150, 78);
            this.lblRecRepaired.Name = "lblRecRepaired";
            this.lblRecRepaired.Size = new System.Drawing.Size(109, 21);
            this.lblRecRepaired.TabIndex = 6;
            this.lblRecRepaired.Text = "پذیرش‌های تعمیر شده:";
            // 
            // spnReceptionsRepaired
            // 
            this.spnReceptionsRepaired.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnReceptionsRepaired.Enabled = false;
            this.spnReceptionsRepaired.Location = new System.Drawing.Point(20, 76);
            this.spnReceptionsRepaired.Name = "spnReceptionsRepaired";
            this.spnReceptionsRepaired.Size = new System.Drawing.Size(80, 36);
            this.spnReceptionsRepaired.TabIndex = 7;
            // 
            // lblRecReleased
            // 
            this.lblRecReleased.Location = new System.Drawing.Point(150, 117);
            this.lblRecReleased.Name = "lblRecReleased";
            this.lblRecReleased.Size = new System.Drawing.Size(116, 21);
            this.lblRecReleased.TabIndex = 8;
            this.lblRecReleased.Text = "پذیرش‌های ترخیص شده:";
            // 
            // spnReceptionsReleased
            // 
            this.spnReceptionsReleased.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnReceptionsReleased.Enabled = false;
            this.spnReceptionsReleased.Location = new System.Drawing.Point(20, 115);
            this.spnReceptionsReleased.Name = "spnReceptionsReleased";
            this.spnReceptionsReleased.Size = new System.Drawing.Size(80, 36);
            this.spnReceptionsReleased.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(480, 461);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 35);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "تایید";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpDate);
            this.panel1.Controls.Add(this.grpFinance);
            this.panel1.Controls.Add(this.grpStats);
            this.panel1.Location = new System.Drawing.Point(20, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 455);
            this.panel1.TabIndex = 4;
            // 
            // DailyReportPage
            // 
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Name = "DailyReportPage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(650, 520);
            this.Load += new System.EventHandler(this.FrmDailyLedgerSummary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpDate)).EndInit();
            this.grpDate.ResumeLayout(false);
            this.grpDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtShamsiDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpFinance)).EndInit();
            this.grpFinance.ResumeLayout(false);
            this.grpFinance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnShopExpenses.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnReceptionExpenses.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnReceptionRevenue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalExpenses.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalRevenue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProfit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpStats)).EndInit();
            this.grpStats.ResumeLayout(false);
            this.grpStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnShopExpensesCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnNewCars.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnReceptionsOpened.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnReceptionsRepaired.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnReceptionsReleased.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

            }

            private DevExpress.XtraEditors.GroupControl grpDate;
            private DevExpress.XtraEditors.LabelControl lblDate;
            private DevExpress.XtraEditors.TextEdit txtShamsiDate;
            private DevExpress.XtraEditors.LabelControl lblYear;
            private DevExpress.XtraEditors.SpinEdit spnYear;
            private DevExpress.XtraEditors.LabelControl lblMonth;
            private DevExpress.XtraEditors.SpinEdit spnMonth;
            private DevExpress.XtraEditors.LabelControl lblDay;
            private DevExpress.XtraEditors.SpinEdit spnDay;

            private DevExpress.XtraEditors.GroupControl grpFinance;
            private DevExpress.XtraEditors.LabelControl lblShopExpenses;
            private DevExpress.XtraEditors.SpinEdit spnShopExpenses;
            private DevExpress.XtraEditors.LabelControl lblReceptionExpenses;
            private DevExpress.XtraEditors.SpinEdit spnReceptionExpenses;
            private DevExpress.XtraEditors.LabelControl lblReceptionRevenue;
            private DevExpress.XtraEditors.SpinEdit spnReceptionRevenue;
            private DevExpress.XtraEditors.LabelControl lblTotalExpenses;
            private DevExpress.XtraEditors.TextEdit txtTotalExpenses;
            private DevExpress.XtraEditors.LabelControl lblTotalRevenue;
            private DevExpress.XtraEditors.TextEdit txtTotalRevenue;
            private DevExpress.XtraEditors.LabelControl lblProfit;
            private DevExpress.XtraEditors.TextEdit txtProfit;

            private DevExpress.XtraEditors.GroupControl grpStats;
            private DevExpress.XtraEditors.LabelControl lblShopExpCount;
            private DevExpress.XtraEditors.SpinEdit spnShopExpensesCount;
            private DevExpress.XtraEditors.LabelControl lblNewCars;
            private DevExpress.XtraEditors.SpinEdit spnNewCars;
            private DevExpress.XtraEditors.LabelControl lblRecOpened;
            private DevExpress.XtraEditors.SpinEdit spnReceptionsOpened;
            private DevExpress.XtraEditors.LabelControl lblRecRepaired;
            private DevExpress.XtraEditors.SpinEdit spnReceptionsRepaired;
            private DevExpress.XtraEditors.LabelControl lblRecReleased;
            private DevExpress.XtraEditors.SpinEdit spnReceptionsReleased;

            private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.Panel panel1;
    }
    }

