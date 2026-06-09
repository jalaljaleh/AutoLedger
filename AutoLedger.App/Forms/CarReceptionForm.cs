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
        public CarReceptionForm()
        {
            InitializeComponent();
            IntilizeDataGrid();
            IntilizeDataGridActionButtons();
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
