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
        private DateTime _currentViewDate;
        public DailyDashboardPage()
        {
            InitializeComponent();

            _currentViewDate = DateTime.Now.Date;

            this.btnBackDay.Click += BtnBackDay_Click;
            this.btnNextDay.Click += BtnNextDay_Click;
            this.btnRefresh.Click += BtnRefresh_Click;

            LoadDashboard(_currentViewDate);
        }

        private void BtnBackDay_Click(object sender, EventArgs e)
        {
            _currentViewDate = _currentViewDate.AddDays(-1);
            LoadDashboard(_currentViewDate);
        }

        private void BtnNextDay_Click(object sender, EventArgs e)
        {
            _currentViewDate = _currentViewDate.AddDays(1);
            LoadDashboard(_currentViewDate);
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadDashboard(_currentViewDate);
        }


        public void LoadDashboard(DateTime selectedDate)
        {
            _currentViewDate = selectedDate.Date;

            DateTime targetDate = _currentViewDate;
            DateTime startDate = targetDate.AddDays(-6);

            using (AutoLedgerContext db = new AutoLedgerContext())
            {
                var dbLedgers = db.DailySummaries
                    .Where(a => a.Date >= startDate && a.Date <= targetDate)
                    .AsNoTracking()
                    .ToList();

                _ledgers = Enumerable.Range(0, 7)
                    .Select(offset => startDate.AddDays(offset))
                    .Select(date => dbLedgers.FirstOrDefault(l => l.Date.Date == date)
                                    ?? new DailyLedgerSummary
                                    {
                                        Date = date,
                                        Day = date.Day,
                                        Month = date.Month,
                                        Year = date.Year
                                    })
                    .ToList();

                _ledger = _ledgers.Last();

           

                bool hasOlderData = db.DailySummaries.Any(a => a.Date < targetDate);

                btnBackDay.Enabled = hasOlderData;

                btnNextDay.Enabled = targetDate < DateTime.Now.Date;
            }

            BindUI();
        }

        private void BindUI()
        {
            // Bind Header and Financial Labels
            lblHeaderTitle.Text = $"گزارش عملکرد روزانه {_ledger.Date.ToShamsiLong()}";
            lblProfit.Text = $"{_ledger.Profit:N0} تومان";
            lblRevence.Text = $"{_ledger.TotalRevenue:N0} تومان";
            lblExpenses.Text = $"{_ledger.TotalExpenses:N0} تومان";
            lblShopExpenses.Text = $"{_ledger.ShopExpenses:N0} تومان";
            lblReceptionExpenses.Text = $"{_ledger.ReceptionExpenses:N0} تومان";

            // Update Profit Card Color
            lblProfitTitle.Text = _ledger.Profit >= 0 ? "مجموع سود خالص" : "مجموع زیان و ضرر";
            panelProfit.BackColor = _ledger.Profit >= 0 ? Color.Honeydew : Color.MistyRose;

            // Bind Operational Statistics
            lblCarsTodayCount.Text = _ledger.ReceptionsOpened + " عدد";
            lblCarsNewCount.Text = _ledger.NewCarsRegistered + " عدد";
            lblCarsReleasedCount.Text = _ledger.ReceptionsReleased + " عدد";
            lblCarsRepairedCount.Text = _ledger.ReceptionsRepaired + " عدد";
            lblReceptionsCount.Text = _ledger.ReceptionsOpened + " عدد";

            // Refresh all visually detailed charts
            SetupFinancialChart();
            SetupStatsChart();
            SetupPerformanceTrendChart();
        }

        private double CalculatePerformanceScore(DailyLedgerSummary dayLedger)
        {
            try
            {
                if (dayLedger == null) return 0;

                // 5 points for every 1 million in profit
                double financialScore = (double)(dayLedger.Profit / 1000000m) * 5;

                // Operational weightings
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
            // Order descending so index 0 is the target date, index 1 is target-1, etc.
            // Since we padded the list, we are guaranteed to have exactly 7 items here.
            var scores = _ledgers.OrderByDescending(x => x.Date)
                                 .Select(x => CalculatePerformanceScore(x))
                                 .ToList();

            if (scores.Count < 2) return;

            double targetDayScore = scores[0];

            Action<Label, double, double> SetGrowthLabel = (lbl, current, previous) =>
            {
                if (previous == 0)
                {
                    lbl.Text = "-";
                    lbl.ForeColor = Color.Gray;
                    return;
                }

                double growth = ((current - previous) / Math.Abs(previous)) * 100;
                lbl.Text = $"{(growth >= 0 ? "+" : "")}{growth:F1}%";
                lbl.ForeColor = growth >= 0 ? Color.FromArgb(46, 204, 113) : Color.FromArgb(231, 76, 60);
            };

            // Calculate growth compared to previous days
            SetGrowthLabel(lblOneDayAgo, targetDayScore, scores[1]);    // Yesterday
            SetGrowthLabel(lblThreeDaysAgo, targetDayScore, scores[3]); // 3 Days Ago
            SetGrowthLabel(lblSevenDaysAgo, targetDayScore, scores[6]); // 7 Days Ago
        }

        private void SetupPerformanceTrendChart()
        {
            chartPerformance.Series.Clear();
            chartPerformance.Titles.Clear();
            chartPerformance.Titles.Add(new ChartTitle { Text = "عملکرد هفت روز منتهی به تاریخ انتخاب شده", Font = new Font("Vazirmatn", 12, FontStyle.Bold) });

            Series series = new Series("امتیاز روزانه", ViewType.Spline);
            series.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            _totalWeeklyScore = 0;

            // The list is already chronologically sorted due to the padding logic in LoadDashboard
            foreach (var daySummary in _ledgers)
            {
                double dayScore = Math.Round(CalculatePerformanceScore(daySummary), 1);
                _totalWeeklyScore += dayScore;

                // Use a formatted date instead of just Day to prevent chart breaking during month transitions
                string xAxisLabel = daySummary.Date.ToShamsiDayMonth();
               var s= new SeriesPoint(xAxisLabel, dayScore);
                
                series.Points.Add(s);
            }

            chartPerformance.Series.Add(series);

            // Configure Spline appearance
            SplineSeriesView view = (SplineSeriesView)series.View;
            view.Color = Color.FromArgb(142, 68, 173);
            view.LineStyle.Thickness = 3;
            view.MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
            view.LineMarkerOptions.Kind = MarkerKind.Star;
            view.LineMarkerOptions.Size = 10;
            view.LineMarkerOptions.Color = Color.FromArgb(241, 196, 15);

            // Configure point labels
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

            // Add data points
            series.Points.Add(new SeriesPoint("درآمد کل", _ledger.TotalRevenue));
            series.Points.Add(new SeriesPoint("هزینه‌های تعمیرگاه", _ledger.ShopExpenses));
            series.Points.Add(new SeriesPoint("هزینه‌های پذیرش", _ledger.ReceptionExpenses));
            series.Points.Add(new SeriesPoint("سود خالص", _ledger.Profit));

            chartFinance.Series.Add(series);

            // Configure bar labels
            series.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            BarSeriesLabel label = (BarSeriesLabel)series.Label;
            label.TextPattern = "{V:N0} T";
            label.Font = new Font("Vazirmatn", 9);

            // Set custom colors for each bar
            BarSeriesView view = (BarSeriesView)series.View;
            view.ColorEach = true;

            // Remove previous event handler to prevent memory leaks if called multiple times
            chartFinance.CustomDrawSeriesPoint -= ChartFinance_CustomDrawSeriesPoint;
            chartFinance.CustomDrawSeriesPoint += ChartFinance_CustomDrawSeriesPoint;

            chartFinance.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
        }

        // Extracted event handler to prevent subscribing multiple times during reloads
        private void ChartFinance_CustomDrawSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e)
        {
            switch (e.SeriesPoint.Argument)
            {
                case "درآمد کل": e.SeriesDrawOptions.Color = Color.FromArgb(52, 152, 219); break;
                case "هزینه‌های تعمیرگاه": e.SeriesDrawOptions.Color = Color.FromArgb(243, 156, 18); break;
                case "هزینه‌های پذیرش": e.SeriesDrawOptions.Color = Color.FromArgb(230, 126, 34); break;
                case "سود خالص": e.SeriesDrawOptions.Color = _ledger.Profit >= 0 ? Color.FromArgb(46, 204, 113) : Color.FromArgb(231, 76, 60); break;
            }
        }

        private void SetupStatsChart()
        {
            chartStats.Series.Clear();
            chartStats.Titles.Clear();
            chartStats.Titles.Add(new ChartTitle { Text = "آمار پذیرش ها", Font = new Font("Vazirmatn", 12, FontStyle.Bold) });

            Series series = new Series("آمار", ViewType.NestedDoughnut);

            // Add data points
            series.Points.Add(new SeriesPoint("پذیرش‌های باز", _ledger.ReceptionsOpened));
            series.Points.Add(new SeriesPoint("تعمیر شده", _ledger.ReceptionsRepaired));
            series.Points.Add(new SeriesPoint("ترخیص شده", _ledger.ReceptionsReleased));

            chartStats.Series.Add(series);

            // Configure Doughnut labels
            series.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            DoughnutSeriesLabel label = (DoughnutSeriesLabel)series.Label;
            label.TextPattern = "{A}: {V}";
            label.Font = new Font("Vazirmatn", 10, FontStyle.Bold);
            label.Position = PieSeriesLabelPosition.TwoColumns;

            // Configure Doughnut appearance
            DoughnutSeriesView view = (DoughnutSeriesView)series.View;
            view.HoleRadiusPercent = 40;
            
            // Configure Legend
            chartStats.Legend.Font = new Font("Vazirmatn", 9);
            chartStats.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.RightOutside;
            chartStats.Legend.AlignmentVertical = LegendAlignmentVertical.Top;
            chartStats.Legend.Direction = LegendDirection.LeftToRight;
            
        }
    }
}