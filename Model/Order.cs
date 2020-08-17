using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POC.Order.API
{
    public class Order
    {
        public int OrderId { get; set; }
        public decimal OrderTotal { get; set; }
        public DateTime OrderDate { get; set; }

        public Order(int id, decimal orderTotal, DateTime date)
        {
            this.OrderId = id;
            this.OrderTotal = orderTotal;
            this.OrderDate = date;
        }
    }
}
