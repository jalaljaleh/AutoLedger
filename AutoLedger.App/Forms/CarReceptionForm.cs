using AutoLedger.Data;
using AutoLedger.Domain;
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
    public partial class CarReceptionForm : Form
    {
        public CarReceptionForm(string carPlateId)
        {
            InitializeComponent();
            IntilizeDataGrid();
            IntilizeDataGridActionButtons();

            this.carId.SetOrClearPlate(carPlateId);

            using (var db = new AutoLedgerContext())
            {
                var car = db.Cars.FirstOrDefault(a => a.CarPlateId == carPlateId);
                if (car != null)
                {
                    inputBrand.Text = car.Brand;
                    inputModel.Text = car.Model.ToString();
                    inputColor.Text = car.Color;
                    inputTip.Text = car.Tip;

                    inputPhoneNumber.Text = car.OwnerPhoneNumber;
                    inputFullName.Text = car.OwnerFullName;
                    inputUserCardId.Text = car.OwnerNationalId;
                }
                else // car not exist 
                {
                        
                }
            }



            this.btnSubmit.Click += BtnSubmit_Click;
        }


        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var reception = new CarReception()
                {
                    CarPlateId = carId.GetPlate(),
                    CarBrand = inputBrand.Text.Trim(),
                    CarModel = int.Parse(inputModel.Text.Trim()),
                    CarColor = inputColor.Text.Trim(),
                    CarTip = inputTip.Text.Trim(),
                    Mileage = int.Parse(inputMileage.Text.Trim()),
                    NationalId = inputUserCardId.Text.Trim(),
                    PhoneNumber = inputPhoneNumber.Text.Trim(),
                    FullName = inputFullName.Text.Trim(),
                    ReceptionAt = dateReceptionAt.Value,

                    IsReleased = cBoxIsReleased.Checked,

                    UpdatedAt = DateTime.Now,
                    Requests = dgCarRequests.Rows.Cast<DataGridViewRow>()
                        .Where(r => r.IsNewRow == false)
                        .Select(r => new CarReceptionRequest()
                        {
                            Title = r.Cells["Title"].Value?.ToString().Trim(),
                            Description = r.Cells["Description"].Value?.ToString().Trim(),
                            Cost = r.Cells["Cost"].Value != null ? Convert.ToInt64(r.Cells["Cost"].Value) : 0
                        }).ToList()
                };

                using (var context = new AutoLedgerContext())
                {
                    context.CarReceptions.Add(reception);
                    context.SaveChanges();
                }
                this.Close();
            }
            catch (Exception v)
            {
                MessageBox.Show(v.ToString());
            }
        }

        void IntilizeDataGridActionButtons()
        {
            this.btnDeleteCurrentRequest.Click += (s, e) =>
            {
                if (dgCarRequests.CurrentRow != null && dgCarRequests.CurrentRow.IsNewRow != true)
                {
                    dgCarRequests.Rows.Remove(dgCarRequests.CurrentRow);
                }
            };
            this.btnDeleteAllRequests.Click += (s, e) =>
            {
                dgCarRequests.Rows.Clear();
            };
        }
        void IntilizeDataGrid()
        {

            dgCarRequests.RowPostPaint += (s, e) =>
            {
                var grid = (DataGridView)s;
                string index = (e.RowIndex + 1).ToString();

                grid.Rows[e.RowIndex].Cells[0].Value = index;
            };

            dgCarRequests.CellValueChanged += (s, e) =>
            {
                if (dgCarRequests.Columns[e.ColumnIndex].Name == "Cost" && e.RowIndex >= 0)
                {
                    labelTotalCost.Text = "جمع کل: " + dgCarRequests.Rows.Cast<DataGridViewRow>()
                        .Where(r => r.Cells["Cost"].Value != null)
                        .Sum(r => Convert.ToInt64(r.Cells["Cost"].Value))
                        .ToString("#,0 تومان");
                }
            };
            dgCarRequests.CellFormatting += (s, e) =>
            {
                if (dgCarRequests.Columns[e.ColumnIndex].Name == "Cost" && e.Value != null)
                {
                    if (long.TryParse(e.Value.ToString(), out long rial))
                    {
                        e.Value = rial.ToString("#,0 تومان");
                        e.FormattingApplied = true;
                    }
                }
            };
            dgCarRequests.CellParsing += (s, e) =>
            {
                if (dgCarRequests.Columns[e.ColumnIndex].Name == "Cost" && e.Value != null)
                {
                    string raw = e.Value.ToString()
                        .Replace("تومان", "")
                        .Replace(",", "")
                        .Trim();

                    if (long.TryParse(raw, out long toman))
                    {
                        e.Value = toman;
                        e.ParsingApplied = true;
                    }
                }
            };
        }


    }


}
