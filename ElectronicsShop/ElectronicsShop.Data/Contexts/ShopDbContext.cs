using ElectronicsShop.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;

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
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}