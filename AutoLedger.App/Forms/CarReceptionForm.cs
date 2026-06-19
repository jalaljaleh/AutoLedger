using AutoLedger.App.Controls;
using AutoLedger.Data;
using AutoLedger.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AutoLedger.App.Forms
{
    public partial class CarReceptionForm : Form
    {
        private Car _car;
        private CarReception _reception;
        public CarReceptionForm(Car car = null, CarReception reception = null)
        {
            InitializeComponent();

            btnSubmit.Click += BtnSubmit_Click;
            btnDeleteCurrentRequest.Click += BtnDeleteCurrentRequest_Click;
            btnDeleteAllRequests.Click += BtnDeleteAllRequests_Click;

            dgCarRequests.RowPostPaint += DgCarRequests_RowPostPaint;
            dgCarRequests.CellValueChanged += DgCarRequests_CellValueChanged;
            dgCarRequests.CellFormatting += DgCarRequests_CellFormatting;
            dgCarRequests.CellParsing += DgCarRequests_CellParsing;

            this.cbIsReleased.CheckedChanged += CbIsReleased_CheckedChanged;

            this._car = car;
            this._reception = reception;

            if (_car != null)
            {
                inputBrand.Text = _car.Brand;
                inputModel.Text = _car.Model.ToString();
                inputColor.Text = _car.Color;
                inputTip.Text = _car.Tip;
                inputPhoneNumber.Text = _car.OwnerPhoneNumber;
                inputFullName.Text = _car.OwnerFullName;
                inputUserCardId.Text = _car.OwnerNationalId;

                panelRight.Enabled = false;
            }

            if (_reception != null)
            {
                dateReceptionAt.Value = _reception.CreatedAt;
                inputMileage.Text = _reception.Mileage.ToString();
                cbIsReleased.Checked = _reception.IsReleased;
                cbIsRepaired.Checked = _reception.IsRepaired;

                using (var db = new AutoLedgerContext())
                {
                    var reqs = db.CarReceptionsRequests.Where(a => a.ReceptionId == this._reception.Id).ToList();
                    foreach (var req in reqs)
                    {
                        dgCarRequests.Rows.Add(null, req.Id, req.Title, req.Description, req.Cost, req.CreatedAt, req.UpdatedAt);
                    }
                }
            }

        }

        private void CbIsReleased_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIsReleased.Checked)
            {
                cbIsRepaired.Checked = true;
                cbIsRepaired.Enabled = false;
            }
            else
            {
                cbIsRepaired.Enabled = true;
            }
        }

        public CarReceptionForm WithPlateId(string plate)
        {
            this.carIdControl.SetOrClearPlate(plate);
            return this;
        }
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (_car is null) // insert
            {
                int model = 0;
                int.TryParse(inputModel.Text.Trim(), out model);

                Car newCar = new Car
                {
                    PlateId = carIdControl.GetPlate(),
                    Brand = inputBrand.Text.Trim(),
                    Model = model,
                    Color = inputColor.Text.Trim(),
                    Tip = inputTip.Text.Trim(),
                    OwnerPhoneNumber = inputPhoneNumber.Text.Trim(),
                    OwnerFullName = inputFullName.Text.Trim(),
                    OwnerNationalId = inputUserCardId.Text.Trim(),
                    UpdatedAt = DateTime.Now,
                    Receptions = new List<CarReception>() { BuildReceptionRequests() }
                };

                using (var db = new AutoLedgerContext())
                {
                    db.Cars.Add(newCar);
                    db.SaveChanges();
                }
            }
            else if (_reception is null) // insert new reception
            {
                var newReception = BuildReceptionRequests();
                if (newReception.Requests.Count < 1)
                {
                    MessageBox.Show("نمی توان فرم خالی ثبت کرد.");
                    return;
                }

                using (var db = new AutoLedgerContext())
                {
                    var dbCar = db.Cars.FirstOrDefault(a => a.Id == _car.Id);
                    dbCar.Receptions.Add(newReception);
                    db.SaveChanges();
                }
            }
            else if (_reception != null) // edit reception
            {
                UpdateExistingReceptionWithRequests();
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void UpdateExistingReceptionWithRequests()
        {
            if (_reception == null || _car == null)
            {
                MessageBox.Show("هیچ پذیرشی برای ویرایش انتخاب نشده است.");
                return;
            }

            // Build incoming requests from UI (includes Id if you added hidden Id column)
            var incomingRequests = BuildRequests();

            using (var db = new AutoLedgerContext())
            {
                using (var tx = db.Database.BeginTransaction())
                {
                    try
                    {
                        // Load the reception with its requests (tracked by this context)
                        var reception = db.CarReceptions
                            .Include(r => r.Requests)
                            .FirstOrDefault(r => r.Id == _reception.Id);

                        if (reception == null)
                        {
                            MessageBox.Show("پذیرش برای ویرایش یافت نشد.");
                            return;
                        }

                        // Update scalar fields
                        reception.CreatedAt = dateReceptionAt.Value;
                        reception.IsReleased = cbIsReleased.Checked;
                        reception.IsRepaired = cbIsRepaired.Checked;
                        reception.Mileage = int.TryParse(inputMileage.Text.Trim(), out var m) ? m : reception.Mileage;
                        reception.TotalCost = incomingRequests.Sum(x => Math.Max(0, x.Cost));
                        reception.UpdatedAt = DateTime.Now;
                        reception.RepairedAt = cbIsRepaired.Checked ? DateTime.Now : DateTime.MinValue;
                        reception.ReleasedAt = cbIsReleased.Checked ? DateTime.Now : DateTime.MinValue;
                     
                        // Existing requests in DB
                        var existing = reception.Requests.ToList();

                        // Add or update incoming requests
                        foreach (var inc in incomingRequests)
                        {
                            if (inc.Id > 0)
                            {
                                // update existing
                                var ex = existing.FirstOrDefault(x => x.Id == inc.Id);
                                if (ex != null)
                                {
                                    ex.Title = inc.Title;
                                    ex.Description = inc.Description;
                                    ex.Cost = Math.Max(0, inc.Cost);
                                    ex.UpdatedAt = DateTime.Now;
                                    ex.CreatedAt = inc.CreatedAt; // preserve original creation time
                                    db.Entry(ex).State = EntityState.Modified;
                                }
                                else
                                {
                                    // Id provided but not found in this reception -> treat as new
                                    var newReq = new CarReceptionRequest
                                    {
                                        Title = inc.Title,
                                        Description = inc.Description,
                                        Cost = Math.Max(0, inc.Cost),
                                        ReceptionId = reception.Id
                                    };
                                    db.CarReceptionsRequests.Add(newReq);
                                }
                            }
                            else
                            {
                                // new request
                                var newReq = new CarReceptionRequest
                                {
                                    Title = inc.Title,
                                    Description = inc.Description,
                                    Cost = Math.Max(0, inc.Cost),
                                    ReceptionId = reception.Id
                                };
                                db.CarReceptionsRequests.Add(newReq);
                            }
                        }

                        // Remove deleted requests
                        var incomingIds = incomingRequests.Where(x => x.Id > 0).Select(x => x.Id).ToHashSet();
                        var toRemove = existing.Where(x => !incomingIds.Contains(x.Id)).ToList();
                        foreach (var rem in toRemove)
                        {
                            db.CarReceptionsRequests.Remove(rem);
                        }

                        // Persist changes
                        db.SaveChanges();
                        tx.Commit();

                        MessageBox.Show("پذیرش با موفقیت به‌روزرسانی شد.");
                    }
                    catch (Exception ex)
                    {
                        try { tx.Rollback(); } catch { }
                        MessageBox.Show("خطا در ذخیره‌سازی: " + ex.Message);
                    }
                }
            }
        }
        private List<CarReceptionRequest> BuildRequests()
        {
            var list = new List<CarReceptionRequest>();
            foreach (DataGridViewRow r in dgCarRequests.Rows)
            {
                if (r.IsNewRow) continue;
                var req = new CarReceptionRequest
                {
                    Id = r.Cells["Id"].Value != null ? Convert.ToInt32(r.Cells["Id"].Value) : 0,
                    CreatedAt = r.Cells["CreatedAt"].Value != null ? Convert.ToDateTime(r.Cells["CreatedAt"].Value) : DateTime.Now,
                    Title = r.Cells["Title"].Value != null ? r.Cells["Title"].Value.ToString().Trim() : "بدون عنوان",
                    Description = r.Cells["Description"].Value != null ? r.Cells["Description"].Value.ToString().Trim() : "بدون توضیح",
                    Cost = r.Cells["Cost"].Value != null ? Convert.ToInt64(r.Cells["Cost"].Value) : 0
                };
                list.Add(req);
            }
            return list;
        }
        private CarReception BuildReceptionRequests()
        {
            var list = BuildRequests();
            return new CarReception
            {
                TotalCost = list.Sum(a => a.Cost),
                CreatedAt = dateReceptionAt.Value,
                IsReleased = cbIsReleased.Checked,
                IsRepaired = cbIsRepaired.Checked,
                UpdatedAt = DateTime.Now,
                Requests = list
            };
        }

        private long UpdateTotalCostLabel()
        {
            var list = BuildRequests();
            long total = list.Sum(a => a.Cost);
            labelTotalCost.Text = "جمع کل: " + total.ToString("#,0 تومان");
            return total;
        }

        private void BtnDeleteCurrentRequest_Click(object sender, EventArgs e)
        {
            if (dgCarRequests.CurrentRow != null && !dgCarRequests.CurrentRow.IsNewRow)
            {
                dgCarRequests.Rows.Remove(dgCarRequests.CurrentRow);
                UpdateTotalCostLabel();
            }
        }

        private void BtnDeleteAllRequests_Click(object sender, EventArgs e)
        {
            dgCarRequests.Rows.Clear();
            UpdateTotalCostLabel();
        }

        private void DgCarRequests_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgCarRequests.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void DgCarRequests_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgCarRequests.Columns[e.ColumnIndex].Name == "Cost")
            {
                UpdateTotalCostLabel();
            }
        }

        private void DgCarRequests_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgCarRequests.Columns[e.ColumnIndex].Name == "Cost" && e.Value != null)
            {
                long rial;
                if (long.TryParse(e.Value.ToString(), out rial))
                {
                    e.Value = rial.ToString("#,0 تومان");
                    e.FormattingApplied = true;
                }
            }
        }

        private void DgCarRequests_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            if (dgCarRequests.Columns[e.ColumnIndex].Name == "Cost" && e.Value != null)
            {
                var raw = e.Value.ToString().Replace("تومان", "").Replace(",", "").Trim();
                long toman;
                if (long.TryParse(raw, out toman))
                {
                    e.Value = toman;
                    e.ParsingApplied = true;
                }
            }
        }

    }

}
