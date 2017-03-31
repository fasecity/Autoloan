namespace Autoloan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateApplicantTables : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Applicants", "CarMake", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Applicants", "CarMake");
        }
    }
}
