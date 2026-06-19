using AutoLedger.App.Forms;
using AutoLedger.Data;
using AutoLedger.Domain;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoLedger.App.FormsView
{
    public partial class CarsManagerPage : UserControl
    {
        public CarsManagerPage()
        {
            InitializeComponent();
            RefreshCars();

            dgCars.SelectionChanged += DatagridCars_SelectionChanged;
            dgCarReceptions.CellDoubleClick += DgCarReceptions_CellDoubleClick;
            dgCarReceptions.CellFormatting += dgCarReceptions_CellFormatting;

        }

        private void DgCarReceptions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgCars.SelectedRows.Count < 1) return;
            var car = dgCars.SelectedRows[0].DataBoundItem as Car;
            if (car == null) return;

            var reception = dgCarReceptions.Rows[e.RowIndex].DataBoundItem as CarReception;
            if (reception == null) return;

            using (var form = new CarReceptionForm(car, reception).WithPlateId(car.PlateId))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    RefreshCarReceptions();
                }
            }
        }

        private void DatagridCars_SelectionChanged(object sender, EventArgs e)
        {
            RefreshCarInformation();
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
        void RefreshCars()
        {
            using (var db = new AutoLedgerContext())
            {
                dgCars.AutoGenerateColumns = false;
                dgCars.DataSource = db.Cars.ToList();
            }
        }

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



    }
}
