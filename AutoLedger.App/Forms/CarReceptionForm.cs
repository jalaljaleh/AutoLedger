using AutoLedger.App.Controls;
using AutoLedger.Data;
using AutoLedger.Domain;
using AutoLedger.Extensions;
using DevExpress.XtraLayout;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AutoLedger.App.Forms
{
    public partial class CarReceptionForm : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        private Car _car;
        private CarReception _reception;

        public CarReceptionForm(Car car = null, CarReception reception = null)
        {
            InitializeComponent();

            btnSubmit.Click += BtnSubmit_Click;
            this.btnBack.Click += BtnBack_Click;
            btnDeleteCurrentRequest.Click += BtnDeleteCurrentRequest_Click;
            btnDeleteAllRequests.Click += BtnDeleteAllRequests_Click;

            dgCarRequests.RowPostPaint += DgCarRequests_RowPostPaint;
            dgCarRequests.CellValueChanged += DgCarRequests_CellValueChanged;
            dgCarRequests.CellFormatting += DgCarRequests_CellFormatting;
            dgCarRequests.CellParsing += DgCarRequests_CellParsing;
            dgCarRequests.EditingControlShowing += DgCarRequests_EditingControlShowing;

            this.cbIsReleased.CheckedChanged += CbIsReleased_CheckedChanged;

            this._car = car;
            this._reception = reception;

            if (_reception != null)
            {
                inputReceptionId.Text = "شماره فاکتور: " + _reception.Id.ToString();
                inputCreatedAt.Text = _reception.CreatedAt.ToShamsiLong();

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
            else
            {
                inputCreatedAt.Text = DateTime.Now.ToShamsiLong();
            }
        }

        private void DgCarRequests_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var col = dgCarRequests.Columns[dgCarRequests.CurrentCell.ColumnIndex];

            if (col.Name == "Title")
            {
                if (e.Control is TextBox tb)
                    tb.MaxLength = 200;
            }
            else if (col.Name == "Description")
            {
                if (e.Control is TextBox tb)
                    tb.MaxLength = 1000;
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
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

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (_reception is null) // insert new reception
            {
                var newReception = BuildReceptionRequests();
                if (newReception.Requests.Count < 1)
                {
                    MessageBox.Show("نمی توان فرم خالی ثبت کرد.");
                    return;
                }

                using (var db = new AutoLedgerContext())
                {
                    try
                    {
                        var dbCar = db.Cars.FirstOrDefault(a => a.Id == _car.Id);
                        if (dbCar.Receptions == null)
                        {
                            dbCar.Receptions = new List<CarReception>();
                        }

                        dbCar.Receptions.Add(newReception);
                        db.SaveChanges();
                    }
                    catch (DbEntityValidationException ex)
                    {
                        var errorMessages = ex.EntityValidationErrors
                                .SelectMany(x => x.ValidationErrors)
                                .Select(x => $"{x.PropertyName}: {x.ErrorMessage}");

                        var fullErrorMessage = string.Join(Environment.NewLine, errorMessages);
                        MessageBox.Show($"خطای اعتبارسنجی مقادیر:\n{fullErrorMessage}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"خطا در ذخیره‌سازی:\n{ex.Message}\n\n{ex.InnerException?.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else // edit reception
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

            var incomingRequests = BuildRequests();

            using (var db = new AutoLedgerContext())
            {
                using (var tx = db.Database.BeginTransaction())
                {
                    try
                    {
                        var reception = db.CarReceptions
                            .Include(r => r.Requests)
                            .FirstOrDefault(r => r.Id == _reception.Id);

                        if (reception == null)
                        {
                            MessageBox.Show("پذیرش برای ویرایش یافت نشد.");
                            return;
                        }

                        reception.IsReleased = cbIsReleased.Checked;
                        reception.IsRepaired = cbIsRepaired.Checked;
                        reception.Mileage = int.TryParse(inputMileage.Text.Trim(), out var m) ? m : reception.Mileage;
                        reception.TotalCost = incomingRequests.Sum(x => Math.Max(0, x.Cost));
                        reception.UpdatedAt = DateTime.Now;

                        // FIX: Assigns 'null' if unchecked instead of year 0001
                        reception.RepairedAt = cbIsRepaired.Checked ? DateTime.Now : (DateTime?)null;
                        reception.ReleasedAt = cbIsReleased.Checked ? DateTime.Now : (DateTime?)null;

                        var existing = reception.Requests.ToList();

                        foreach (var inc in incomingRequests)
                        {
                            if (inc.Id > 0)
                            {
                                var ex = existing.FirstOrDefault(x => x.Id == inc.Id);
                                if (ex != null)
                                {
                                    ex.Title = inc.Title;
                                    ex.Description = inc.Description;
                                    ex.Cost = Math.Max(0, inc.Cost);
                                    ex.UpdatedAt = DateTime.Now;
                                    db.Entry(ex).State = EntityState.Modified;
                                }
                                else
                                {
                                    var newReq = new CarReceptionRequest
                                    {
                                        Title = inc.Title,
                                        Description = inc.Description,
                                        Cost = Math.Max(0, inc.Cost),
                                        ReceptionId = reception.Id,
                                        CreatedAt = DateTime.Now,
                                        UpdatedAt = DateTime.Now
                                    };
                                    db.CarReceptionsRequests.Add(newReq);
                                }
                            }
                            else
                            {
                                var newReq = new CarReceptionRequest
                                {
                                    Title = inc.Title,
                                    Description = inc.Description,
                                    Cost = Math.Max(0, inc.Cost),
                                    ReceptionId = reception.Id,
                                    CreatedAt = DateTime.Now,
                                    UpdatedAt = DateTime.Now
                                };
                                db.CarReceptionsRequests.Add(newReq);
                            }
                        }

                        var incomingIds = incomingRequests.Where(x => x.Id > 0).Select(x => x.Id).ToHashSet();
                        var toRemove = existing.Where(x => !incomingIds.Contains(x.Id)).ToList();
                        foreach (var rem in toRemove)
                        {
                            db.CarReceptionsRequests.Remove(rem);
                        }

                        db.SaveChanges();
                        tx.Commit();
                    }
                    catch (DbEntityValidationException ex)
                    {
                        try { tx.Rollback(); } catch { }
                        var errorMessages = ex.EntityValidationErrors
                                .SelectMany(x => x.ValidationErrors)
                                .Select(x => $"{x.PropertyName}: {x.ErrorMessage}");
                        var fullErrorMessage = string.Join(Environment.NewLine, errorMessages);
                        MessageBox.Show($"خطای اعتبارسنجی مقادیر:\n{fullErrorMessage}");
                    }
                    catch (Exception ex)
                    {
                        try { tx.Rollback(); } catch { }
                        MessageBox.Show("خطا در ذخیره‌سازی: " + ex.Message + "\n" + ex.InnerException?.Message);
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

                var idCell = r.Cells["Id"].Value;
                var id = (idCell != null && idCell != DBNull.Value) ? Convert.ToInt32(idCell) : 0;

                var titleCell = r.Cells["Title"].Value;
                var title = (titleCell != null && titleCell != DBNull.Value && !string.IsNullOrWhiteSpace(titleCell.ToString()))
                    ? titleCell.ToString().Trim()
                    : "بدون عنوان";

                var descCell = r.Cells["Description"].Value;
                var description = (descCell != null && descCell != DBNull.Value && !string.IsNullOrWhiteSpace(descCell.ToString()))
                    ? descCell.ToString().Trim()
                    : "بدون توضیح";

                decimal cost = 0;
                var costCell = r.Cells["Cost"].Value;

                if (costCell != null && costCell != DBNull.Value)
                {
                    if (decimal.TryParse(costCell.ToString(), out decimal parsed))
                    {
                        cost = parsed;
                    }
                }

                var req = new CarReceptionRequest
                {
                    Id = id,
                    Title = title,
                    Description = description,
                    Cost = cost,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
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
                IsReleased = cbIsReleased.Checked,
                IsRepaired = cbIsRepaired.Checked,
                Mileage = int.TryParse(inputMileage.Text, out int millage) ? millage : 0,
                RepairedAt = cbIsRepaired.Checked ? DateTime.Now : (DateTime?)null,  // FIX
                ReleasedAt = cbIsReleased.Checked ? DateTime.Now : (DateTime?)null,  // FIX
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                Requests = list
            };
        }

        private decimal UpdateTotalCostLabel()
        {
            var list = BuildRequests();
            decimal total = list.Sum(a => a.Cost);
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
            if (e.Value == null) return;
            var target = dgCarRequests.Columns[e.ColumnIndex].Name;
            if (target == "Cost")
            {
                long rial;
                if (long.TryParse(e.Value.ToString(), out rial))
                {
                    e.Value = rial.ToString("#,0 تومان");
                    e.FormattingApplied = true;
                }
            }
            else if (target == "CreatedAt" || target == "UpdatedAt")
            {
                DateTime dt;
                if (DateTime.TryParse(e.Value.ToString(), out dt))
                {
                    e.Value = dt.ToShamsi();
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