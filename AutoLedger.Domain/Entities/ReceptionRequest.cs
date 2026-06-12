using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLedger.Domain
{
    public class ReceptionRequest
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public long Cost { get; set; }

        public int ReceptionId { get; set; }
        public Reception Reception { get; set; }

    }
}
