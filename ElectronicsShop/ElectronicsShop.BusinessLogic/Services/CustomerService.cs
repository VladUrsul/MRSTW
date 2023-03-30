using ElectronicsShop.BusinessLogic.Interfaces;
using ElectronicsShop.BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicsShop.BusinessLogic.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly DbContext _dbContext;

        public CustomerService(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Customer> GetCustomerByIdAsync(int id)
        {
            return await _dbContext.Set<Customer>().FindAsync(id);
        }

        public async Task<IEnumerable<Customer>> GetAllCustomersAsync()
        {
            return await _dbContext.Set<Customer>().ToListAsync();
        }

        public async Task AddCustomerAsync(Customer customer)
        {
            //await _dbContext.Set<Customer>().AddAsync(customer);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateCustomerAsync(Customer customer)
        {
            _dbContext.Entry(customer).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
    }
}