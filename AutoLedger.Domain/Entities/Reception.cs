using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLedger.Domain
{
    public class Reception
    {
        public int Id { get; private set; }

        public string CarPlateId { get; set; }

        public string CarBrand { get; set; }
        public int CarModel { get; set; }
        public string CarColor { get; set; }
        public string CarTip { get; set; }

        public string FullName { get; set; }
        public string NationalId { get; set; }
        public string PhoneNumber { get; set; }

        public int Mileage { get; set; }

        public bool IsReleased { get; set; }
        public DateTime ReceptionAt { get; set; } = DateTime.Now;

        public DateTime CreatedAt { get; private set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public virtual ICollection<ReceptionRequest> Requests { get; set; } = new HashSet<ReceptionRequest>();

    }
}
