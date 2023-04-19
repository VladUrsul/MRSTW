using ElectronicsShop.Domain.Entities;
using System.Data.Entity;

namespace ElectronicsShop.Data.Contexts
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(string connectionString)
        {
            Database.Connection.ConnectionString = connectionString;
        }

        public DbSet<User> Users { get; set; }
    }
}
