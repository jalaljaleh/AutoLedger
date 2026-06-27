using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLedger.Domain
{
    public class Expense
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public bool IsRepeatAble { get; set; }

        public int CategoryId { get; set; }
        public ExpenseCategory Category { get; set; }

        public DateTime CreatedAt { get;  set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
