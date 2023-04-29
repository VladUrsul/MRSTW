using ElectronicsShop.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Reflection.Emit;

namespace ElectronicsShop.Data.Contexts
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext() : base("name=ElectronicsShopDb")
        {
        }

        public ShopDbContext(string connectionString)
            : base(connectionString)
        {
        }

        public DbSet<User> Users { get; set; }
        //to do
        public DbSet<Category> Categories { get; set; }

        // Configure the User entity
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasKey(e => e.Id)
                .Property(e => e.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<User>()
                .Property(e => e.UserName)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(e => e.PasswordHash)
                .IsRequired();
        }
    }
}