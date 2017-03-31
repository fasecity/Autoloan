namespace Autoloan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateApplicantTablesFixed : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Applicants", "CarMake");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Applicants", "CarMake", c => c.Int(nullable: false));
        }
    }
}
