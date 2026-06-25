using System;
using System.Collections.Generic;
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

        public decimal TotalRevenue { get; set; } 
        public decimal TotalExpenses { get; set; } 
        public int TotalReceptions { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }


}
