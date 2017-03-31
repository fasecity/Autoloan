namespace Autoloan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedouble : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Applicants", "PhoneNumber", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Applicants", "PhoneNumber", c => c.Int(nullable: false));
        }
    }
}
