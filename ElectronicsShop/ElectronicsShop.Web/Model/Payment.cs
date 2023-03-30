using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicsShop.Web.Model
{
    public class Payment
    {
        public decimal Amount { get; set; }
        public string Status { get; set; }
        public string Method { get; set; }
        public DateTime Date { get; set; }

        public void MakePayment()
        {
            // Code to process the payment using a payment gateway or other payment processing service
        }

        public void RefundPayment()
        {
            // Code to initiate a refund for the payment using a payment gateway or other payment processing service
        }
    }
}
