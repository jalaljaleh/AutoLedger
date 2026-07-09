using System;

namespace AutoLedger.App.FormsView
{
    partial class DailyDashboardPage
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
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel3 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel4 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SplineSeriesView splineSeriesView2 = new DevExpress.XtraCharts.SplineSeriesView();
            this.chartFinance = new DevExpress.XtraCharts.ChartControl();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelProfit = new System.Windows.Forms.Panel();
            this.lblProfit = new System.Windows.Forms.Label();
            this.lblProfitTitle = new System.Windows.Forms.Label();
            this.panelExpnese = new System.Windows.Forms.Panel();
            this.lblExpenses = new System.Windows.Forms.Label();
            this.lblExpensesTitle = new System.Windows.Forms.Label();
            this.panelRevence = new System.Windows.Forms.Panel();
            this.lblRevence = new System.Windows.Forms.Label();
            this.lblRevenceTitle = new System.Windows.Forms.Label();
            this.chartStats = new DevExpress.XtraCharts.ChartControl();
            this.panelFinance = new System.Windows.Forms.Panel();
            this.panelCards = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblReceptionExpenses = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblShopExpenses = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCarsNewCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblReceptionsCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblCarsTodayCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblCarsRepairedCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblCarsReleasedCount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panelStat = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.chartPerformance = new DevExpress.XtraCharts.ChartControl();
            this.panelPerformance = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblOneDayAgo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lblThreeDaysAgo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.lblSevenDaysAgo = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartFinance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel3)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panelProfit.SuspendLayout();
            this.panelExpnese.SuspendLayout();
            this.panelRevence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel4)).BeginInit();
            this.panelFinance.SuspendLayout();
            this.panelCards.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panelStat.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPerformance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView2)).BeginInit();
            this.panelPerformance.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartFinance
            // 
            this.chartFinance.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartFinance.Breadcrumbs.DXFont = new DevExpress.Drawing.DXFont("Vazirmatin", 10F);
            this.chartFinance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartFinance.EmptyChartText.DXFont = new DevExpress.Drawing.DXFont("Vazirmatin", 12F);
            this.chartFinance.Legend.DXFont = new DevExpress.Drawing.DXFont("Vazirmatin", 8F);
            this.chartFinance.Legend.Title.DXFont = new DevExpress.Drawing.DXFont("Vazirmatin", 10F);
            this.chartFinance.Location = new System.Drawing.Point(0, 0);
            this.chartFinance.Margin = new System.Windows.Forms.Padding(10);
            this.chartFinance.Name = "chartFinance";
            this.chartFinance.Padding.Bottom = 15;
            this.chartFinance.Padding.Left = 15;
            this.chartFinance.Padding.Right = 15;
            this.chartFinance.Padding.Top = 15;
            this.chartFinance.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            sideBySideBarSeriesLabel3.DXFont = new DevExpress.Drawing.DXFont("Vazirmatin", 8F);
            this.chartFinance.SeriesTemplate.Label = sideBySideBarSeriesLabel3;
            this.chartFinance.Size = new System.Drawing.Size(723, 216);
            this.chartFinance.SmallChartText.DXFont = new DevExpress.Drawing.DXFont("Vazirmatin", 12F);
            this.chartFinance.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Vazirmatn SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderTitle.Location = new System.Drawing.Point(1124, 0);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Padding = new System.Windows.Forms.Padding(10);
            this.lblHeaderTitle.Size = new System.Drawing.Size(239, 47);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "گزارش عملکرد روزانه مورخ [تاریخ]";
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.lblHeaderTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1363, 52);
            this.panelHeader.TabIndex = 4;
            // 
            // panelProfit
            // 
            this.panelProfit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProfit.BackColor = System.Drawing.Color.Honeydew;
            this.panelProfit.Controls.Add(this.lblProfit);
            this.panelProfit.Controls.Add(this.lblProfitTitle);
            this.panelProfit.Location = new System.Drawing.Point(20, 15);
            this.panelProfit.Name = "panelProfit";
            this.panelProfit.Padding = new System.Windows.Forms.Padding(15);
            this.panelProfit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelProfit.Size = new System.Drawing.Size(196, 181);
            this.panelProfit.TabIndex = 5;
            // 
            // lblProfit
            // 
            this.lblProfit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblProfit.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfit.Location = new System.Drawing.Point(15, 104);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Padding = new System.Windows.Forms.Padding(5);
            this.lblProfit.Size = new System.Drawing.Size(166, 62);
            this.lblProfit.TabIndex = 1;
            this.lblProfit.Text = "[مبلغ]";
            this.lblProfit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProfitTitle
            // 
            this.lblProfitTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProfitTitle.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfitTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProfitTitle.Location = new System.Drawing.Point(15, 15);
            this.lblProfitTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblProfitTitle.Name = "lblProfitTitle";
            this.lblProfitTitle.Padding = new System.Windows.Forms.Padding(8);
            this.lblProfitTitle.Size = new System.Drawing.Size(166, 68);
            this.lblProfitTitle.TabIndex = 0;
            this.lblProfitTitle.Text = "مجموع سود";
            this.lblProfitTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelExpnese
            // 
            this.panelExpnese.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelExpnese.BackColor = System.Drawing.Color.Coral;
            this.panelExpnese.Controls.Add(this.lblExpenses);
            this.panelExpnese.Controls.Add(this.lblExpensesTitle);
            this.panelExpnese.Location = new System.Drawing.Point(227, 72);
            this.panelExpnese.Name = "panelExpnese";
            this.panelExpnese.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelExpnese.Size = new System.Drawing.Size(196, 68);
            this.panelExpnese.TabIndex = 4;
            // 
            // lblExpenses
            // 
            this.lblExpenses.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblExpenses.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpenses.Location = new System.Drawing.Point(0, 32);
            this.lblExpenses.Name = "lblExpenses";
            this.lblExpenses.Padding = new System.Windows.Forms.Padding(5);
            this.lblExpenses.Size = new System.Drawing.Size(196, 36);
            this.lblExpenses.TabIndex = 1;
            this.lblExpenses.Text = "[مبلغ]";
            this.lblExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExpensesTitle
            // 
            this.lblExpensesTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblExpensesTitle.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpensesTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblExpensesTitle.Location = new System.Drawing.Point(0, 0);
            this.lblExpensesTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblExpensesTitle.Name = "lblExpensesTitle";
            this.lblExpensesTitle.Padding = new System.Windows.Forms.Padding(8);
            this.lblExpensesTitle.Size = new System.Drawing.Size(196, 35);
            this.lblExpensesTitle.TabIndex = 0;
            this.lblExpensesTitle.Text = "مجموع هزینه ها";
            this.lblExpensesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelRevence
            // 
            this.panelRevence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRevence.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelRevence.Controls.Add(this.lblRevence);
            this.panelRevence.Controls.Add(this.lblRevenceTitle);
            this.panelRevence.Location = new System.Drawing.Point(429, 15);
            this.panelRevence.Name = "panelRevence";
            this.panelRevence.Padding = new System.Windows.Forms.Padding(15);
            this.panelRevence.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelRevence.Size = new System.Drawing.Size(196, 181);
            this.panelRevence.TabIndex = 1;
            // 
            // lblRevence
            // 
            this.lblRevence.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblRevence.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevence.ForeColor = System.Drawing.Color.Black;
            this.lblRevence.Location = new System.Drawing.Point(15, 104);
            this.lblRevence.Name = "lblRevence";
            this.lblRevence.Padding = new System.Windows.Forms.Padding(5);
            this.lblRevence.Size = new System.Drawing.Size(166, 62);
            this.lblRevence.TabIndex = 1;
            this.lblRevence.Text = "[مبلغ]";
            this.lblRevence.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRevenceTitle
            // 
            this.lblRevenceTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRevenceTitle.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenceTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRevenceTitle.Location = new System.Drawing.Point(15, 15);
            this.lblRevenceTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblRevenceTitle.Name = "lblRevenceTitle";
            this.lblRevenceTitle.Padding = new System.Windows.Forms.Padding(8);
            this.lblRevenceTitle.Size = new System.Drawing.Size(166, 68);
            this.lblRevenceTitle.TabIndex = 0;
            this.lblRevenceTitle.Text = "مجموعه درآمد ها";
            this.lblRevenceTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartStats
            // 
            this.chartStats.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartStats.Breadcrumbs.DXFont = new DevExpress.Drawing.DXFont("Vazirmatin", 10F);
            this.chartStats.CrosshairOptions.CrosshairLabelTextOptions.DXFont = new DevExpress.Drawing.DXFont("Vazirmatin", 18F);
            this.chartStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartStats.EmptyChartText.DXFont = new DevExpress.Drawing.DXFont("Vazirmatin", 12F);
            this.chartStats.Legend.DXFont = new DevExpress.Drawing.DXFont("Vazirmatin", 8F);
            this.chartStats.Location = new System.Drawing.Point(0, 47);
            this.chartStats.Margin = new System.Windows.Forms.Padding(10);
            this.chartStats.Name = "chartStats";
            this.chartStats.Padding.Bottom = 15;
            this.chartStats.Padding.Left = 15;
            this.chartStats.Padding.Right = 15;
            this.chartStats.Padding.Top = 15;
            this.chartStats.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            sideBySideBarSeriesLabel4.DXFont = new DevExpress.Drawing.DXFont("Vazirmatin", 8F);
            this.chartStats.SeriesTemplate.Label = sideBySideBarSeriesLabel4;
            this.chartStats.Size = new System.Drawing.Size(722, 286);
            this.chartStats.SmallChartText.DXFont = new DevExpress.Drawing.DXFont("Vazirmatin", 12F);
            this.chartStats.TabIndex = 2;
            // 
            // panelFinance
            // 
            this.panelFinance.Controls.Add(this.chartFinance);
            this.panelFinance.Controls.Add(this.panelCards);
            this.panelFinance.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFinance.Location = new System.Drawing.Point(0, 52);
            this.panelFinance.Name = "panelFinance";
            this.panelFinance.Size = new System.Drawing.Size(1363, 216);
            this.panelFinance.TabIndex = 6;
            // 
            // panelCards
            // 
            this.panelCards.Controls.Add(this.panel2);
            this.panelCards.Controls.Add(this.panel1);
            this.panelCards.Controls.Add(this.panelProfit);
            this.panelCards.Controls.Add(this.panelExpnese);
            this.panelCards.Controls.Add(this.panelRevence);
            this.panelCards.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelCards.Location = new System.Drawing.Point(723, 0);
            this.panelCards.Name = "panelCards";
            this.panelCards.Size = new System.Drawing.Size(640, 216);
            this.panelCards.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblReceptionExpenses);
            this.panel2.Location = new System.Drawing.Point(227, 15);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(196, 54);
            this.panel2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Vazirmatn", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(2);
            this.label4.Size = new System.Drawing.Size(196, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "هزینه های تعمیرات";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReceptionExpenses
            // 
            this.lblReceptionExpenses.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblReceptionExpenses.Font = new System.Drawing.Font("Vazirmatn", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceptionExpenses.Location = new System.Drawing.Point(0, 22);
            this.lblReceptionExpenses.Name = "lblReceptionExpenses";
            this.lblReceptionExpenses.Padding = new System.Windows.Forms.Padding(2);
            this.lblReceptionExpenses.Size = new System.Drawing.Size(196, 32);
            this.lblReceptionExpenses.TabIndex = 1;
            this.lblReceptionExpenses.Text = "[مبلغ]";
            this.lblReceptionExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.lblShopExpenses);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(227, 143);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(196, 53);
            this.panel1.TabIndex = 6;
            // 
            // lblShopExpenses
            // 
            this.lblShopExpenses.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblShopExpenses.Font = new System.Drawing.Font("Vazirmatn", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShopExpenses.Location = new System.Drawing.Point(0, 21);
            this.lblShopExpenses.Name = "lblShopExpenses";
            this.lblShopExpenses.Padding = new System.Windows.Forms.Padding(5);
            this.lblShopExpenses.Size = new System.Drawing.Size(196, 32);
            this.lblShopExpenses.TabIndex = 1;
            this.lblShopExpenses.Text = "[مبلغ]";
            this.lblShopExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Vazirmatn", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(2);
            this.label2.Size = new System.Drawing.Size(196, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "هزینه های تعمیرگاه";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel3.Controls.Add(this.lblCarsNewCount);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(226, 23);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel3.Size = new System.Drawing.Size(196, 77);
            this.panel3.TabIndex = 7;
            // 
            // lblCarsNewCount
            // 
            this.lblCarsNewCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCarsNewCount.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarsNewCount.Location = new System.Drawing.Point(5, 40);
            this.lblCarsNewCount.Name = "lblCarsNewCount";
            this.lblCarsNewCount.Padding = new System.Windows.Forms.Padding(5);
            this.lblCarsNewCount.Size = new System.Drawing.Size(186, 32);
            this.lblCarsNewCount.TabIndex = 1;
            this.lblCarsNewCount.Text = "[تعداد]";
            this.lblCarsNewCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(5, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(8);
            this.label3.Size = new System.Drawing.Size(186, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "خودروهای جدید";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FloralWhite;
            this.panel4.Controls.Add(this.lblReceptionsCount);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(20, 23);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5);
            this.panel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel4.Size = new System.Drawing.Size(196, 77);
            this.panel4.TabIndex = 8;
            // 
            // lblReceptionsCount
            // 
            this.lblReceptionsCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblReceptionsCount.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceptionsCount.Location = new System.Drawing.Point(5, 40);
            this.lblReceptionsCount.Name = "lblReceptionsCount";
            this.lblReceptionsCount.Padding = new System.Windows.Forms.Padding(5);
            this.lblReceptionsCount.Size = new System.Drawing.Size(186, 32);
            this.lblReceptionsCount.TabIndex = 1;
            this.lblReceptionsCount.Text = "[تعداد]";
            this.lblReceptionsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(5, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(8);
            this.label5.Size = new System.Drawing.Size(186, 35);
            this.label5.TabIndex = 0;
            this.label5.Text = "پذیرش های امروز";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel5.Controls.Add(this.lblCarsTodayCount);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(427, 23);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(5);
            this.panel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel5.Size = new System.Drawing.Size(196, 77);
            this.panel5.TabIndex = 9;
            // 
            // lblCarsTodayCount
            // 
            this.lblCarsTodayCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCarsTodayCount.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarsTodayCount.Location = new System.Drawing.Point(5, 40);
            this.lblCarsTodayCount.Name = "lblCarsTodayCount";
            this.lblCarsTodayCount.Padding = new System.Windows.Forms.Padding(5);
            this.lblCarsTodayCount.Size = new System.Drawing.Size(186, 32);
            this.lblCarsTodayCount.TabIndex = 1;
            this.lblCarsTodayCount.Text = "[تعداد]";
            this.lblCarsTodayCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(5, 5);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(8);
            this.label6.Size = new System.Drawing.Size(186, 35);
            this.label6.TabIndex = 0;
            this.label6.Text = "خودروهای امروز";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel6.Controls.Add(this.lblCarsRepairedCount);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Location = new System.Drawing.Point(226, 189);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(5);
            this.panel6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel6.Size = new System.Drawing.Size(196, 77);
            this.panel6.TabIndex = 10;
            // 
            // lblCarsRepairedCount
            // 
            this.lblCarsRepairedCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCarsRepairedCount.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarsRepairedCount.Location = new System.Drawing.Point(5, 40);
            this.lblCarsRepairedCount.Name = "lblCarsRepairedCount";
            this.lblCarsRepairedCount.Padding = new System.Windows.Forms.Padding(5);
            this.lblCarsRepairedCount.Size = new System.Drawing.Size(186, 32);
            this.lblCarsRepairedCount.TabIndex = 1;
            this.lblCarsRepairedCount.Text = "[تعداد]";
            this.lblCarsRepairedCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(5, 5);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(8);
            this.label8.Size = new System.Drawing.Size(186, 35);
            this.label8.TabIndex = 0;
            this.label8.Text = "خودرو های تعمیر شده";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel7.Controls.Add(this.lblCarsReleasedCount);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Location = new System.Drawing.Point(226, 106);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(5);
            this.panel7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel7.Size = new System.Drawing.Size(196, 77);
            this.panel7.TabIndex = 11;
            // 
            // lblCarsReleasedCount
            // 
            this.lblCarsReleasedCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCarsReleasedCount.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarsReleasedCount.Location = new System.Drawing.Point(5, 40);
            this.lblCarsReleasedCount.Name = "lblCarsReleasedCount";
            this.lblCarsReleasedCount.Padding = new System.Windows.Forms.Padding(5);
            this.lblCarsReleasedCount.Size = new System.Drawing.Size(186, 32);
            this.lblCarsReleasedCount.TabIndex = 1;
            this.lblCarsReleasedCount.Text = "[تعداد]";
            this.lblCarsReleasedCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(5, 5);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(8);
            this.label10.Size = new System.Drawing.Size(186, 35);
            this.label10.TabIndex = 0;
            this.label10.Text = "خودروهای ترخیص شده";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelStat
            // 
            this.panelStat.Controls.Add(this.chartStats);
            this.panelStat.Controls.Add(this.panel9);
            this.panelStat.Controls.Add(this.label11);
            this.panelStat.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStat.Location = new System.Drawing.Point(0, 542);
            this.panelStat.Name = "panelStat";
            this.panelStat.Size = new System.Drawing.Size(1363, 333);
            this.panelStat.TabIndex = 12;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel7);
            this.panel9.Controls.Add(this.panel6);
            this.panel9.Controls.Add(this.panel5);
            this.panel9.Controls.Add(this.panel3);
            this.panel9.Controls.Add(this.panel4);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(722, 47);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(641, 286);
            this.panel9.TabIndex = 12;
            // 
            // chartPerformance
            // 
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            this.chartPerformance.Diagram = xyDiagram2;
            this.chartPerformance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartPerformance.Location = new System.Drawing.Point(0, 47);
            this.chartPerformance.Name = "chartPerformance";
            series2.Name = "Series 1";
            series2.SeriesID = 0;
            series2.View = splineSeriesView2;
            this.chartPerformance.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.chartPerformance.Size = new System.Drawing.Size(1043, 227);
            this.chartPerformance.TabIndex = 13;
            // 
            // panelPerformance
            // 
            this.panelPerformance.Controls.Add(this.chartPerformance);
            this.panelPerformance.Controls.Add(this.panel8);
            this.panelPerformance.Controls.Add(this.label1);
            this.panelPerformance.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPerformance.Location = new System.Drawing.Point(0, 268);
            this.panelPerformance.Name = "panelPerformance";
            this.panelPerformance.Size = new System.Drawing.Size(1363, 274);
            this.panelPerformance.TabIndex = 14;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel11);
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Controls.Add(this.panel12);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(1043, 47);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(320, 227);
            this.panel8.TabIndex = 14;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.AliceBlue;
            this.panel10.Controls.Add(this.lblOneDayAgo);
            this.panel10.Controls.Add(this.label7);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(5);
            this.panel10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel10.Size = new System.Drawing.Size(320, 77);
            this.panel10.TabIndex = 11;
            // 
            // lblOneDayAgo
            // 
            this.lblOneDayAgo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblOneDayAgo.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOneDayAgo.Location = new System.Drawing.Point(5, 40);
            this.lblOneDayAgo.Name = "lblOneDayAgo";
            this.lblOneDayAgo.Padding = new System.Windows.Forms.Padding(5);
            this.lblOneDayAgo.Size = new System.Drawing.Size(310, 32);
            this.lblOneDayAgo.TabIndex = 1;
            this.lblOneDayAgo.Text = "[درصد]";
            this.lblOneDayAgo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(5, 5);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(8);
            this.label7.Size = new System.Drawing.Size(310, 35);
            this.label7.TabIndex = 0;
            this.label7.Text = "عملکرد نسبت به دیروز";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.AliceBlue;
            this.panel11.Controls.Add(this.lblThreeDaysAgo);
            this.panel11.Controls.Add(this.label9);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel11.Location = new System.Drawing.Point(0, 77);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(5);
            this.panel11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel11.Size = new System.Drawing.Size(320, 73);
            this.panel11.TabIndex = 12;
            // 
            // lblThreeDaysAgo
            // 
            this.lblThreeDaysAgo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblThreeDaysAgo.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThreeDaysAgo.Location = new System.Drawing.Point(5, 36);
            this.lblThreeDaysAgo.Name = "lblThreeDaysAgo";
            this.lblThreeDaysAgo.Padding = new System.Windows.Forms.Padding(5);
            this.lblThreeDaysAgo.Size = new System.Drawing.Size(310, 32);
            this.lblThreeDaysAgo.TabIndex = 1;
            this.lblThreeDaysAgo.Text = "[درصد]";
            this.lblThreeDaysAgo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(5, 5);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(8);
            this.label9.Size = new System.Drawing.Size(310, 35);
            this.label9.TabIndex = 0;
            this.label9.Text = "عملکرد نسبت به 3 روز گذشته";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.AliceBlue;
            this.panel12.Controls.Add(this.lblSevenDaysAgo);
            this.panel12.Controls.Add(this.label12);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(0, 150);
            this.panel12.Name = "panel12";
            this.panel12.Padding = new System.Windows.Forms.Padding(5);
            this.panel12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel12.Size = new System.Drawing.Size(320, 77);
            this.panel12.TabIndex = 13;
            // 
            // lblSevenDaysAgo
            // 
            this.lblSevenDaysAgo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSevenDaysAgo.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSevenDaysAgo.Location = new System.Drawing.Point(5, 40);
            this.lblSevenDaysAgo.Name = "lblSevenDaysAgo";
            this.lblSevenDaysAgo.Padding = new System.Windows.Forms.Padding(5);
            this.lblSevenDaysAgo.Size = new System.Drawing.Size(310, 32);
            this.lblSevenDaysAgo.TabIndex = 1;
            this.lblSevenDaysAgo.Text = "[درصد]";
            this.lblSevenDaysAgo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(5, 5);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(8);
            this.label12.Size = new System.Drawing.Size(310, 35);
            this.label12.TabIndex = 0;
            this.label12.Text = "عملکرد نسبت به 7 روز گذشته";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Vazirmatn SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(1363, 47);
            this.label1.TabIndex = 15;
            this.label1.Text = "نمودار پیشرفت 7 روزه تعمیرگاه";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Vazirmatn SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(10);
            this.label11.Size = new System.Drawing.Size(1363, 47);
            this.label11.TabIndex = 16;
            this.label11.Text = "آمار و ارقام عملکردی امروز تعمیرگاه";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DailyDashboardPage
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panelStat);
            this.Controls.Add(this.panelPerformance);
            this.Controls.Add(this.panelFinance);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DailyDashboardPage";
            this.Size = new System.Drawing.Size(1363, 2000);
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFinance)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelProfit.ResumeLayout(false);
            this.panelExpnese.ResumeLayout(false);
            this.panelRevence.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStats)).EndInit();
            this.panelFinance.ResumeLayout(false);
            this.panelCards.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panelStat.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPerformance)).EndInit();
            this.panelPerformance.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.ResumeLayout(false);

        }
      
        private DevExpress.XtraCharts.ChartControl chartFinance;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelRevence;
        private System.Windows.Forms.Label lblRevence;
        private System.Windows.Forms.Label lblRevenceTitle;
        private System.Windows.Forms.Panel panelProfit;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.Label lblProfitTitle;
        private System.Windows.Forms.Panel panelExpnese;
        private System.Windows.Forms.Label lblExpenses;
        private System.Windows.Forms.Label lblExpensesTitle;
        private DevExpress.XtraCharts.ChartControl chartStats;
        private System.Windows.Forms.Panel panelFinance;
        private System.Windows.Forms.Panel panelCards;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblReceptionExpenses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblShopExpenses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblCarsNewCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblReceptionsCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblCarsTodayCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblCarsRepairedCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblCarsReleasedCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelStat;
        private System.Windows.Forms.Panel panel9;
        private DevExpress.XtraCharts.ChartControl chartPerformance;
        private System.Windows.Forms.Panel panelPerformance;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lblOneDayAgo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label lblSevenDaysAgo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label lblThreeDaysAgo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
    }
}




