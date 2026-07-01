using AutoLedger.Data;
using AutoLedger.Domain;
using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using DevExpress.Charts.Native;

namespace AutoLedger.App.FormsView
{
    public partial class AccountingReportsPage : UserControl
    {
        private int _pageIndex = 0;
        private int _pageSize = 200;
        private int _daysAgo = -1;

        public AccountingReportsPage()
        {
            InitializeComponent();

            dgExpenses.AutoGenerateColumns = false;

            this.btnRefresh.Click += (s, e) => RefreshData(0);
            this.btnNextPage.Click += (s, e) => RefreshData(_pageIndex + 1);
            this.btnBackPage.Click += (s, e) => RefreshData(_pageIndex > 0 ? _pageIndex - 1 : 0);

            cbCount.SelectedIndexChanged += async (s, e) =>
            {
                if (int.TryParse(cbCount.Text, out int size))
                    _pageSize = size;

                RefreshData(0);
            };
            cbCount.Text = "200";

            RefreshData(0);
        }


        public void RefreshData(int pageIndex)
        {
            dgExpenses.DataSource = null;
            _pageIndex = pageIndex;

            int skip = _pageIndex * _pageSize;

            using (var db = new AutoLedgerContext())
            {
                var list = db.MonthlySummaries
                    .OrderByDescending(e => e.CreatedAt)
                        .Skip(skip)
                        .Take(_pageSize)
                    .AsNoTracking()
                    .ToList();

                PopulateChart(list);

                // 4. Update UI labels and controls
                btnBackPage.Enabled = (_pageIndex > 0);
                btnNextPage.Enabled = (list.Count == _pageSize);

                string filterLabel = _daysAgo > 0 ? $"{_daysAgo} روز اخیر" : "تمام زمان‌ها";
                labelDetails.Text = $"صفحه: {_pageIndex + 1} | تعداد: {list.Count} | فیلتر: {filterLabel}";


                dgExpenses.DataSource = list;
            }



        }

        private void PopulateChart(IList<MonthlySummary> list)
        {
        
            var fullList = BuildLast30Days(list);

            Series expensesSeries = chartDaily.Series[0];
            Series revenueSeries = chartDaily.Series[1];
            Series profitSeries = chartDaily.Series[2];

            expensesSeries.Points.Clear();
            revenueSeries.Points.Clear();
            profitSeries.Points.Clear();

            // format Y axis labels the same way
            var xy = (XYDiagram)chartDaily.Diagram;
            xy.AxisY.Label.TextPattern = "{V:n0} تومان";

            // optional: show months on X axis as Persian month names or short date
            xy.AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Day;
            xy.AxisX.Label.TextPattern = "{A:MM/dd}";


            expensesSeries.Label.TextPattern = "{V:n0} تومان";
            revenueSeries.Label.TextPattern = "{V:n0} تومان";
            profitSeries.Label.TextPattern = "{V:n0} تومان";

       
            foreach (var item in fullList)
            {
                DateTime arg = new DateTime(item.Year, item.Month, item.Day);

                double expenses = (double)item.Expenses;
                double revenue = (double)item.Revenue;
                double profit = (double)item.Profit;

                expensesSeries.Points.Add(new SeriesPoint(arg, expenses));
                revenueSeries.Points.Add(new SeriesPoint(arg, revenue));
                profitSeries.Points.Add(new SeriesPoint(arg, profit));
            }

            chartDaily.RefreshData();
        }

        private IList<MonthlySummary> BuildLast30Days(IList<MonthlySummary> list)
        {
            var result = new List<MonthlySummary>();

            DateTime today = DateTime.Today;

            for (int i = 0; i < 30; i++)
            {
                DateTime day = today.AddDays(-i);

                var existing = list.FirstOrDefault(x =>
                    x.Year == day.Year &&
                    x.Month == day.Month &&
                    x.Day == day.Day);

                if (existing != null)
                {
                    result.Add(existing);
                }
                else
                {
                    result.Add(new MonthlySummary
                    {
                        Year = day.Year,
                        Month = day.Month,
                        Day = day.Day,
                        Revenue = 0,
                        Expenses = 0
                    });
                }
            }


            return result.OrderBy(x => new DateTime(x.Year, x.Month, x.Day)).ToList();
        }


    }
}
