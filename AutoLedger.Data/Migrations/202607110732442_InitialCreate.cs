namespace AutoLedger.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CarReceptions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Mileage = c.Int(nullable: false),
                        IsReleased = c.Boolean(nullable: false),
                        IsRepaired = c.Boolean(nullable: false),
                        IsExpensesProvided = c.Boolean(nullable: false),
                        RepairedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        ReleasedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        CreatedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        UpdatedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        TotalCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalExpenses = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CarId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cars", t => t.CarId, cascadeDelete: true)
                .Index(t => t.IsReleased, name: "IX_CarReceptions_IsReleased")
                .Index(t => t.IsRepaired, name: "IX_CarReceptions_IsRepaired")
                .Index(t => t.CarId);
            
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PlateId = c.String(nullable: false, maxLength: 20),
                        Brand = c.String(maxLength: 20),
                        Model = c.Int(nullable: false),
                        Color = c.String(maxLength: 20),
                        Tip = c.String(maxLength: 20),
                        OwnerFullName = c.String(nullable: false, maxLength: 25),
                        OwnerNationalId = c.String(nullable: false, maxLength: 10),
                        OwnerPhoneNumber = c.String(nullable: false, maxLength: 15),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.PlateId, name: "IX_Car_CarPlateId")
                .Index(t => t.OwnerFullName, name: "IX_Car_FullName")
                .Index(t => t.OwnerNationalId, name: "IX_Car_NationalId")
                .Index(t => t.OwnerPhoneNumber, name: "IX_Car_PhoneNumber");
            
            CreateTable(
                "dbo.CarReceptionExpenses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 100),
                        Description = c.String(maxLength: 200),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PaidTo = c.String(maxLength: 100),
                        PaymentMethod = c.String(maxLength: 100),
                        ReceptionId = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        UpdatedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CarReceptions", t => t.ReceptionId, cascadeDelete: true)
                .Index(t => t.Title, name: "IX_CarReceptionExpenses_Title")
                .Index(t => t.PaidTo, name: "IX_CarReceptionExpenses_PaidTo")
                .Index(t => t.PaymentMethod, name: "IX_CarReceptionExpenses_PaymentMethod")
                .Index(t => t.ReceptionId);
            
            CreateTable(
                "dbo.CarReceptionRequests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 200),
                        Description = c.String(maxLength: 1000),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ReceptionId = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        UpdatedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CarReceptions", t => t.ReceptionId, cascadeDelete: true)
                .Index(t => t.Title, name: "IX_CarReceptionRequests_Title")
                .Index(t => t.ReceptionId, name: "IX_CarReceptionRequests_ReceptionId");
            
            CreateTable(
                "dbo.DailySummaries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false, storeType: "date"),
                        Year = c.Int(nullable: false),
                        Month = c.Int(nullable: false),
                        Day = c.Int(nullable: false),
                        ShopExpenses = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ReceptionExpenses = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ReceptionRevenue = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ShopExpensesCount = c.Int(nullable: false),
                        NewCarsRegistered = c.Int(nullable: false),
                        ReceptionsOpened = c.Int(nullable: false),
                        ReceptionsRepaired = c.Int(nullable: false),
                        ReceptionsReleased = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        UpdatedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Date, unique: true, name: "IX_DailySummaries_Date");
            
            CreateTable(
                "dbo.Debts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 100),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(),
                        DebtTo = c.String(nullable: false, maxLength: 30),
                        Type = c.Int(nullable: false),
                        IsSettled = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.DebtTo, name: "IX_Debt_DebtTo")
                .Index(t => new { t.Type, t.IsSettled }, name: "IX_Debt_Type_IsSettled");
            
            CreateTable(
                "dbo.ExpenseCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "IX_ExpenseCategory_Name");
            
            CreateTable(
                "dbo.Expenses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 100),
                        Description = c.String(maxLength: 300),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PaidTo = c.String(),
                        PaymentMethod = c.String(),
                        CategoryId = c.Int(nullable: false),
                        ExpenseDate = c.DateTime(nullable: false),
                        CreatedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        UpdatedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ExpenseCategories", t => t.CategoryId)
                .Index(t => t.CategoryId, name: "IX_Expense_CategoryId");
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false, maxLength: 100),
                        Password = c.String(maxLength: 15),
                        Address = c.String(maxLength: 200),
                        NationalId = c.String(maxLength: 11),
                        Description = c.String(maxLength: 500),
                        PhoneNumber = c.String(maxLength: 15),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Expenses", "CategoryId", "dbo.ExpenseCategories");
            DropForeignKey("dbo.CarReceptionRequests", "ReceptionId", "dbo.CarReceptions");
            DropForeignKey("dbo.CarReceptionExpenses", "ReceptionId", "dbo.CarReceptions");
            DropForeignKey("dbo.CarReceptions", "CarId", "dbo.Cars");
            DropIndex("dbo.Expenses", "IX_Expense_CategoryId");
            DropIndex("dbo.ExpenseCategories", "IX_ExpenseCategory_Name");
            DropIndex("dbo.Debts", "IX_Debt_Type_IsSettled");
            DropIndex("dbo.Debts", "IX_Debt_DebtTo");
            DropIndex("dbo.DailySummaries", "IX_DailySummaries_Date");
            DropIndex("dbo.CarReceptionRequests", "IX_CarReceptionRequests_ReceptionId");
            DropIndex("dbo.CarReceptionRequests", "IX_CarReceptionRequests_Title");
            DropIndex("dbo.CarReceptionExpenses", new[] { "ReceptionId" });
            DropIndex("dbo.CarReceptionExpenses", "IX_CarReceptionExpenses_PaymentMethod");
            DropIndex("dbo.CarReceptionExpenses", "IX_CarReceptionExpenses_PaidTo");
            DropIndex("dbo.CarReceptionExpenses", "IX_CarReceptionExpenses_Title");
            DropIndex("dbo.Cars", "IX_Car_PhoneNumber");
            DropIndex("dbo.Cars", "IX_Car_NationalId");
            DropIndex("dbo.Cars", "IX_Car_FullName");
            DropIndex("dbo.Cars", "IX_Car_CarPlateId");
            DropIndex("dbo.CarReceptions", new[] { "CarId" });
            DropIndex("dbo.CarReceptions", "IX_CarReceptions_IsRepaired");
            DropIndex("dbo.CarReceptions", "IX_CarReceptions_IsReleased");
            DropTable("dbo.Users");
            DropTable("dbo.Expenses");
            DropTable("dbo.ExpenseCategories");
            DropTable("dbo.Debts");
            DropTable("dbo.DailySummaries");
            DropTable("dbo.CarReceptionRequests");
            DropTable("dbo.CarReceptionExpenses");
            DropTable("dbo.Cars");
            DropTable("dbo.CarReceptions");
        }
    }
}
