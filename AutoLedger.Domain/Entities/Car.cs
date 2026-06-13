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
        public string CarPlateId { get; set; }

        public string Brand { get; set; }
        public int Model { get; set; }
        public string Color { get; set; }
        public string Tip { get; set; }

        public string OwnerFullName { get; set; }
        public string OwnerNationalId { get; set; }
        public string OwnerPhoneNumber { get; set; }

        public DateTime CreatedAt { get; private set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public virtual ICollection<CarReception> Receptions { get; set; } = new HashSet<CarReception>();
        public virtual ICollection<CarReceptionRequest> Requests { get; set; } = new HashSet<CarReceptionRequest>();

    }
}
