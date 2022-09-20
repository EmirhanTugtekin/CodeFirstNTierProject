namespace DAL_Layer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class role : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admins", "AdminRole", c => c.String());
            AddColumn("dbo.Customers", "CustomerRole", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "CustomerRole");
            DropColumn("dbo.Admins", "AdminRole");
        }
    }
}
