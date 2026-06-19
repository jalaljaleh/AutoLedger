using AutoLedger.App.Forms;
using AutoLedger.Data;
using AutoLedger.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoLedger.App.FormsView
{
    public partial class CarsManagerPage : UserControl
    {
        // Virtualization fields
        private const int PageSize = 200; // tune this value
        private const int MaxCachedPages = 8;
        private readonly Dictionary<int, List<Car>> _pages = new Dictionary<int, List<Car>>();
        private readonly LinkedList<int> _lru = new LinkedList<int>();
        private readonly object _cacheLock = new object();
        private int _totalCars = 0;
        private bool _isLoadingPage = false;

        public CarsManagerPage()
        {
            InitializeComponent();

            // Replace full-load with virtualized grid
            InitializeVirtualCarsGrid();
            Task.Run(() => InitializeCarsVirtualAsync()); // fire-and-forget

            // Wire other events
            dgCars.SelectionChanged += DatagridCars_SelectionChanged;
            dgCarReceptions.CellDoubleClick += DgCarReceptions_CellDoubleClick;
            dgCarReceptions.CellFormatting += dgCarReceptions_CellFormatting;

            this.btnReceptionDelete.Click += BtnReceptionDelete_Click;
            this.btnReceptionEdit.Click += BtnReceptionEdit_Click;
            this.btnReceptionNew.Click += BtnNewReception_Click;
        }

        #region Virtual grid initialization and paging (compact, robust)
        // Add this method inside your CarsManagerPage class
        private void DatagridCars_SelectionChanged(object sender, EventArgs e)
        {
            // If using virtual mode, SelectedRows may be empty until a row is actually selected.
            // We simply refresh the right-hand panels when selection changes.
            try
            {
                RefreshCarInformation();
                RefreshCarReceptions();
            }
            catch (Exception ex)
            {
                // avoid crashing the UI on unexpected errors
                MessageBox.Show("خطا در تغییر انتخاب خودرو: " + ex.Message);
            }
        }

        private void InitializeVirtualCarsGrid()
        {
            dgCars.VirtualMode = true;
            dgCars.AutoGenerateColumns = false;
            dgCars.AllowUserToAddRows = false;

            // If designer already created columns, ensure names match. Otherwise define minimal columns:
            if (dgCars.Columns.Count == 0)
            {
                dgCars.Columns.Add(new DataGridViewTextBoxColumn { Name = "Id", HeaderText = "Id", Visible = false });
                dgCars.Columns.Add(new DataGridViewTextBoxColumn { Name = "PlateId", HeaderText = "پلاک", Width = 120 });
                dgCars.Columns.Add(new DataGridViewTextBoxColumn { Name = "Brand", HeaderText = "برند", Width = 120 });
                dgCars.Columns.Add(new DataGridViewTextBoxColumn { Name = "Model", HeaderText = "مدل", Width = 80 });
                dgCars.Columns.Add(new DataGridViewTextBoxColumn { Name = "OwnerFullName", HeaderText = "مالک", Width = 160 });
                dgCars.Columns.Add(new DataGridViewTextBoxColumn { Name = "OwnerPhoneNumber", HeaderText = "تلفن", Width = 120 });
            }

            dgCars.CellValueNeeded += DgCars_CellValueNeeded;
            dgCars.Scroll += DgCars_Scroll;
            dgCars.RowCount = 0;
        }

        private async Task InitializeCarsVirtualAsync()
        {
            try
            {
                using (var db = new AutoLedgerContext())
                {
                    _totalCars = await db.Cars.CountAsync();
                }

                if (InvokeRequired) Invoke(new Action(() => dgCars.RowCount = _totalCars));
                else dgCars.RowCount = _totalCars;

                // Load first pages for smooth UX
                await LoadPageAsync(0);
                await LoadPageAsync(1);
            }
            catch (Exception ex)
            {
                // If initialization fails, show a simple fallback: clear grid and log
                if (InvokeRequired) Invoke(new Action(() => dgCars.RowCount = 0));
                else dgCars.RowCount = 0;
                MessageBox.Show("خطا در بارگذاری خودروها: " + ex.Message);
            }
        }

        private async Task LoadPageAsync(int pageIndex)
        {
            if (pageIndex < 0) return;

            lock (_cacheLock)
            {
                if (_pages.ContainsKey(pageIndex))
                {
                    MovePageToFront(pageIndex);
                    return;
                }
                if (_isLoadingPage)
                {
                    // allow other loads; avoid duplicate work by checking cache again after load
                }
                _isLoadingPage = true;
            }

            try
            {
                List<Car> page;
                using (var db = new AutoLedgerContext())
                {
                    page = await db.Cars
                        .OrderBy(c => c.Id)
                        .Skip(pageIndex * PageSize)
                        .Take(PageSize)
                        .AsNoTracking()
                        .ToListAsync();
                }

                lock (_cacheLock)
                {
                    _pages[pageIndex] = page;
                    MovePageToFront(pageIndex);

                    while (_lru.Count > MaxCachedPages)
                    {
                        var oldest = _lru.Last.Value;
                        _lru.RemoveLast();
                        _pages.Remove(oldest);
                    }
                }

                if (InvokeRequired) Invoke(new Action(() => RefreshRowsForPage(pageIndex)));
                else RefreshRowsForPage(pageIndex);
            }
            finally
            {
                lock (_cacheLock) { _isLoadingPage = false; }
            }
        }

        private void MovePageToFront(int pageIndex)
        {
            var node = _lru.Find(pageIndex);
            if (node != null) _lru.Remove(node);
            _lru.AddFirst(pageIndex);
        }

        private void RefreshRowsForPage(int pageIndex)
        {
            int start = pageIndex * PageSize;
            int end = Math.Min(start + PageSize, dgCars.RowCount);
            for (int r = start; r < end; r++)
                dgCars.InvalidateRow(r);
        }

        private void DgCars_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation != ScrollOrientation.VerticalScroll) return;
            int first = dgCars.FirstDisplayedScrollingRowIndex;
            if (first < 0) return;
            int page = first / PageSize;
            _ = LoadPageAsync(page);
            _ = LoadPageAsync(page + 1);
            _ = LoadPageAsync(page - 1);
        }

        private void DgCars_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (_totalCars == 0) { e.Value = ""; return; }
            if (e.RowIndex >= _totalCars) { e.Value = ""; return; }

            int pageIndex = e.RowIndex / PageSize;
            int indexInPage = e.RowIndex % PageSize;

            List<Car> page = null;
            lock (_cacheLock) _pages.TryGetValue(pageIndex, out page);

            if (page == null)
            {
                _ = LoadPageAsync(pageIndex);
                e.Value = GetPlaceholderForColumn(dgCars.Columns[e.ColumnIndex].Name);
                return;
            }

            if (indexInPage >= page.Count)
            {
                e.Value = "";
                return;
            }

            var car = page[indexInPage];
            switch (dgCars.Columns[e.ColumnIndex].Name)
            {
                case "Id": e.Value = car.Id; break;
                case "PlateId": e.Value = car.PlateId; break;
                case "Brand": e.Value = car.Brand; break;
                case "Model": e.Value = car.Model; break;
                case "OwnerFullName": e.Value = car.OwnerFullName; break;
                case "OwnerPhoneNumber": e.Value = car.OwnerPhoneNumber; break;
                default: e.Value = ""; break;
            }
        }

        private object GetPlaceholderForColumn(string columnName)
        {
            if (columnName == "Model") return 0;
            return "...";
        }

        #endregion

        #region Helpers to load selected Car entity (used by reception flows)

        // Try to get Car Id from cache; if not cached return null
        private int? GetCarIdAtRow(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= _totalCars) return null;
            int pageIndex = rowIndex / PageSize;
            int indexInPage = rowIndex % PageSize;
            lock (_cacheLock)
            {
                if (_pages.TryGetValue(pageIndex, out var page) && indexInPage < page.Count)
                    return page[indexInPage].Id;
            }
            return null;
        }

        // Load Car entity by row index (fresh tracked entity with Receptions included)
        private Car LoadCarEntityByRowIndex(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= _totalCars) return null;

            var id = GetCarIdAtRow(rowIndex);
            if (id.HasValue)
            {
                using (var db = new AutoLedgerContext())
                {
                    return db.Cars.Include(c => c.Receptions).FirstOrDefault(c => c.Id == id.Value);
                }
            }

            // fallback: query by ordering + skip
            using (var db = new AutoLedgerContext())
            {
                return db.Cars
                         .OrderBy(c => c.Id)
                         .Skip(rowIndex)
                         .Take(1)
                         .Include(c => c.Receptions)
                         .FirstOrDefault();
            }
        }

        private Car GetSelectedCarEntity()
        {
            if (dgCars.SelectedRows.Count < 1) return null;
            int rowIndex = dgCars.SelectedRows[0].Index;
            return LoadCarEntityByRowIndex(rowIndex);
        }

        #endregion

        #region Reception operations (edit / delete / new)

        private void BtnReceptionEdit_Click(object sender, EventArgs e)
        {
            var car = GetSelectedCarEntity();
            if (car == null)
            {
                MessageBox.Show("ابتدا یک خودرو انتخاب کنید.");
                return;
            }

            if (dgCarReceptions.SelectedRows.Count < 1)
            {
                MessageBox.Show("ابتدا یک پذیرش انتخاب کنید.");
                return;
            }

            var reception = dgCarReceptions.SelectedRows[0].DataBoundItem as CarReception;
            if (reception == null)
            {
                MessageBox.Show("پذیرش انتخاب شده نامعتبر است.");
                return;
            }

            OpenReceptionEditor(car, reception);
        }

        private void BtnReceptionDelete_Click(object sender, EventArgs e)
        {
            var car = GetSelectedCarEntity();
            if (car == null)
            {
                MessageBox.Show("ابتدا یک خودرو انتخاب کنید.");
                return;
            }

            if (dgCarReceptions.SelectedRows.Count < 1)
            {
                MessageBox.Show("ابتدا یک پذیرش انتخاب کنید.");
                return;
            }

            var reception = dgCarReceptions.SelectedRows[0].DataBoundItem as CarReception;
            if (reception == null)
            {
                MessageBox.Show("پذیرش انتخاب شده نامعتبر است.");
                return;
            }

            var confirm = MessageBox.Show(
                "آیا از حذف این پذیرش مطمئن هستید؟ این عمل قابل بازگشت نیست.",
                "تأیید حذف",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                using (var db = new AutoLedgerContext())
                {
                    using (var tx = db.Database.BeginTransaction())
                    {
                        var target = db.CarReceptions.FirstOrDefault(r => r.Id == reception.Id);
                        if (target == null)
                        {
                            MessageBox.Show("پذیرش برای حذف یافت نشد.");
                            return;
                        }

                        db.CarReceptions.Remove(target);
                        db.SaveChanges();
                        tx.Commit();
                    }
                }

                RefreshCarReceptions();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در حذف پذیرش: " + ex.Message);
            }
        }

        private void BtnNewReception_Click(object sender, EventArgs e)
        {
            var car = GetSelectedCarEntity();
            if (car == null)
            {
                MessageBox.Show("ابتدا یک خودرو انتخاب کنید.");
                return;
            }

            OpenReceptionEditor(car, null);
        }

        private void OpenReceptionEditor(Car car, CarReception reception)
        {
            if (car == null)
            {
                MessageBox.Show("هیچ خودرویی انتخاب نشده است.");
                return;
            }

            try
            {
                using (var form = new CarReceptionForm(car, reception).WithPlateId(car.PlateId))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        RefreshCarReceptions();
                        // Optionally refresh the cached page containing this car so UI shows updated values
                        RefreshCacheForCarId(car.Id);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در باز کردن فرم پذیرش: " + ex.Message);
            }
        }

        private void RefreshCacheForCarId(int carId)
        {
            // Find page that contains this car id and reload it
            lock (_cacheLock)
            {
                foreach (var kv in _pages.ToList())
                {
                    if (kv.Value.Any(c => c.Id == carId))
                    {
                        // reload that page asynchronously
                        _ = LoadPageAsync(kv.Key);
                        break;
                    }
                }
            }
        }

        private void DgCarReceptions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var car = GetSelectedCarEntity();
            if (car == null)
            {
                MessageBox.Show("ابتدا یک خودرو انتخاب کنید.");
                return;
            }

            var reception = dgCarReceptions.Rows[e.RowIndex].DataBoundItem as CarReception;
            if (reception == null)
            {
                MessageBox.Show("پذیرش انتخاب شده نامعتبر است.");
                return;
            }

            OpenReceptionEditor(car, reception);
        }

        #endregion

        #region Receptions grid and formatting (unchanged)

        private void dgCarReceptions_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.ColumnIndex >= dgCarReceptions.Columns.Count) return;
            if (dgCarReceptions.Columns[e.ColumnIndex].Name != "IsReleased") return;
            if (e.Value == null)
            {
                e.Value = "در حال تعمیر";
                e.FormattingApplied = true;
                e.CellStyle.ForeColor = System.Drawing.Color.DarkOrange;
                return;
            }

            bool released;
            if (bool.TryParse(e.Value.ToString(), out released))
            {
                e.Value = released ? "ترخیص شده" : "در حال تعمیر";
                e.CellStyle.ForeColor = released ? System.Drawing.Color.Green : System.Drawing.Color.DarkOrange;
                e.FormattingApplied = true;
            }
            else
            {
                e.Value = e.Value.ToString();
                e.CellStyle.ForeColor = System.Drawing.Color.Black;
                e.FormattingApplied = true;
            }
        }

        void RefreshCarReceptions()
        {
            dgCarReceptions.AutoGenerateColumns = false;
            var car = GetSelectedCarEntity();
            if (car == null)
            {
                dgCarReceptions.DataSource = null;
                return;
            }

            using (AutoLedgerContext db = new AutoLedgerContext())
            {
                dgCarReceptions.DataSource = db.CarReceptions.Where(a => a.CarId == car.Id).ToList();
            }
        }

        void RefreshCarInformation()
        {
            dataGridSelectedCar.AutoGenerateColumns = false;
            var car = GetSelectedCarEntity();
            if (car == null)
            {
                dataGridSelectedCar.DataSource = null;
                return;
            }

            using (var db = new AutoLedgerContext())
            {
                var fresh = db.Cars.FirstOrDefault(c => c.Id == car.Id);
                dataGridSelectedCar.DataSource = fresh == null ? null : new List<Car> { fresh };
            }
        }

        #endregion

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
