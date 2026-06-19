using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoLedger.App.FormsModal
{
    public partial class CarPlateModalForm : Form
    {
        public string Plate { get => this.carIdControl.GetPlate(); }
        public CarPlateModalForm(string carPlate = null)
        {
            InitializeComponent();

            this.carIdControl.SetOrClearPlate(carPlate);

            this.btnConfirm.Click += BtnConfirm_Click;
            this.btnCancel.Click += BtnCancel_Click;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                this.carIdControl.SetOrClearPlate(Plate);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}
