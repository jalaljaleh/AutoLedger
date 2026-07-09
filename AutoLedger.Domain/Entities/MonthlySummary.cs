using System;

namespace AutoLedger.Domain
{
    public class DailyLedgerSummary
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }

      
        public decimal ShopExpenses { get; set; }
        public decimal ReceptionExpenses { get; set; }
        public decimal ReceptionRevenue { get; set; }

        public decimal TotalRevenue => ReceptionRevenue;
        public decimal TotalExpenses => ShopExpenses + ReceptionExpenses;
        public decimal Profit => TotalRevenue - TotalExpenses;

  
        public int ShopExpensesCount { get; set; }   

        public int NewCarsRegistered { get; set; }    
        public int ReceptionsOpened { get; set; }     
        public int ReceptionsRepaired { get; set; }   
        public int ReceptionsReleased { get; set; }   

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}