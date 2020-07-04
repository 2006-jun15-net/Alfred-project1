using System;
using System.Collections.Generic;
using System.Text;

namespace ApparelApp.Domain
{
    public class OrderDetails
    {
        public Order Order { get; private set; }

        public OrderDetails(Order order)
        {
            this.Order = order;
        }

        public void display()
        {
            Console.WriteLine($"{Order.Customer.FirstName} {Order.Customer.LastName}");
            Console.WriteLine($"The order was in {Order.Location}");
            Console.WriteLine($"The order has {Order.OrderProducts.Count} products");
            Console.WriteLine($"The order was placed on {Order.Datetime}");
        }
    }
}
