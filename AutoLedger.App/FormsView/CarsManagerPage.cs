using AutoLedger.App.Forms;
using AutoLedger.Data;
using AutoLedger.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoLedger.App.FormsView
{
    public partial class CarsManagerPage : UserControl
    {
        private System.Windows.Forms.Timer _searchTimer;


        private int _receptionsPage = 0;
        private int _receptionsPageSize = 50;

        private int _carsPage = 0;
        private int _carsPageSize = 50;
        public void CheckCurrentCars(bool @checked) => cbCurrentCars.Checked = @checked;

        public CarsManagerPage(bool currentCarsOnly = false)
        {
            InitializeComponent();
            cbCurrentCars.Checked = currentCarsOnly;

            _searchTimer = new Timer();
            _searchTimer.Interval = 2000;
            _searchTimer.Tick += SearchTimer_Tick;

            inputSearch.TextChanged += InputSearch_TextChanged;

            this.dgCars.SelectionChanged += DatagridCars_SelectionChanged;
            this.dgCarReceptions.CellDoubleClick += DgCarReceptions_CellDoubleClick;
            this.dgCarReceptions.CellFormatting += dgCarReceptions_CellFormatting;
            this.dgCarReceptions.RowPostPaint += DgCarReceptions_RowPostPaint;
            this.dgCarReceptions.DataBindingComplete += dgCarReceptions_DataBindingComplete;

            this.btnReceptionDelete.Click += BtnReceptionDelete_Click;
            this.btnReceptionEdit.Click += BtnReceptionEdit_Click;
            this.btnReceptionNew.Click += BtnNewReception_Click;
            this.btnCarExpenses.Click += BtnCarExpenses_Click;


            this.btnRefreshCarReceptions.Click += BtnRefreshCarReceptions_Click;
            this.btnRefreshCars.Click += BtnRefreshCars_Click;

            this.btnCarsNextPage.Click += BtnCarsNextPage_Click;
            this.btnCarsBackPage.Click += BtnCarsBackPage_Click;

            this.btnBackPageCarReceptions.Click += BtnBackPageCarReceptions_Click;
            this.btnNextPageReceptions.Click += BtnNextPageReceptions_Click;

            this.cbReceptinoCount.SelectedItem = 50;
            this.cbReceptinoCount.SelectedIndexChanged += CbReceptinoCount_SelectedIndexChanged;

            this.cbCurrentCars.CheckedChanged += CbCurrentCars_CheckedChanged;

            RefreshCars();

        }

        private void CbCurrentCars_CheckedChanged(object sender, EventArgs e)
        {
            RefreshCars();
        }

        private void InputSearch_TextChanged(object sender, EventArgs e)
        {
            _searchTimer.Stop();
            _searchTimer.Start();
        }

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            _searchTimer.Stop();
            RefreshCars();
        }

        private void CbReceptinoCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbReceptinoCount.SelectedItem == null) return;

            if (cbReceptinoCount.SelectedItem is int i)
                _receptionsPageSize = i;
            else
            {
                if (int.TryParse(cbReceptinoCount.SelectedItem.ToString(), out int parsed))
                    _receptionsPageSize = parsed;
            }
            _receptionsPage = 0;
            RefreshCarReceptions();
        }

        private void BtnNextPageReceptions_Click(object sender, EventArgs e)
        {
            _receptionsPage++;
            RefreshCarReceptions();
        }

        private void BtnBackPageCarReceptions_Click(object sender, EventArgs e)
        {
            if (_receptionsPage <= 0) return;

            _receptionsPage--;
            RefreshCarReceptions();
        }

        private void BtnCarsBackPage_Click(object sender, EventArgs e)
        {
            if (_carsPage <= 0) return;

            _carsPage--;
            RefreshCars();
            RefreshCarInformation();
        }

        private void BtnCarsNextPage_Click(object sender, EventArgs e)
        {
            _carsPage++;
            RefreshCars();
            RefreshCarInformation();
        }

        private void BtnRefreshCars_Click(object sender, EventArgs e)
        {
            _searchTimer.Stop();
            inputSearch.TextChanged -= InputSearch_TextChanged;
            inputSearch.Text = string.Empty;
            inputSearch.TextChanged += InputSearch_TextChanged;
            _carsPage = 0;
            RefreshCars();
            RefreshCarInformation();

        }

        private void BtnRefreshCarReceptions_Click(object sender, EventArgs e)
        {
            _receptionsPage = 0;
            RefreshCarReceptions();
        }

        void RefreshCarReceptions()
        {
            dgCarReceptions.AutoGenerateColumns = false;

            if (dgCars.SelectedRows.Count < 1)
            {
                dgCarReceptions.DataSource = null;
                return;
            }

            using (AutoLedgerContext db = new AutoLedgerContext())
            {
                var car = dgCars.SelectedRows[0].DataBoundItem as Car;

                var receptions = db.CarReceptions
                    .Where(a => a.CarId == car.Id)
                    .OrderBy(a => a.Id) // FIX
                    .Skip(_receptionsPage * _receptionsPageSize)
                    .Take(_receptionsPageSize)
                    .AsNoTracking()
                    .ToList();

                // pages
                btnBackPageCarReceptions.Enabled = (_receptionsPage > 0);
                btnNextPageReceptions.Enabled = receptions.Count >= _receptionsPageSize;

                dgCarReceptions.DataSource = receptions;

                labelReceptionsDetails.Text = $"تعداد رکوردها: {receptions.Count} | \t";
                labelReceptionsDetails.Text += $"صفحه {_receptionsPage + 1} | تعداد در صفحه: {_receptionsPageSize}";
            }
        }


        void RefreshCarInformation()
        {
            dataGridSelectedCar.AutoGenerateColumns = false;
            if (dgCars.SelectedRows.Count < 1)
            {
                dataGridSelectedCar.DataSource = null;
                return;
            }
            dataGridSelectedCar.DataSource = new List<Car>() { dgCars.SelectedRows[0].DataBoundItem as Car };
        }

        public void RefreshCars()
        {
            using (var db = new AutoLedgerContext())
            {
                dgCars.AutoGenerateColumns = false;

                string search = inputSearch.Text.Trim();

                IQueryable<Car> query;

                if (cbCurrentCars.Checked)
                {
                    query = db.CarReceptions
                        .Where(a => !a.IsReleased || !a.IsExpensesProvided)
                        .Select(a => a.Car)
                        .Distinct()
                        .AsNoTracking();
                }
                else
                {
                    query = db.Cars;
                }

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
                    .Skip(_carsPage * _carsPageSize)
                    .Take(_carsPageSize)
                    .AsNoTracking()
                    .ToList();

                // pages
                btnCarsBackPage.Enabled = (_carsPage > 0);
                btnCarsNextPage.Enabled = list.Count >= _carsPageSize;

                dgCars.DataSource = list;
            }
        }


        private void BtnCarExpenses_Click(object sender, EventArgs e)
        {
            var (car, reception) = GetSelectedCarAndReception();
            if (car == null)
            {
                MessageBox.Show("ابتدا یک خودرو انتخاب کنید.");
                return;
            }
            if (reception == null)
            {
                MessageBox.Show("ابتدا یک پذیرش انتخاب کنید.");
                return;
            }
            try
            {
                using (var form = new CarReceptionExpenseForm(reception))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        RefreshCarReceptions();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در باز کردن فرم پذیرش: " + ex.Message);
            }
        }


        // Selection changed handler (wired in ctor)
        private void DatagridCars_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                RefreshCarInformation();
                RefreshCarReceptions();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در تغییر انتخاب خودرو: " + ex.Message);
            }
        }

        private void BtnReceptionEdit_Click(object sender, EventArgs e)
        {
            var (car, reception) = GetSelectedCarAndReception();
            if (car == null)
            {
                MessageBox.Show("ابتدا یک خودرو انتخاب کنید.");
                return;
            }
            if (reception == null)
            {
                MessageBox.Show("ابتدا یک پذیرش انتخاب کنید.");
                return;
            }

            OpenReceptionEditor(car, reception);
        }

        private void BtnReceptionDelete_Click(object sender, EventArgs e)
        {
            var (car, reception) = GetSelectedCarAndReception();
            if (car == null)
            {
                MessageBox.Show("ابتدا یک خودرو انتخاب کنید.");
                return;
            }
            if (reception == null)
            {
                MessageBox.Show("ابتدا یک پذیرش انتخاب کنید.");
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
            if (dgCars.SelectedRows.Count < 1)
            {
                MessageBox.Show("ابتدا یک خودرو انتخاب کنید.");
                return;
            }

            var car = dgCars.SelectedRows[0].DataBoundItem as Car;
            if (car == null)
            {
                MessageBox.Show("خودروی انتخاب شده نامعتبر است.");
                return;
            }

            OpenReceptionEditor(car, null);
        }

        private (Car car, CarReception reception) GetSelectedCarAndReception(int rowIndex = -1)
        {
            if (dgCars.SelectedRows.Count < 1) return (null, null);

            var car = dgCars.SelectedRows[0].DataBoundItem as Car;
            if (car == null) return (null, null);

            CarReception reception = null;
            if (rowIndex >= 0 && rowIndex < dgCarReceptions.Rows.Count)
            {
                reception = dgCarReceptions.Rows[rowIndex].DataBoundItem as CarReception;
            }
            else if (dgCarReceptions.SelectedRows.Count > 0)
            {
                reception = dgCarReceptions.SelectedRows[0].DataBoundItem as CarReception;
            }

            return (car, reception);
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
                using (var form = new CarReceptionForm(car, reception))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        RefreshCarReceptions();
                        // Optionally refresh cars list if reception changes affect car display
                        RefreshCars();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در باز کردن فرم پذیرش: " + ex.Message);
            }
        }







        private void DgCarReceptions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var (car, reception) = GetSelectedCarAndReception(e.RowIndex);
            OpenReceptionEditor(car, reception);
        }
        private void ApplyRowColor(DataGridViewRow row)
        {
            object valReleased = row.Cells["IsReleased"].Value;
            object valRepaired = row.Cells["IsRepaired"].Value;

            bool released = valReleased != null && valReleased != DBNull.Value && Convert.ToBoolean(valReleased);
            bool repaired = valRepaired != null && valRepaired != DBNull.Value && Convert.ToBoolean(valRepaired);

            Color back = System.Drawing.Color.White;
            Color fore = System.Drawing.Color.Black;

            if (!released)
            {
                back = System.Drawing.Color.DarkSeaGreen;
                fore = System.Drawing.Color.Black;
            }

            if (!repaired)
            {
                back = System.Drawing.Color.Pink;
                fore = System.Drawing.Color.Black;
            }

            row.DefaultCellStyle.BackColor = back;
            row.DefaultCellStyle.ForeColor = fore;
        }

        private void dgCarReceptions_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.ColumnIndex >= dgCarReceptions.Columns.Count) return;

            string cellName = dgCarReceptions.Columns[e.ColumnIndex].Name;

            if (cellName == "IsReleased" || cellName == "IsRepaired")
            {
                if (e.Value == null)
                {
                    e.Value = "خیر";
                    e.CellStyle.ForeColor = System.Drawing.Color.Red;
                    e.FormattingApplied = true;
                    return;
                }

                bool isTrue;
                if (bool.TryParse(e.Value.ToString(), out isTrue))
                {
                    e.Value = isTrue ? "بله" : "خیر";
                    e.CellStyle.ForeColor = isTrue ? System.Drawing.Color.Green : System.Drawing.Color.Red;
                    e.FormattingApplied = true;
                }
            }
            else if (cellName == "IsExpensesProvided")
            {
                if (e.Value == null)
                {
                    e.Value = "اعمال نشده";
                    e.CellStyle.ForeColor = System.Drawing.Color.Red;
                    e.FormattingApplied = true;
                    return;
                }

                bool isTrue;
                if (bool.TryParse(e.Value.ToString(), out isTrue))
                {
                    e.Value = isTrue ? "اعمال شده" : "اعمال نشده";
                    e.CellStyle.BackColor = isTrue ? e.CellStyle.BackColor : System.Drawing.Color.Pink;
                    e.FormattingApplied = true;
                }
            }
        }

        private void dgCarReceptions_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgCarReceptions.Rows)
            {
                ApplyRowColor(row);
            }
        }
        private void DgCarReceptions_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgCarReceptions.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

    }
}
