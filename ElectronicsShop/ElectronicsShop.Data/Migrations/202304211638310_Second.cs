namespace ElectronicsShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Users");
            AddColumn("dbo.Users", "Identification", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Users", "Identification");
            DropColumn("dbo.Users", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Users");
            DropColumn("dbo.Users", "Identification");
            AddPrimaryKey("dbo.Users", "Id");
        }
    }
}
