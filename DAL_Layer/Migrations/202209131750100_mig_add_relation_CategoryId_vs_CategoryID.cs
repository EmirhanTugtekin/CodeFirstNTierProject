namespace DAL_Layer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_relation_CategoryId_vs_CategoryID : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Products", new[] { "CategoryId" });
            CreateIndex("dbo.Products", "CategoryID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Products", new[] { "CategoryID" });
            CreateIndex("dbo.Products", "CategoryId");
        }
    }
}
