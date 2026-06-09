using AutoLedger.App.FormsModal;
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

            this.NewReception.Click += BtnNewCar_Click;
        }

        private void BtnNewCar_Click(object sender, EventArgs e)
        {
            var carPlate = new CarPlateModalForm();
            var plateResult = carPlate.ShowDialog();

            if (plateResult == DialogResult.OK)
            {
                var carReceptionForm = new CarReceptionForm();
                var receptionResult = carReceptionForm.ShowDialog();
            }
        }
    }
}
