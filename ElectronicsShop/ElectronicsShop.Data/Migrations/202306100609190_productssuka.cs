namespace ElectronicsShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class productssuka : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ImageUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "ImageUrl");
        }
    }
}
