using AutoLedger.Data;
using AutoLedger.Domain;
using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace AutoLedger.App.FormsView
{
    public partial class AccountingReportsPage : UserControl
    {
        private int _pageIndex = 0;
        private int _pageSize = 30;
        private int _daysAgo = -1;

        public AccountingReportsPage()
        {
            InitializeComponent();

            dgExpenses.AutoGenerateColumns = false;

            this.btnRefresh.Click += (s, e) => RefreshData(0);
            this.btnNextPage.Click += (s, e) => RefreshData(_pageIndex + 1);
            this.btnBackPage.Click += (s, e) => RefreshData(_pageIndex > 0 ? _pageIndex - 1 : 0);

            cbCount.SelectedIndexChanged += (s, e) =>
            {
                if (int.TryParse(cbCount.Text, out int size))
                    _pageSize = size;

                RefreshData(0);
            };
            cbCount.Text = "30";

            RefreshData(0);
        }

        public void RefreshData(int pageIndex)
        {
            dgExpenses.DataSource = null;
            _pageIndex = pageIndex;

            int skip = _pageIndex * _pageSize;

            using (var db = new AutoLedgerContext())
            {
                // UPGRADE: We now order by the actual 'Date' property, not 'CreatedAt'
                var list = db.DailySummaries
                    .OrderByDescending(e => e.Date)
                    .Skip(skip)
                    .Take(_pageSize)
                    .AsNoTracking()
                    .ToList();

                PopulateDailyChart(list);

                // UPGRADE: Match exactly on today's Date
                PopulateTodayChart(list.FirstOrDefault(a => a.Date == DateTime.Today));

                btnBackPage.Enabled = (_pageIndex > 0);
                btnNextPage.Enabled = (list.Count == _pageSize);

                string filterLabel = _daysAgo > 0 ? $"{_daysAgo} روز اخیر" : "تمام زمان‌ها";
                labelDetails.Text = $"صفحه: {_pageIndex + 1} | تعداد: {list.Count} | فیلتر: {filterLabel}";

                dgExpenses.DataSource = list;
            }
        }

        private void PopulateTodayChart(DailyLedgerSummary today)
        {
            Series serie = chartToday.Series[0];
            serie.Points.Clear();
            serie.Label.TextPattern = "{V:n0} تومان";

            if (today == null) return;

            // UPGRADE: Using the new Computed Properties and adding Persian string labels
            serie.Points.Add(new SeriesPoint("درآمد کل", (double)today.TotalRevenue));
            serie.Points.Add(new SeriesPoint("هزینه‌ها", (double)today.TotalExpenses));
            serie.Points.Add(new SeriesPoint("سود خالص", (double)today.Profit));

            chartToday.RefreshData();
        }

        private void PopulateDailyChart(IList<DailyLedgerSummary> list)
        {
            var fullList = BuildLast30Days(list);

            Series expensesSeries = Set(chartDaily.Series[0]);
            Series revenueSeries = Set(chartDaily.Series[1]);
            Series profitSeries = Set(chartDaily.Series[2]);

            Series Set(Series serie)
            {
                serie.Points.Clear();
                serie.Label.TextPattern = "{V:n0} تومان";
                return serie;
            }

            var xy = (XYDiagram)chartDaily.Diagram;
            xy.AxisY.Label.TextPattern = "{V:n0} تومان";

            // X-Axis settings for qualitative string dates (since we pass Persian strings now)
            xy.AxisX.Label.TextPattern = "{A}";

            foreach (var item in fullList)
            {
                // Convert to beautiful Persian date string: e.g., "1402/05/12"
                string shamsiDate = ToShamsiDateString(item.Date);

                // UPGRADE: Map to the new Total properties
                expensesSeries.Points.Add(new SeriesPoint(shamsiDate, (double)item.TotalExpenses));
                revenueSeries.Points.Add(new SeriesPoint(shamsiDate, (double)item.TotalRevenue));
                profitSeries.Points.Add(new SeriesPoint(shamsiDate, (double)item.Profit));
            }

            chartDaily.RefreshData();
        }

        private IList<DailyLedgerSummary> BuildLast30Days(IList<DailyLedgerSummary> list)
        {
            var result = new List<DailyLedgerSummary>();
            DateTime today = DateTime.Today;

            for (int i = 0; i < 30; i++)
            {
                DateTime day = today.AddDays(-i);

                var existing = list.FirstOrDefault(x => x.Date == day);

                if (existing != null)
                {
                    result.Add(existing);
                }
                else
                {
                    // UPGRADE: Properly initialize an empty day with our new BI properties
                    result.Add(new DailyLedgerSummary
                    {
                        Date = day,
                        Year = day.Year,
                        Month = day.Month,
                        Day = day.Day,
                        ReceptionRevenue = 0,
                        ShopExpenses = 0,
                        ReceptionExpenses = 0,
                        NewCarsRegistered = 0,
                        ReceptionsOpened = 0
                    });
                }
            }

            return result.OrderBy(x => x.Date).ToList();
        }

        // --- HELPER: Fast Persian Date Converter ---
        private string ToShamsiDateString(DateTime date)
        {
            PersianCalendar pc = new PersianCalendar();
            return $"{pc.GetYear(date):0000}/{pc.GetMonth(date):00}/{pc.GetDayOfMonth(date):00}";
        }
    }
}