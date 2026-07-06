using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AutoLedger.Domain
{
    public class MonthlySummary
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }

        public decimal Revenue { get; set; }
        public decimal Expenses { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public decimal Profit
        {
            get
            {
                var res = Revenue - Expenses;
                return res >= 0 ? res : 0;
            }
        }


        //public int TotallExpensesCount { get; set; }
        //public int TotallCarReceptionsCount { get; set; }
        //public int Total { get; set; }
    }


}
