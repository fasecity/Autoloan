namespace Autoloan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulategenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CarInsurances (Name) VALUES ('Full coverage')");
            Sql("INSERT INTO CarInsurances (Name) VALUES ('liability only coverage')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM CarInsurances WHERE Id IN (1,2) ");
        }
    }
}
