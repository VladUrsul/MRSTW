using ElectronicsShop.BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicsShop.BusinessLogic.Interfaces
{
    public interface IOrderService
    {
        Task<Order> GetOrderByIdAsync(int id);
        Task<IEnumerable<Order>> GetAllOrdersAsync();
        Task PlaceOrderAsync(Order order);
        Task CancelOrderAsync(Order order);
    }

}
