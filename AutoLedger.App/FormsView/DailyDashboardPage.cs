using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraCharts;
using AutoLedger.Domain;

namespace AutoLedger.App.FormsView
{
    public partial class DailyDashboardPage :UserControl
    {
        private DailyLedgerSummary _ledger;

        public DailyDashboardPage(DailyLedgerSummary ledger)
        {
            InitializeComponent();
            _ledger = ledger ?? new DailyLedgerSummary();

            lblHeaderTitle.Text = $"گزارش عملکرد روزانه {_ledger.Date.ToShamsiLong()}";
            lblProfit.Text = $"{_ledger.Profit:N0} تومان";
            lblRevence.Text = $"{_ledger.TotalRevenue:N0} تومان";
            lblExpenses.Text = $"{_ledger.TotalExpenses:N0} تومان";

            lblShopExpenses.Text = $"{_ledger.ShopExpenses:N0} تومان";
            lblReceptionExpenses.Text = $"{_ledger.ReceptionExpenses:N0} تومان";

            lblProfitTitle.Text = _ledger.Profit >= 0 ? "مجموع سود خالص" : "مجموع زیان و ضرر";
            panelProfit.BackColor = _ledger.Profit >= 0 ? Color.FromArgb(46, 204, 113) : Color.FromArgb(231, 76, 60);

            lblCarsTodayCount.Text = _ledger.ReceptionsOpened + " عدد";
            lblCarsNewCount.Text = _ledger.NewCarsRegistered + " عدد";
            lblCarsReleasedCount.Text = _ledger.ReceptionsReleased + " عدد";
            lblCarsRepairedCount.Text = _ledger.ReceptionsRepaired + " عدد";
            lblReceptionsCount.Text = _ledger.ReceptionsOpened + " عدد";

            //lblProfitTitle
            SetupFinancialChart();


            SetupStatsChart();
        }


        private void SetupFinancialChart()
        {
            chartFinance.Series.Clear();
            chartFinance.Titles.Clear();
            chartFinance.Titles.Add(new ChartTitle { Text = "تحلیل درآمد و هزینه‌ها", Font = new Font("Vazirmatn", 12, FontStyle.Bold) });

            Series series = new Series("مبالغ مالی", ViewType.Bar);

            // افزودن نقاط داده
            series.Points.Add(new SeriesPoint("درآمد کل", _ledger.TotalRevenue));
            series.Points.Add(new SeriesPoint("هزینه‌های تعمیرگاه", _ledger.ShopExpenses));
            series.Points.Add(new SeriesPoint("هزینه‌های پذیرش", _ledger.ReceptionExpenses));
            series.Points.Add(new SeriesPoint("سود خالص", _ledger.Profit));

            chartFinance.Series.Add(series);

            // تنظیمات ظاهری نمودار میله‌ای
            series.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            BarSeriesLabel label = (BarSeriesLabel)series.Label;
            label.TextPattern = "{V:N0} T"; // نمایش مقادیر با جداکننده
            label.Font = new Font("Vazirmatn", 9);

            // رنگ‌بندی سفارشی ستون‌ها
            BarSeriesView view = (BarSeriesView)series.View;
            view.ColorEach = true;
            chartFinance.CustomDrawSeriesPoint += (s, e) =>
            {
                switch (e.SeriesPoint.Argument)
                {
                    case "درآمد کل": e.SeriesDrawOptions.Color = Color.FromArgb(52, 152, 219); break;
                    case "هزینه‌های تعمیرگاه": e.SeriesDrawOptions.Color = Color.FromArgb(243, 156, 18); break;
                    case "هزینه‌های پذیرش": e.SeriesDrawOptions.Color = Color.FromArgb(230, 126, 34); break;
                    case "سود خالص": e.SeriesDrawOptions.Color = _ledger.Profit >= 0 ? Color.FromArgb(46, 204, 113) : Color.FromArgb(231, 76, 60); break;
                }
            };

            chartFinance.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
        }

        private void SetupStatsChart()
        {
            chartStats.Series.Clear();
            chartStats.Titles.Clear();
            chartStats.Titles.Add(new ChartTitle { Text = "آمار پذیرش ها", Font = new Font("Vazirmatn", 12, FontStyle.Bold) });

            Series series = new Series("آمار", ViewType.Doughnut);

            series.Points.Add(new SeriesPoint("پذیرش‌های باز", _ledger.ReceptionsOpened));
            series.Points.Add(new SeriesPoint("تعمیر شده", _ledger.ReceptionsRepaired));
            series.Points.Add(new SeriesPoint("ترخیص شده", _ledger.ReceptionsReleased));

            chartStats.Series.Add(series);

            // تنظیمات ظاهری نمودار دایره‌ای (Doughnut)
            series.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            DoughnutSeriesLabel label = (DoughnutSeriesLabel)series.Label;
            label.TextPattern = "{A}: {V}";
            label.Font = new Font("Vazirmatn", 10, FontStyle.Bold);
            label.Position = PieSeriesLabelPosition.TwoColumns;

            // رنگ‌بندی
            DoughnutSeriesView view = (DoughnutSeriesView)series.View;
            view.HoleRadiusPercent = 40;

            chartStats.Legend.Font = new Font("Vazirmatn", 9);
            chartStats.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Center;
            chartStats.Legend.AlignmentVertical = LegendAlignmentVertical.BottomOutside;
            chartStats.Legend.Direction = LegendDirection.LeftToRight;
        }
    }
}