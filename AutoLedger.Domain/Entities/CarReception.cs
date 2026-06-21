using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLedger.Domain
{
    public class CarReception
    {
        public int Id { get; private set; }

        public int Mileage { get; set; }
        public decimal TotalCost { get; set; }
        public bool IsReleased { get; set; }
        public bool IsRepaired { get; set; }

        public int CarId { get; set; }
        public Car Car { get; set; }

        public DateTime RepairedAt { get; set; } = DateTime.MinValue;
        public DateTime ReleasedAt { get; set; } = DateTime.MinValue;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public virtual ICollection<CarReceptionRequest> Requests { get; set; } = new HashSet<CarReceptionRequest>();
        public virtual ICollection<Expense> Expenses { get; set; } = new HashSet<Expense>();

    }
}
