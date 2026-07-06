using AutoLedger.Data;
using AutoLedger.Domain;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace AutoLedger.App.FormsView
{
    public partial class CustomersInformationPage : UserControl
    {
        private readonly Timer _searchTimer;
        private int _carsPage = 0;
        private const int PageSize = 50;

        public CustomersInformationPage()
        {
            InitializeComponent();

            // Debounce timer for search input
            _searchTimer = new Timer
            {
                Interval = 2000 // 2 seconds delay after typing
            };
            _searchTimer.Tick += SearchTimer_Tick;

            // Register UI events
            btnRefreshCars.Click += BtnRefreshCars_Click;
            btnCarsNextPage.Click += BtnCarsNextPage_Click;
            btnCarsBackPage.Click += BtnCarsBackPage_Click;

            inputSearch.TextChanged += InputSearch_TextChanged;

            dgCars.RowPostPaint += DgCars_RowPostPaint;
            dgCars.CellFormatting += dgCar_CellFormatting;
        }


        // Triggered after user stops typing for 2 seconds
        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            _searchTimer.Stop();
            RefreshCars();
        }

        // Restart debounce timer on each keystroke
        private void InputSearch_TextChanged(object sender, EventArgs e)
        {
            _searchTimer.Stop();
            _searchTimer.Start();
        }

        /// <summary>
        /// Loads cars from database with search + paging.
        /// </summary>
        public void RefreshCars()
        {
            using (var db = new AutoLedgerContext())
            {
                dgCars.AutoGenerateColumns = false;

                string search = inputSearch.Text.Trim();

                // Base query
                IQueryable<Car> query = db.Cars;

                // Apply search filter
                if (!string.IsNullOrEmpty(search))
                {
                    query = query.Where(c =>
                        c.PlateId.Contains(search) ||
                        c.OwnerFullName.Contains(search) ||
                        c.OwnerPhoneNumber.Contains(search) ||
                        c.OwnerNationalId.Contains(search) ||
                        c.Brand.Contains(search) ||
                        c.Color.Contains(search)
                    );
                }

                // Apply paging
                var list = query
                    .OrderByDescending(c => c.UpdatedAt)
                    .Skip(_carsPage * PageSize)
                    .Take(PageSize)
                    .AsNoTracking()
                    .ToList();

                // Update paging buttons
                btnCarsBackPage.Enabled = (_carsPage > 0);
                btnCarsNextPage.Enabled = (list.Count == PageSize);

                // Bind to grid
                dgCars.DataSource = list;
            }
        }

        /// <summary>
        /// Refresh button: clears search + resets page.
        /// </summary>
        private void BtnRefreshCars_Click(object sender, EventArgs e)
        {
            _searchTimer.Stop();

            // Temporarily detach event to avoid triggering search
            inputSearch.TextChanged -= InputSearch_TextChanged;
            inputSearch.Text = string.Empty;
            inputSearch.TextChanged += InputSearch_TextChanged;

            _carsPage = 0;
            RefreshCars();
        }

        private void BtnCarsBackPage_Click(object sender, EventArgs e)
        {
            if (_carsPage <= 0)
                return;

            _carsPage--;
            RefreshCars();
        }

        private void BtnCarsNextPage_Click(object sender, EventArgs e)
        {
            _carsPage++;
            RefreshCars();
        }

        private void DgCars_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgCars.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
        private void dgCar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.ColumnIndex >= dgCars.Columns.Count) return;

            string cellName = dgCars.Columns[e.ColumnIndex].Name;
            if (e.Value != null && (cellName == "CreatedAt" || cellName == "UpdatedAt"))
            {
                DateTime dt;
                if (DateTime.TryParse(e.Value.ToString(), out dt))
                {
                    e.Value = dt.ToShamsi();
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
