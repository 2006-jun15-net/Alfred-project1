using System;
using ApparelApp.Domain;
namespace SportsApparelApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = { "soccer ball", "basketball", "tennis ball", "rackets", "Ultra boost shoes", "rackets" };
            Store store = new Store("New York");

            foreach (var product in products)
            {
                store.StoreProducts.Add(new SportsApparelApp.Product(product));
            }
            //Instantiating customer object
            Customer customer = new Customer("Alfred", "Rwagaju");

            //Instantiating order object
            Order order = new Order(customer, store.Name);

            Product prod1 = new Product("rackets");
            Product prod2 = new Product("soccer ball");
            Product prod3 = new Product("tennis");
            Product prod4 = new Product("adidas boots");


            //adding products in the order
            order.addProduct(prod1);
            order.addProduct(prod2);
            order.addProduct(prod3);
           Console.WriteLine(order.OrderProducts.Count);

            //removing products from the orderProduct
            order.removeProduct(prod2);
            Console.WriteLine(order.OrderProducts.Count);

            //displaying order details
            OrderDetails orderDetails = new OrderDetails(order);
            orderDetails.display();

            

        }
    }
}
