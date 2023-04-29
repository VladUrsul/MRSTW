namespace ElectronicsShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Products", "Brand");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Brand", c => c.String());
            DropColumn("dbo.Products", "Price");
        }
    }
}
