namespace Autoloan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateApplicantTablesAddCarMake : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Applicants", "CarMake", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Applicants", "CarMake");
        }
    }
}
