using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectronicsShop.BusinessLogic.Models;

namespace ElectronicsShop.BusinessLogic.Data
{
    public class ShopDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Order
    {
        public int Id { get; set; }
        public string Address { get; set; }
    }

    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
    }
    public class MyBusinessLogicClass
    {
        private readonly ShopDbContext _dbContext;

        public MyBusinessLogicClass(ShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Customer customer)
        {
            _dbContext.Customers.Add(customer);
            await _dbContext.SaveChangesAsync();
        }
    }

}
