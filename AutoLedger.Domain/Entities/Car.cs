using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLedger.Domain
{
    public class Car
    {
        public int Id { get; private set; }

        public string PlateId { get; set; }

        public string Brand { get; set; }
        public int Model { get; set; }
        public string Color { get; set; }
        public string Tip { get; set; }

        public string FullName { get; set; }
        public string NationalId { get; set; }
        public string PhoneNumber { get; set; }

        public bool IsReleased { get; set; }
        public DateTime ReceptionAt { get; set; } = DateTime.Now;

        public DateTime CreatedAt { get; private set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public virtual ICollection<CarRequest> Requests { get; set; }

    }
}
