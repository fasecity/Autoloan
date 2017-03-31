namespace Autoloan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedouble2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Applicants", "Carkilometer", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Applicants", "Carkilometer", c => c.Int(nullable: false));
        }
    }
}
