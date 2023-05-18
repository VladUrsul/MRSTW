namespace ElectronicsShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fifth : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Permissions", "Role_RoleName", "dbo.Roles");
            DropForeignKey("dbo.UserRoles1", "RoleName", "dbo.Roles");
            DropForeignKey("dbo.UserRoles", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserRoles", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.UserRoles1", "UserId", "dbo.Users");
            DropIndex("dbo.Permissions", new[] { "Role_RoleName" });
            DropIndex("dbo.UserRoles1", new[] { "UserId" });
            DropIndex("dbo.UserRoles1", new[] { "RoleName" });
            DropIndex("dbo.UserRoles", new[] { "UserId" });
            DropIndex("dbo.UserRoles", new[] { "RoleId" });
            DropTable("dbo.Roles");
            DropTable("dbo.Permissions");
            DropTable("dbo.UserRoles1");
            DropTable("dbo.UserRoles");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId });
            
            CreateTable(
                "dbo.UserRoles1",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        RoleName = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Permissions",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        Role_RoleName = c.Int(),
                    })
                .PrimaryKey(t => t.Name);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleName = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RoleName);
            
            CreateIndex("dbo.UserRoles", "RoleId");
            CreateIndex("dbo.UserRoles", "UserId");
            CreateIndex("dbo.UserRoles1", "RoleName");
            CreateIndex("dbo.UserRoles1", "UserId");
            CreateIndex("dbo.Permissions", "Role_RoleName");
            AddForeignKey("dbo.UserRoles1", "UserId", "dbo.Users", "Id", cascadeDelete: true);
            AddForeignKey("dbo.UserRoles", "RoleId", "dbo.Roles", "RoleName", cascadeDelete: true);
            AddForeignKey("dbo.UserRoles", "UserId", "dbo.Users", "Id", cascadeDelete: true);
            AddForeignKey("dbo.UserRoles1", "RoleName", "dbo.Roles", "RoleName", cascadeDelete: true);
            AddForeignKey("dbo.Permissions", "Role_RoleName", "dbo.Roles", "RoleName");
        }
    }
}
