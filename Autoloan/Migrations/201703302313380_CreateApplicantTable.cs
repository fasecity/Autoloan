namespace Autoloan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateApplicantTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Applicants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Age = c.Int(nullable: false),
                        Province = c.String(),
                        PhoneNumber = c.Int(nullable: false),
                        Email = c.String(),
                        CarYear = c.Int(nullable: false),
                        Carkilometer = c.Int(nullable: false),
                        CarModel = c.String(),
                        DesiredLoanAmmount = c.Double(nullable: false),
                        MonthlyIncome = c.Double(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                        CarInsurance_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CarInsurances", t => t.CarInsurance_Id)
                .Index(t => t.CarInsurance_Id);
            
            CreateTable(
                "dbo.CarInsurances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Applicants", "CarInsurance_Id", "dbo.CarInsurances");
            DropIndex("dbo.Applicants", new[] { "CarInsurance_Id" });
            DropTable("dbo.CarInsurances");
            DropTable("dbo.Applicants");
        }
    }
}
