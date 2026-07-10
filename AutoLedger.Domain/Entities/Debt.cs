using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLedger.Domain
{
    public enum DebtType
    {
        Payable,
        Receivable
    }

    public class Debt
    {
        public int Id { get; set; }
        public string Title { get; set; }      
        public decimal Amount { get; set; }
        public DebtType Type { get; set; }     
        public string Description { get; set; }
        public string DebtTo { get; set; }     
        public bool IsSettled { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
