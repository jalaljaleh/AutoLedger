using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLedger.Domain
{
    public class ExpenseCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Expense> Expenses { get; set; } = new HashSet<Expense>();


        public ExpenseCategory WithName(string name)
        {
            Name = name;
            return this;
        }
    }
}
