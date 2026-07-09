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
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel2 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblShopExpenses = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblReceptionExpenses = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.chartFinance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panelProfit.SuspendLayout();
            this.panelExpnese.SuspendLayout();
            this.panelRevence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).BeginInit();
            this.panelFinance.SuspendLayout();
            this.panelCards.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panelStat.SuspendLayout();
            this.panel9.SuspendLayout();
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
            sideBySideBarSeriesLabel1.DXFont = new DevExpress.Drawing.DXFont("Vazirmatin", 8F);
            this.chartFinance.SeriesTemplate.Label = sideBySideBarSeriesLabel1;
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
            this.panelProfit.BackColor = System.Drawing.Color.DarkSeaGreen;
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
            this.panelRevence.BackColor = System.Drawing.Color.DeepSkyBlue;
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
            this.chartStats.Location = new System.Drawing.Point(0, 0);
            this.chartStats.Margin = new System.Windows.Forms.Padding(10);
            this.chartStats.Name = "chartStats";
            this.chartStats.Padding.Bottom = 15;
            this.chartStats.Padding.Left = 15;
            this.chartStats.Padding.Right = 15;
            this.chartStats.Padding.Top = 15;
            this.chartStats.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            sideBySideBarSeriesLabel2.DXFont = new DevExpress.Drawing.DXFont("Vazirmatin", 8F);
            this.chartStats.SeriesTemplate.Label = sideBySideBarSeriesLabel2;
            this.chartStats.Size = new System.Drawing.Size(722, 278);
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightSalmon;
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
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.LightSalmon;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblReceptionExpenses);
            this.panel2.Location = new System.Drawing.Point(227, 15);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(196, 54);
            this.panel2.TabIndex = 7;
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
            this.panelStat.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStat.Location = new System.Drawing.Point(0, 268);
            this.panelStat.Name = "panelStat";
            this.panelStat.Size = new System.Drawing.Size(1363, 278);
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
            this.panel9.Location = new System.Drawing.Point(722, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(641, 278);
            this.panel9.TabIndex = 12;
            // 
            // DailyDashboardPage
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panelStat);
            this.Controls.Add(this.panelFinance);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DailyDashboardPage";
            this.Size = new System.Drawing.Size(1363, 787);
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFinance)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelProfit.ResumeLayout(false);
            this.panelExpnese.ResumeLayout(false);
            this.panelRevence.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStats)).EndInit();
            this.panelFinance.ResumeLayout(false);
            this.panelCards.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panelStat.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
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
    }
}




