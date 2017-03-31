namespace Autoloan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnoations : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Applicants", "CarInsurance_Id", "dbo.CarInsurances");
            DropIndex("dbo.Applicants", new[] { "CarInsurance_Id" });
            AlterColumn("dbo.Applicants", "FirstName", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Applicants", "LastName", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Applicants", "Province", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Applicants", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Applicants", "CarMake", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Applicants", "CarModel", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Applicants", "CarInsurance_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.CarInsurances", "Name", c => c.String(nullable: false, maxLength: 255));
            CreateIndex("dbo.Applicants", "CarInsurance_Id");
            AddForeignKey("dbo.Applicants", "CarInsurance_Id", "dbo.CarInsurances", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Applicants", "CarInsurance_Id", "dbo.CarInsurances");
            DropIndex("dbo.Applicants", new[] { "CarInsurance_Id" });
            AlterColumn("dbo.CarInsurances", "Name", c => c.String());
            AlterColumn("dbo.Applicants", "CarInsurance_Id", c => c.Int());
            AlterColumn("dbo.Applicants", "CarModel", c => c.String());
            AlterColumn("dbo.Applicants", "CarMake", c => c.String());
            AlterColumn("dbo.Applicants", "Email", c => c.String());
            AlterColumn("dbo.Applicants", "Province", c => c.String());
            AlterColumn("dbo.Applicants", "LastName", c => c.String());
            AlterColumn("dbo.Applicants", "FirstName", c => c.String());
            CreateIndex("dbo.Applicants", "CarInsurance_Id");
            AddForeignKey("dbo.Applicants", "CarInsurance_Id", "dbo.CarInsurances", "Id");
        }
    }
}
