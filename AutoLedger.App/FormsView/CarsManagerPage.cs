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
        public CarsManagerPage()
        {
            InitializeComponent();

            // Load all cars (no virtualization)
            RefreshCars();

            // Wire events
            dgCars.SelectionChanged += DatagridCars_SelectionChanged;
            dgCarReceptions.CellDoubleClick += DgCarReceptions_CellDoubleClick;
            dgCarReceptions.CellFormatting += dgCarReceptions_CellFormatting;
            dgCarReceptions.DataBindingComplete += dgCarReceptions_DataBindingComplete;

            this.btnReceptionDelete.Click += BtnReceptionDelete_Click;
            this.btnReceptionEdit.Click += BtnReceptionEdit_Click;
            this.btnReceptionNew.Click += BtnNewReception_Click;
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
                using (var form = new CarReceptionForm(car, reception).WithPlateId(car.PlateId))
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
        }

        private void dgCarReceptions_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgCarReceptions.Rows)
            {
                ApplyRowColor(row);
            }
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
                var car = (dgCars.SelectedRows[0].DataBoundItem as Car);
                dgCarReceptions.DataSource = db.CarReceptions.Where(a => a.CarId == car.Id).ToList();
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
                dgCars.DataSource = db.Cars.OrderByDescending(c => c.UpdatedAt).ToList();
            }
        }
    }
}
