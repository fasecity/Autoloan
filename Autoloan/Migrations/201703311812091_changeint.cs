namespace Autoloan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeint : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Applicants", "Age", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Applicants", "Age", c => c.Double(nullable: false));
        }
    }
}
