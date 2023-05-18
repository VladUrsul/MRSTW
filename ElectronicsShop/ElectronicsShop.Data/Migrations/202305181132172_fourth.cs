namespace ElectronicsShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fourth : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Roles", "User_Id", "dbo.Users");
            DropIndex("dbo.Roles", new[] { "User_Id" });
            CreateTable(
                "dbo.UserRoles1",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        RoleName = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RoleName, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleName);
            
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            DropColumn("dbo.Roles", "User_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Roles", "User_Id", c => c.Int());
            DropForeignKey("dbo.UserRoles1", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserRoles", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.UserRoles", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserRoles1", "RoleName", "dbo.Roles");
            DropIndex("dbo.UserRoles", new[] { "RoleId" });
            DropIndex("dbo.UserRoles", new[] { "UserId" });
            DropIndex("dbo.UserRoles1", new[] { "RoleName" });
            DropIndex("dbo.UserRoles1", new[] { "UserId" });
            DropTable("dbo.UserRoles");
            DropTable("dbo.UserRoles1");
            CreateIndex("dbo.Roles", "User_Id");
            AddForeignKey("dbo.Roles", "User_Id", "dbo.Users", "Id");
        }
    }
}
