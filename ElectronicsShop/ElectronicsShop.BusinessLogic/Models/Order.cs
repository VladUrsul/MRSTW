using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicsShop.BusinessLogic.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerName { get; set; }
        public string ShippingAddress { get; set; }
        public decimal TotalAmount { get; set; }
        // Add any additional properties here
    }

}
