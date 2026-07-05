using AutoLedger.App.FormsModal;
using AutoLedger.App.FormsView;
using AutoLedger.Data;
using AutoLedger.Domain;
using AutoLedger.Extensions;
using DevExpress.XtraBars.Navigation;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AutoLedger.App.Forms
{
    public partial class DashboardForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private CarsManagerPage _carsManagerPage;
        private CarsManagerPage _carsManagerCurrentPage;
        private ExpensesManagerPage _expensesManagerPage;
        private AccountingReportsPage _accountingReportsPage;

        public DashboardForm()
        {
            InitializeComponent();

            this.barLabelTime.Caption = DateTime.Now.ToShamsiLong();

            this.btnNewReception.Click += BtnNewCar_Click;
            this.btnNewExpens.Click += BtnNewExpens_Click;
      

            this.btnAllCars.Click += ViewButtons_Click;
            this.btnCurrentCars.Click += ViewButtons_Click;
            this.btnExpenses.Click += ViewButtons_Click;
            this.btnSummary.Click += ViewButtons_Click;

            this.barLabelUser.Caption = Program.User.FullName;
        }

      

        private void ViewButtons_Click(object sender, EventArgs e)
        {
            var btn = sender as AccordionControlElement;
            if (btn == null) return;

            switch (btn.Name)
            {
                case "btnAllCars":
                case "btnCurrentCars":

                    if (_carsManagerPage == null)
                        _carsManagerPage = new CarsManagerPage(btn.Name == "btnCurrentCars"); // all cars
                    else
                        _carsManagerPage.CheckCurrentCars(btn.Name == "btnCurrentCars");
                   
                    ShowControl(_carsManagerPage);
                    break;

                case "btnExpenses":
                    if (_expensesManagerPage == null)
                        _expensesManagerPage = new ExpensesManagerPage();
                    ShowControl(_expensesManagerPage);
                    break;

                case "btnSummary":
                    if (_accountingReportsPage == null)
                        _accountingReportsPage = new AccountingReportsPage();
                    ShowControl(_accountingReportsPage);
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
        private void BtnNewExpens_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new ExpenseForm())
                {
                    if (form.ShowDialog() == DialogResult.OK)
                        if (_expensesManagerPage != null)
                        {
                            //      _expensesManagerPage.
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در باز کردن فرم ثبت هزینه: " + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    _carsManagerPage?.RefreshCars();
                    _carsManagerCurrentPage?.RefreshCars();
                }
            }
        }


    }
}
