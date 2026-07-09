using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraCharts;
using AutoLedger.Domain;
using AutoLedger.Data;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;

namespace AutoLedger.App.FormsView
{
    public partial class DailyDashboardPage : UserControl
    {
        private DailyLedgerSummary _ledger;
        private List<DailyLedgerSummary> _ledgers;


        private double _totalWeeklyScore = 0;

        public DailyDashboardPage()
        {
            InitializeComponent();
            using (AutoLedgerContext db = new AutoLedgerContext())
            {
           
                DateTime sevenDaysAgo = DateTime.Now.Date.AddDays(-6);

                _ledgers = db.DailySummaries
                    .Where(a => a.Date >= sevenDaysAgo)
                    .OrderByDescending(a => a.Date)
                    .AsNoTracking()
                    .ToList();

                _ledger = _ledgers.FirstOrDefault(a => a.Date.Date == DateTime.Now.Date) ?? new DailyLedgerSummary();
            }

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

            SetupFinancialChart();
            SetupStatsChart();
            SetupPerformanceTrendChart(); 
        }


        private double CalculatePerformanceScore(DailyLedgerSummary dayLedger)
        {
            try
            {
                if (dayLedger == null) return 0;

                double financialScore = (double)(dayLedger.Profit / 1000000m) * 5;

                double operationalScore = (dayLedger.NewCarsRegistered * 1) +
                                        (dayLedger.ReceptionsOpened * 2);

                return financialScore + operationalScore;
            }
            catch
            {
                return 0;
            }
        }
        private void UpdateGrowthLabels()
        {
            var scores = _ledgers.OrderByDescending(x => x.Date)
                                 .Select(x => CalculatePerformanceScore(x))
                                 .ToList();

            if (scores.Count < 2) return;

            double today = scores[0];

            Action<Label, double, double> SetGrowthLabel = (lbl, current, previous) =>
            {
                if (previous == 0) { lbl.Text = "-"; return; }

                double growth = ((current - previous) / Math.Abs(previous)) * 100;
                lbl.Text = $"{(growth >= 0 ? "+" : "")}{growth:F1}%";
                lbl.ForeColor = growth >= 0 ? Color.FromArgb(46, 204, 113) : Color.FromArgb(231, 76, 60);
            };

            if (scores.Count > 1) SetGrowthLabel(lblOneDayAgo, today, scores[1]);

            if (scores.Count > 3) SetGrowthLabel(lblThreeDaysAgo, today, scores[3]);

            if (scores.Count > 6) SetGrowthLabel(lblSevenDaysAgo, today, scores[6]);
        }
        private void SetupPerformanceTrendChart()
        {
 
            chartPerformance.Series.Clear();
            chartPerformance.Titles.Clear();
            chartPerformance.Titles.Add(new ChartTitle { Text = "عملکرد امروز نسبت به هفت روز گذشته", Font = new Font("Vazirmatn", 12, FontStyle.Bold) });

            Series series = new Series("امتیاز روزانه", ViewType.Spline);


            var orderedLedgers = _ledgers.OrderBy(x => x.Day).ToList();
            _totalWeeklyScore = 0; 

            foreach (var daySummary in orderedLedgers)
            {
                // محاسبه امتیاز روز
                double dayScore = Math.Round(CalculatePerformanceScore(daySummary), 1);
                _totalWeeklyScore += dayScore;


                series.Points.Add(new SeriesPoint(daySummary.Day.ToString() + "امتیاز", dayScore));
            }

            chartPerformance.Series.Add(series);

            SplineSeriesView view = (SplineSeriesView)series.View;
            view.Color = Color.FromArgb(142, 68, 173); 
            view.LineStyle.Thickness = 3; 
            view.MarkerVisibility = DevExpress.Utils.DefaultBoolean.True; 
            view.LineMarkerOptions.Kind = MarkerKind.Star; 
            view.LineMarkerOptions.Size = 10; 
            view.LineMarkerOptions.Color = Color.FromArgb(241, 196, 15); 


            series.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            PointSeriesLabel label = (PointSeriesLabel)series.Label;
            label.TextPattern = "{V}";
            label.Font = new Font("Vazirmatn", 9, FontStyle.Bold);
            label.BackColor = Color.White;
            label.TextColor = Color.Black;

            chartPerformance.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            UpdateGrowthLabels();
        }

        private void SetupFinancialChart()
        {
            chartFinance.Series.Clear();
            chartFinance.Titles.Clear();
            chartFinance.Titles.Add(new ChartTitle { Text = "تحلیل درآمد و هزینه‌ها", Font = new Font("Vazirmatn", 12, FontStyle.Bold) });

            Series series = new Series("مبالغ مالی", ViewType.Bar);

            series.Points.Add(new SeriesPoint("درآمد کل", _ledger.TotalRevenue));
            series.Points.Add(new SeriesPoint("هزینه‌های تعمیرگاه", _ledger.ShopExpenses));
            series.Points.Add(new SeriesPoint("هزینه‌های پذیرش", _ledger.ReceptionExpenses));
            series.Points.Add(new SeriesPoint("سود خالص", _ledger.Profit));

            chartFinance.Series.Add(series);

            series.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            BarSeriesLabel label = (BarSeriesLabel)series.Label;
            label.TextPattern = "{V:N0} T";
            label.Font = new Font("Vazirmatn", 9);

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

            series.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            DoughnutSeriesLabel label = (DoughnutSeriesLabel)series.Label;
            label.TextPattern = "{A}: {V}";
            label.Font = new Font("Vazirmatn", 10, FontStyle.Bold);
            label.Position = PieSeriesLabelPosition.TwoColumns;

            DoughnutSeriesView view = (DoughnutSeriesView)series.View;
            view.HoleRadiusPercent = 40;

            chartStats.Legend.Font = new Font("Vazirmatn", 9);
            chartStats.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Center;
            chartStats.Legend.AlignmentVertical = LegendAlignmentVertical.BottomOutside;
            chartStats.Legend.Direction = LegendDirection.LeftToRight;
        }
    }
}