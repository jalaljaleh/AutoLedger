using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLedger.Domain
{
    public class CarReceptionRequest
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public long Cost { get; set; }

        public int ReceptionId { get; set; }
        public CarReception Reception { get; set; }

        public int CarId { get; set; }
        public Car Car { get; set; }

    }
}
