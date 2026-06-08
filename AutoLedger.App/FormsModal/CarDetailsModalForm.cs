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
    public partial class CarDetailsModalForm : Form
    {
        public CarDetailsModalForm(string carPlate)
        {
            InitializeComponent();

          
            this.btnBackToUserDetails.Click += BtnBackToUserDetails_Click;
         
            this.btnFinishCar.Click += BtnFinishCar_Click;
        }

        private void BtnFinishCar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnBackToUserDetails_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
          
        }
    }
}
