using AutoLedger.App.FormsModal;
using AutoLedger.App.FormsView;
using AutoLedger.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AutoLedger.App.Forms
{
    public partial class DashboardForm : Form
    {
        private CarsManagerPage carsManagerPage;
        private CarsManagerPage carsManagerCurrentPage;

        public DashboardForm()
        {
            InitializeComponent();

            btnCarReception.Click += BtnNewCar_Click;
            btnCarsAll.Click += ViewButtons_Click;
        }

        private void ViewButtons_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn == null) return;

            switch (btn.Name)
            {
                case "btnCarsAll":
                    if (carsManagerPage == null)
                        carsManagerPage = new CarsManagerPage(false); // all cars
                    ShowControl(carsManagerPage);
                    break;
            }
        }

        private void ShowControl(UserControl control)
        {
            panelView.SuspendLayout();
            panelView.Controls.Clear();

            if (control != null)
            {
                panelView.Controls.Add(control);
                control.Dock = DockStyle.Fill;
            }

            panelView.ResumeLayout();
        }

        private void BtnNewCar_Click(object sender, EventArgs e)
        {
            var carPlate = new CarPlateModalForm();
            if (carPlate.ShowDialog() != DialogResult.OK)
                return;

            using (var db = new AutoLedgerContext())
            {
                var car = db.Cars.FirstOrDefault(a => a.PlateId == carPlate.Plate);

                var receptionForm = new CarReceptionForm(car, null)
                    .WithPlateId(carPlate.Plate);

                if (receptionForm.ShowDialog() == DialogResult.OK)
                {
                    // Refresh both pages if they exist
                    carsManagerPage?.RefreshCars();
                    carsManagerCurrentPage?.RefreshCars();
                }
            }
        }

        private void panelActions_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
