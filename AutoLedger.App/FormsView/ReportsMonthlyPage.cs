using AutoLedger.Data;
using AutoLedger.Domain;
using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace AutoLedger.App.FormsView
{
    public partial class ReportsMonthlyPage : UserControl
    {
        private DailyLedgerSummary _ledger;
        private List<DailyLedgerSummary> _ledgers;
        private List<DailyLedgerSummary> _currentPeriodDailyData; // NEW: Holds exact daily data for the new chart
        private double _totalScore = 0;
        private DateTime _currentViewDate;

        private readonly bool _isMonthly;
        private readonly PersianCalendar _pc = new PersianCalendar();

        public ReportsMonthlyPage(bool isMonthly = true)
        {
            InitializeComponent();
            _isMonthly = isMonthly;
            _currentViewDate = DateTime.Now.Date;

            this.btnBackMonth.Click += btnBackMonth_Click;
            this.btnNextMonth.Click += btnNextMonth_Click;
            this.btnRefresh.Click += BtnRefresh_Click;

            LoadDashboard(_currentViewDate);
        }

        private void btnBackMonth_Click(object sender, EventArgs e)
        {
            if (_isMonthly)
                _currentViewDate = _pc.AddMonths(_currentViewDate, -1);
            else
                _currentViewDate = _currentViewDate.AddDays(-1);

            LoadDashboard(_currentViewDate);
        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            if (_isMonthly)
                _currentViewDate = _pc.AddMonths(_currentViewDate, 1);
            else
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

            using (AutoLedgerContext db = new AutoLedgerContext())
            {
                if (_isMonthly)
                {
                    LoadMonthlyData(db);
                }
                else
                {
                    LoadWeeklyData(db);
                }
            }

            BindUI();
        }

        private void LoadMonthlyData(AutoLedgerContext db)
        {
            int currentYear = _pc.GetYear(_currentViewDate);
            int currentMonth = _pc.GetMonth(_currentViewDate);

            DateTime currentMonthStart = _pc.ToDateTime(currentYear, currentMonth, 1, 0, 0, 0, 0);
            int daysInMonth = _pc.GetDaysInMonth(currentYear, currentMonth);
            DateTime currentMonthEnd = currentMonthStart.AddDays(daysInMonth - 1);
            DateTime fourMonthsAgoStart = _pc.AddMonths(currentMonthStart, -3);

            var dbData = db.DailySummaries
                .Where(a => a.Date >= fourMonthsAgoStart && a.Date <= currentMonthEnd)
                .AsNoTracking()
                .ToList();

            // NEW: Isolate just the daily records for the current selected month to feed the daily chart
            _currentPeriodDailyData = dbData
                .Where(x => x.Date >= currentMonthStart && x.Date <= currentMonthEnd)
                .ToList();

            var monthlySummaries = dbData
                .GroupBy(x => new { Year = _pc.GetYear(x.Date), Month = _pc.GetMonth(x.Date) })
                .Select(g => new DailyLedgerSummary
                {
                    Date = _pc.ToDateTime(g.Key.Year, g.Key.Month, 1, 0, 0, 0, 0),
                    ShopExpenses = g.Sum(x => x.ShopExpenses),
                    ReceptionExpenses = g.Sum(x => x.ReceptionExpenses),
                    ReceptionsOpened = g.Sum(x => x.ReceptionsOpened),
                    ReceptionsRepaired = g.Sum(x => x.ReceptionsRepaired),
                    ReceptionsReleased = g.Sum(x => x.ReceptionsReleased),
                    NewCarsRegistered = g.Sum(x => x.NewCarsRegistered),
                    ReceptionRevenue = g.Sum(x => x.TotalRevenue),
                }).ToList();

            _ledgers = new List<DailyLedgerSummary>();

            for (int i = 3; i >= 0; i--)
            {
                DateTime targetMonth = _pc.AddMonths(currentMonthStart, -i);
                int y = _pc.GetYear(targetMonth);
                int m = _pc.GetMonth(targetMonth);

                var existing = monthlySummaries.FirstOrDefault(x => _pc.GetYear(x.Date) == y && _pc.GetMonth(x.Date) == m);
                _ledgers.Add(existing ?? new DailyLedgerSummary { Date = targetMonth });
            }

            _ledger = _ledgers.Last();

            btnBackMonth.Enabled = db.DailySummaries.Any(a => a.Date < currentMonthStart);
            DateTime thisRealMonthStart = _pc.ToDateTime(_pc.GetYear(DateTime.Now), _pc.GetMonth(DateTime.Now), 1, 0, 0, 0, 0);
            btnNextMonth.Enabled = currentMonthStart < thisRealMonthStart;
        }

        private void LoadWeeklyData(AutoLedgerContext db)
        {
            DateTime targetDate = _currentViewDate;
            DateTime startDate = targetDate.AddDays(-6);

            var dbLedgers = db.DailySummaries
                .Where(a => a.Date >= startDate && a.Date <= targetDate)
                .AsNoTracking()
                .ToList();

            _ledgers = Enumerable.Range(0, 7)
                .Select(offset => startDate.AddDays(offset))
                .Select(date => dbLedgers.FirstOrDefault(l => l.Date.Date == date)
                                ?? new DailyLedgerSummary { Date = date, Day = date.Day, Month = date.Month, Year = date.Year })
                .ToList();

            // For weekly view, the current period daily data is exactly the 7 days we just generated
            _currentPeriodDailyData = _ledgers.OrderBy(x => x.Date).ToList();
            _ledger = _ledgers.Last();

            btnBackMonth.Enabled = db.DailySummaries.Any(a => a.Date < targetDate);
            btnNextMonth.Enabled = targetDate < DateTime.Now.Date;
        }

        private void BindUI()
        {
            if (_isMonthly)
            {
                string monthName = GetShamsiMonthName(_pc.GetMonth(_ledger.Date));
                lblHeaderTitle.Text = $"گزارش عملکرد ماهانه {monthName} {_pc.GetYear(_ledger.Date)}";
                lblOneDayAgoTitle.Text = "عملکرد نسبت به 1 ماه گذشته";
                lblThreeDaysAgoTitle.Text = "عملکرد نسبت به 2 ماه گذشته";
                lblSevenDaysAgoTitle.Text = "عملکرد نسبت به 3 ماه گذشته";
                lblPerformanceTitle.Text = " نمودار پیشرفت یک ماهه تعمیرگاه";

                lblPanelStatus.Text = "آمار و ارقام عملکردی یک ماه گذشته";
                lblFinanceDailyIncomingTitle.Text = "درامد روزانه 30 روز گذشته";
            }
            else
            {
                lblHeaderTitle.Text = $"گزارش عملکرد 7 روزه {_ledger.Date.ToShamsiLong()}";

                lblOneDayAgoTitle.Text = "عملکرد نسبت به 1 روز گذشته";
                lblThreeDaysAgoTitle.Text = "عملکرد نسبت به 3 روز گذشته";
                lblSevenDaysAgoTitle.Text = "عملکرد نسبت به 7 روز گذشته";
                lblPerformanceTitle.Text = " نمودار پیشرفت یک هفته گذشته تعمیرگاه";
                lblPanelStatus.Text = "آمار و ارقام عملکردی یک هفته گذشته";
                lblFinanceDailyIncomingTitle.Text = "درامد روزانه 7 روز گذشته";
            }

            lblProfit.Text = $"{_ledger.Profit:N0} تومان";
            lblRevence.Text = $"{_ledger.TotalRevenue:N0} تومان";
            lblExpenses.Text = $"{_ledger.TotalExpenses:N0} تومان";
            lblShopExpenses.Text = $"{_ledger.ShopExpenses:N0} تومان";
            lblReceptionExpenses.Text = $"{_ledger.ReceptionExpenses:N0} تومان";

            lblProfitTitle.Text = _ledger.Profit >= 0 ? "مجموع سود خالص" : "مجموع زیان و ضرر";
            panelProfit.BackColor = _ledger.Profit >= 0 ? Color.Honeydew : Color.MistyRose;

            lblCarsTodayCount.Text = _ledger.ReceptionsOpened + " عدد";
            lblCarsNewCount.Text = _ledger.NewCarsRegistered + " عدد";
            lblCarsReleasedCount.Text = _ledger.ReceptionsReleased + " عدد";
            lblCarsRepairedCount.Text = _ledger.ReceptionsRepaired + " عدد";
            lblReceptionsCount.Text = _ledger.ReceptionsOpened + " عدد";

            SetupFinancialChart();
            SetupStatsChart();
            SetupPerformanceTrendChart();

            // Render the new chart
            SetupDailyIncomingChart();
        }

        private double CalculatePerformanceScore(DailyLedgerSummary dayLedger)
        {
            try
            {
                if (dayLedger == null) return 0;
                double financialScore = (double)(dayLedger.Profit / 1000000m) * 5;
                double operationalScore = (dayLedger.NewCarsRegistered * 1) + (dayLedger.ReceptionsOpened * 2);
                return financialScore + operationalScore;
            }
            catch { return 0; }
        }

        private void UpdateGrowthLabels()
        {
            var scores = _ledgers.OrderByDescending(x => x.Date)
                                 .Select(x => CalculatePerformanceScore(x))
                                 .ToList();

            if (scores.Count < 2) return;

            double targetScore = scores[0];

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

            if (_isMonthly)
            {
                SetGrowthLabel(lblOneDayAgo, targetScore, scores[1]);
                if (scores.Count > 2) SetGrowthLabel(lblThreeDaysAgo, targetScore, scores[2]);
                if (scores.Count > 3) SetGrowthLabel(lblSevenDaysAgo, targetScore, scores[3]);
            }
            else
            {
                SetGrowthLabel(lblOneDayAgo, targetScore, scores[1]);
                SetGrowthLabel(lblThreeDaysAgo, targetScore, scores[3]);
                SetGrowthLabel(lblSevenDaysAgo, targetScore, scores[6]);
            }
        }

        private void SetupPerformanceTrendChart()
        {
            chartPerformance.Series.Clear();
            chartPerformance.Titles.Clear();

            string chartTitle = _isMonthly ? "روند عملکرد ۴ ماه گذشته" : "عملکرد هفت روز گذشته";
            chartPerformance.Titles.Add(new ChartTitle { Text = chartTitle, Font = new Font("Vazirmatn", 12, FontStyle.Bold) });

            Series series = new Series("امتیاز", ViewType.Spline);
            series.ArgumentScaleType = ScaleType.Qualitative;
            _totalScore = 0;

            foreach (var summary in _ledgers)
            {
                double score = Math.Round(CalculatePerformanceScore(summary), 1);
                _totalScore += score;

                string xAxisLabel = "";
                if (_isMonthly)
                {
                    xAxisLabel = $"{GetShamsiMonthName(_pc.GetMonth(summary.Date))} {_pc.GetYear(summary.Date)}";
                }
                else
                {
                    int m = _pc.GetMonth(summary.Date);
                    int d = _pc.GetDayOfMonth(summary.Date);
                    xAxisLabel = $"{m:00}/{d:00}";
                }

                series.Points.Add(new SeriesPoint(xAxisLabel, score));
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

        // --- NEW METHOD FOR DAILY FINANCIAL CHART ---
        private void SetupDailyIncomingChart()
        {
            if (charFinanceDailyIncoming == null) return;

            charFinanceDailyIncoming.Series.Clear();
            charFinanceDailyIncoming.Titles.Clear();

            Series sRevenue = new Series("درآمد کل", ViewType.Line);
            Series sExpense = new Series("هزینه‌ها", ViewType.Line);
            Series sProfit = new Series("سود خالص", ViewType.Line);

            sRevenue.ArgumentScaleType = ScaleType.Qualitative;
            sExpense.ArgumentScaleType = ScaleType.Qualitative;
            sProfit.ArgumentScaleType = ScaleType.Qualitative;

            List<DailyLedgerSummary> plotData = new List<DailyLedgerSummary>();

            if (_isMonthly)
            {
                int year = _pc.GetYear(_currentViewDate);
                int month = _pc.GetMonth(_currentViewDate);
                int daysInMonth = _pc.GetDaysInMonth(year, month);
                DateTime monthStart = _pc.ToDateTime(year, month, 1, 0, 0, 0, 0);

                for (int i = 0; i < daysInMonth; i++)
                {
                    DateTime d = monthStart.AddDays(i);
                    var existing = _currentPeriodDailyData.FirstOrDefault(x => x.Date.Date == d.Date);
                    plotData.Add(existing ?? new DailyLedgerSummary { Date = d });
                }
            }
            else
            {
                plotData = _currentPeriodDailyData.OrderBy(x => x.Date).ToList();
            }

            foreach (var day in plotData)
            {
                // Full Persian Date formatting for the bottom labels
                string xAxisLabel = day.Date.ToShamsiLong();

                sRevenue.Points.Add(new SeriesPoint(xAxisLabel, day.TotalRevenue));
                sExpense.Points.Add(new SeriesPoint(xAxisLabel, day.TotalExpenses));
                sProfit.Points.Add(new SeriesPoint(xAxisLabel, day.Profit));
            }

            charFinanceDailyIncoming.Series.AddRange(new Series[] { sRevenue, sExpense, sProfit });

            // Format the hover tooltips (Crosshair) to display IR Toman
            sRevenue.CrosshairLabelPattern = "{S}: {V:N0} تومان";
            sExpense.CrosshairLabelPattern = "{S}: {V:N0} تومان";
            sProfit.CrosshairLabelPattern = "{S}: {V:N0} تومان";

            ((LineSeriesView)sRevenue.View).Color = Color.FromArgb(46, 204, 113);
            ((LineSeriesView)sExpense.View).Color = Color.FromArgb(231, 76, 60);
            ((LineSeriesView)sProfit.View).Color = Color.FromArgb(52, 152, 219);

            ((LineSeriesView)sRevenue.View).LineStyle.Thickness = 2;
            ((LineSeriesView)sExpense.View).LineStyle.Thickness = 2;
            ((LineSeriesView)sProfit.View).LineStyle.Thickness = 2;

            sRevenue.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            sExpense.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            sProfit.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;

            // Apply Diagram specific formatting (Y-Axis Toman text and X-Axis label angling)
            XYDiagram diagram = (XYDiagram)charFinanceDailyIncoming.Diagram;
            if (diagram != null)
            {
                // Format the vertical numbers
                diagram.AxisY.Label.TextPattern = "{V:N0} تومان";
                diagram.AxisY.Label.Font = new Font("Vazirmatn", 9);

                // Angle the dates slightly so they don't overlap when showing a full 30 days
                diagram.AxisX.Label.Angle = -45;
                diagram.AxisX.Label.Font = new Font("Vazirmatn", 9);
            }

            charFinanceDailyIncoming.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            charFinanceDailyIncoming.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Center;
            charFinanceDailyIncoming.Legend.AlignmentVertical = LegendAlignmentVertical.BottomOutside;
            charFinanceDailyIncoming.Legend.Direction = LegendDirection.LeftToRight;
            charFinanceDailyIncoming.Legend.Font = new Font("Vazirmatn", 9);
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

            chartFinance.CustomDrawSeriesPoint -= ChartFinance_CustomDrawSeriesPoint;
            chartFinance.CustomDrawSeriesPoint += ChartFinance_CustomDrawSeriesPoint;

            chartFinance.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
        }

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
            chartStats.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.RightOutside;
            chartStats.Legend.AlignmentVertical = LegendAlignmentVertical.Top;
            chartStats.Legend.Direction = LegendDirection.LeftToRight;
        }

        private string GetShamsiMonthName(int month)
        {
            string[] names = { "", "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند" };
            return (month >= 1 && month <= 12) ? names[month] : "";
        }
    }
}