using AutoLedger.App.FormsModal;
using AutoLedger.App.FormsView;
using AutoLedger.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoLedger.App.Forms
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();

            this.btnCarReception.Click += BtnNewCar_Click;
            this.btnCurrentCars.Click += ViewButtons_Click;
        }
        CarsManagerPage carsManagerPage;
        private void ViewButtons_Click(object sender, EventArgs e)
        {
            switch ((sender as Button).Name)
            {
                case "btnCurrentCars":
                    if (carsManagerPage is null)
                        carsManagerPage = new CarsManagerPage();

                    ShowControl(carsManagerPage);
                    break;

                default:
                    ShowControl(null);
                    break;
            }
        }

        private void ShowControl(UserControl control)
        {
            panelView.Controls.Clear();

            if (control != null)
            {
                panelView.Controls.Add(control);
                control.Dock = DockStyle.Fill;
            }

        }
        private void BtnNewCar_Click(object sender, EventArgs e)
        {
            var carPlate = new CarPlateModalForm();
            var plateResult = carPlate.ShowDialog();

            if (plateResult == DialogResult.OK)
            {
                using (var db = new AutoLedgerContext())
                {
                    var car = db.Cars.FirstOrDefault(a => a.PlateId == carPlate.Plate);

                    var carReceptionForm = new CarReceptionForm(car, null)
                          .WithPlateId(carPlate.Plate);

                    var receptionResult = carReceptionForm.ShowDialog();
                }
                if (carsManagerPage != null)
                   carsManagerPage.RefreshCars();
            }
        }
    }
}
