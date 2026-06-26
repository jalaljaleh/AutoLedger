using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLedger.Domain
{
    public class CarReceptionExpense
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }


        public int ReceptionId { get; set; }
        public CarReception Reception { get; set; }


        public DateTime CreatedAt { get;  set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
