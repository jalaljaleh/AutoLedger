using System;

namespace AutoLedger.Domain
{
    public class CarReceptionRequest
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }

        public int ReceptionId { get; set; }
        public CarReception Reception { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}