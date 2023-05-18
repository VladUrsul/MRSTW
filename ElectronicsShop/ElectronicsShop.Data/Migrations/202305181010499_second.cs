namespace ElectronicsShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleName = c.Int(nullable: false),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.RoleName)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Permissions",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        Role_RoleName = c.Int(),
                    })
                .PrimaryKey(t => t.Name)
                .ForeignKey("dbo.Roles", t => t.Role_RoleName)
                .Index(t => t.Role_RoleName);
            
            AlterColumn("dbo.Users", "UserName", c => c.String());
            AlterColumn("dbo.Users", "Email", c => c.String());
            AlterColumn("dbo.Users", "PasswordHash", c => c.String());
            DropColumn("dbo.Users", "Role");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Role", c => c.Int(nullable: false));
            DropForeignKey("dbo.Roles", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Permissions", "Role_RoleName", "dbo.Roles");
            DropIndex("dbo.Permissions", new[] { "Role_RoleName" });
            DropIndex("dbo.Roles", new[] { "User_Id" });
            AlterColumn("dbo.Users", "PasswordHash", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "UserName", c => c.String(nullable: false));
            DropTable("dbo.Permissions");
            DropTable("dbo.Roles");
        }
    }
}
