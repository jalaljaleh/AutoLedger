using AutoLedger.App.Forms;
using AutoLedger.App.FormsModal;
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

            // Debounce search timer
            _searchTimer = new Timer();
            _searchTimer.Interval = 2000;
            _searchTimer.Tick += SearchTimer_Tick;
            inputSearch.TextChanged += InputSearch_TextChanged;


            // Register UI events
            btnNewCar.Click += BtnNewCar_Click;
            btnEditCar.Click += BtnEditCar_Click;
            btnRefreshCars.Click += BtnRefreshCars_Click;
            btnCarsNextPage.Click += BtnCarsNextPage_Click;
            btnCarsBackPage.Click += BtnCarsBackPage_Click;


            dgCars.RowPostPaint += DgCars_RowPostPaint;
            dgCars.CellFormatting += dgCar_CellFormatting;

            RefreshCars();
        }

        private void BtnEditCar_Click(object sender, EventArgs e)
        {
            if (dgCars.SelectedRows.Count < 1)
            {
                MessageBox.Show("لطفا یک خودرو را انتخاب کنید.");
                return;
            }

            var car = dgCars.SelectedRows[0].DataBoundItem as Car;

            var carForm = new CarForm(car)
              .WithPlateId(car.PlateId);

            if (carForm.ShowDialog() != DialogResult.OK)
                return;
        
            RefreshCars();
        }

        private void BtnNewCar_Click(object sender, EventArgs e)
        {
            var carPlate = new CarPlateModalForm();
            if (carPlate.ShowDialog() != DialogResult.OK)
                return;

            using (var db = new AutoLedgerContext())
            {
                var car = db.Cars.FirstOrDefault(a => a.PlateId == carPlate.Plate);
                if (car is null)
                {
                    var carForm = new CarForm(null)
                      .WithPlateId(carPlate.Plate);

                    if (carForm.ShowDialog() != DialogResult.OK)
                        return;

                    car = carForm.GetCar();
                    RefreshCars();
                }
                else
                {
                    MessageBox.Show("این خودرو قبلا ثبت شده است.");
                }
            }
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

                IQueryable<Car> query = db.Cars;

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

                var list = query
                    .OrderByDescending(c => c.UpdatedAt)
                    .Skip(_carsPage * PageSize)
                    .Take(PageSize)
                    .AsNoTracking()
                    .ToList();

                btnCarsBackPage.Enabled = (_carsPage > 0);
                btnCarsNextPage.Enabled = (list.Count == PageSize);

                dgCars.DataSource = list;
            }
        }

        /// <summary>
        /// Refresh button: clears search + resets page.
        /// </summary>
        private void BtnRefreshCars_Click(object sender, EventArgs e)
        {
            _searchTimer.Stop();
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
            var row = dgCars.Rows[e.RowIndex];
            if (row.Cells.Count > 0) row.Cells[0].Value = (e.RowIndex + 1);
        }


        private void dgCar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.ColumnIndex >= dgCars.Columns.Count) return;
            string col = dgCars.Columns[e.ColumnIndex].Name;

            if (col == "CreatedAt" || col == "UpdatedAt")
            {
                if (DateTime.TryParse(e.Value?.ToString(), out DateTime dt))
                {
                    e.Value = dt.ToShamsi();
                    e.FormattingApplied = true;
                }
            }
        }

    }
}
