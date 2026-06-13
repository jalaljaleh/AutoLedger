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

        public bool IsReleased { get; set; }
        public DateTime ReceptionAt { get; set; } = DateTime.Now;

        public DateTime CreatedAt { get; private set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public int CarId { get; set; }
        public Car Car { get; set; }

        public virtual ICollection<CarReceptionRequest> Requests { get; set; } = new HashSet<CarReceptionRequest>();

    }
}
