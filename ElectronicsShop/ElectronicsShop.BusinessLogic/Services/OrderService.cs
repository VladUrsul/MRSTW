using ElectronicsShop.BusinessLogic.Interfaces;
using ElectronicsShop.BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicsShop.BusinessLogic.Services
{
    namespace ElectronicsShop.BusinessLogic.Services
    {
        public interface IOrderService
        {
            Task<List<Order>> GetAllOrdersAsync();
            Task<Order> GetOrderByIdAsync(int orderId);
            Task<int> AddOrderAsync(Order order);
            Task<int> UpdateOrderAsync(Order order);
            Task<int> DeleteOrderAsync(Order order);
        }

        public class OrderService : IOrderService
        {
            private readonly DbContext _dbContext;

            public OrderService(DbContext dbContext)
            {
                _dbContext = dbContext;
            }

            public async Task<List<Order>> GetAllOrdersAsync()
            {
                return await _dbContext.Set<Order>().ToListAsync();
            }

            public async Task<Order> GetOrderByIdAsync(int orderId)
            {
                return await _dbContext.Set<Order>().FindAsync(orderId);
            }

            public async Task<int> AddOrderAsync(Order order)
            {
                _dbContext.Set<Order>().Add(order);
                return await _dbContext.SaveChangesAsync();
            }

            public async Task<int> UpdateOrderAsync(Order order)
            {
                _dbContext.Entry(order).State = EntityState.Modified;
                return await _dbContext.SaveChangesAsync();
            }

            public async Task<int> DeleteOrderAsync(Order order)
            {
                _dbContext.Set<Order>().Remove(order);
                return await _dbContext.SaveChangesAsync();
            }
        }
    }
}