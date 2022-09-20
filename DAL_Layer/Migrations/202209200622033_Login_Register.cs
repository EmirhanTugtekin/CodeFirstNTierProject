namespace DAL_Layer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Login_Register : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "CustomerPassword", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "CustomerPassword");
        }
    }
}
