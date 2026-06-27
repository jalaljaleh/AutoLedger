using AutoLedger.App.Controls;
using AutoLedger.Data;
using AutoLedger.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoLedger.App.Forms
{
    public partial class CarReceptionExpenseForm : Form
    {
        private CarReception _reception;
        public CarReceptionExpenseForm(CarReception reception)
        {
            InitializeComponent();
            this._reception = reception;

            btnSubmit.Click += BtnSubmit_Click;
            btnCancel.Click += BtnCancel_Click;
            btnDeleteCurrentRequest.Click += BtnDeleteCurrentRequest_Click;
            btnDeleteAllRequests.Click += BtnDeleteAllRequests_Click;

            dgCarExpenses.RowPostPaint += dgCarExpenses_RowPostPaint;
            dgCarExpenses.CellValueChanged += dgCarExpenses_CellValueChanged;
            dgCarExpenses.CellFormatting += dgCarExpenses_CellFormatting;
            dgCarExpenses.CellParsing += dgCarExpenses_CellParsing;


            if (_reception != null)
            {
                inputReceptionId.Text = _reception.Id.ToString();
                //  dateReceptionAt.Value = _reception.CreatedAt;


                using (var db = new AutoLedgerContext())
                {
                    //var reqs = db.CarReceptionsRequests.Where(a => a.ReceptionId == this._reception.Id).ToList();
                    //foreach (var req in reqs)
                    //    dgCarRequests.Rows.Add(req.Id, req.Title, req.Description, req.Cost);

                    var expenss = db.CarReceptionsExpenses.Where(a => a.ReceptionId == this._reception.Id).ToList();
                    foreach (var exp in expenss)
                        dgCarExpenses.Rows.Add(null, exp.Id, exp.Title, exp.Description, exp.Amount, exp.PaidTo, exp.PaymentMethod, exp.CreatedAt, exp.UpdatedAt);
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            var incomingRequests = BuildRequests();

            using (var db = new AutoLedgerContext())
            {
                using (var tx = db.Database.BeginTransaction())
                {
                    try
                    {
                        // Load the reception with its requests (tracked by this context)
                        var reception = db.CarReceptions
                            .Include(r => r.Expenses)
                            .FirstOrDefault(r => r.Id == _reception.Id);

                        if (reception == null)
                        {
                            MessageBox.Show("پذیرش برای ویرایش یافت نشد.");
                            return;
                        }

                        // Update scalar fields

                        reception.TotalExpenses = incomingRequests.Sum(x => Math.Max(0, x.Amount));
                        reception.UpdatedAt = DateTime.Now;
                        reception.IsExpensesProvided = true;

                        // Existing requests in DB
                        var existing = reception.Expenses.ToList();

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
                                    ex.Amount = Math.Max(0, inc.Amount);
                                    ex.PaidTo = inc.PaidTo;
                                    ex.PaymentMethod = inc.PaymentMethod;
                                    ex.UpdatedAt = DateTime.Now;
                                    ex.CreatedAt = inc.CreatedAt; // preserve original creation time
                                    db.Entry(ex).State = EntityState.Modified;
                                }
                                else
                                {
                                    // Id provided but not found in this reception -> treat as new
                                    var newReq = new CarReceptionExpense
                                    {
                                        Title = inc.Title,
                                        Description = inc.Description,
                                        Amount = Math.Max(0, inc.Amount),
                                        PaidTo = inc.PaidTo,
                                        PaymentMethod = inc.PaymentMethod,
                                        ReceptionId = reception.Id,
                                        
                                    };
                                    db.CarReceptionsExpenses.Add(newReq);
                                }
                            }
                            else
                            {
                                // new request
                                var newReq = new CarReceptionExpense
                                {
                                    Title = inc.Title,
                                    Description = inc.Description,
                                    Amount = Math.Max(0, inc.Amount),
                                    PaidTo = inc.PaidTo,
                                    PaymentMethod = inc.PaymentMethod,
                                    ReceptionId = reception.Id
                                };
                                db.CarReceptionsExpenses.Add(newReq);
                            }
                        }

                        // Remove deleted requests
                        var incomingIds = incomingRequests.Where(x => x.Id > 0).Select(x => x.Id).ToHashSet();
                        var toRemove = existing.Where(x => !incomingIds.Contains(x.Id)).ToList();
                        foreach (var rem in toRemove)
                        {
                            db.CarReceptionsExpenses.Remove(rem);
                        }

                        // Persist changes
                        db.SaveChanges();
                        tx.Commit();
                    }
                    catch (Exception ex)
                    {
                        try { tx.Rollback(); } catch { }
                        MessageBox.Show("خطا در ذخیره‌سازی: " + ex.Message);
                    }
                }
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private List<CarReceptionExpense> BuildRequests()
        {
            var list = new List<CarReceptionExpense>();
            foreach (DataGridViewRow r in dgCarExpenses.Rows)
            {
                if (r.IsNewRow) continue;
                var req = new CarReceptionExpense
                {
                    Id = r.Cells["Id"].Value != null ? Convert.ToInt32(r.Cells["Id"].Value) : 0,
                    CreatedAt = r.Cells["CreatedAt"].Value != null ? Convert.ToDateTime(r.Cells["CreatedAt"].Value) : DateTime.Now,
                    Title = r.Cells["Title"].Value != null ? r.Cells["Title"].Value.ToString().Trim() : "بدون عنوان",
                    Description = r.Cells["Description"].Value != null ? r.Cells["Description"].Value.ToString().Trim() : "بدون توضیح",
                    Amount = r.Cells["Amount"].Value != null ? Convert.ToInt64(r.Cells["Amount"].Value) : 0,
                    PaidTo = r.Cells["PaidTo"].Value != null ? r.Cells["PaidTo"].Value.ToString().Trim() : "[نامشخص]",
                    PaymentMethod = r.Cells["PaymentMethod"].Value != null ? r.Cells["PaymentMethod"].Value.ToString().Trim() : "[نامعین]"
                };
                list.Add(req);
            }
            return list;
        }
        private decimal UpdateTotalCostLabel()
        {
            var list = BuildRequests();
            decimal total = list.Sum(a => a.Amount);
            labelTotalCost.Text = "جمع کل: " + total.ToString("#,0 تومان");
            return total;
        }

        private void BtnDeleteCurrentRequest_Click(object sender, EventArgs e)
        {
            if (dgCarExpenses.CurrentRow != null && !dgCarExpenses.CurrentRow.IsNewRow)
            {
                dgCarExpenses.Rows.Remove(dgCarExpenses.CurrentRow);
            }
            UpdateTotalCostLabel();
        }

        private void BtnDeleteAllRequests_Click(object sender, EventArgs e)
        {
            dgCarExpenses.Rows.Clear();
            UpdateTotalCostLabel();
        }
        private void dgCarExpenses_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgCarExpenses.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dgCarExpenses_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgCarExpenses.Columns[e.ColumnIndex].Name == "Amount")
            {
                UpdateTotalCostLabel();
            }
        }

        private void dgCarExpenses_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgCarExpenses.Columns[e.ColumnIndex].Name == "Amount" && e.Value != null)
            {
                long rial;
                if (long.TryParse(e.Value.ToString(), out rial))
                {
                    e.Value = rial.ToString("#,0 تومان");
                    e.FormattingApplied = true;
                }
            }
        }

        private void dgCarExpenses_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            if (dgCarExpenses.Columns[e.ColumnIndex].Name == "Amount" && e.Value != null)
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
