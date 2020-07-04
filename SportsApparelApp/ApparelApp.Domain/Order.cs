using SportsApparelApp;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ApparelApp.Domain
{
    public class Order
    {
        public Customer Customer { get; set; }

        public string Datetime { get; }

        public String Location { get; }

        public List<Product> OrderProducts { get; set; }

        public Order(Customer customer, string location)
        {
            this.Customer = customer;
            this.Location = location;
            this.Datetime = DateTime.Now.ToString();
            this.OrderProducts = new List<Product>();

        }

        //adding a product in the orderedProducts list
        public bool addProduct(Product product)
        {
            OrderProducts.Add(product);
            Console.WriteLine($"{product.Name} was sucessfully added in the cart");
            return true;
        }

        //removing a product from the orderProducts

        public bool removeProduct(Product selectedProduct)
        {
            for(int i = 0; i < OrderProducts.Count; i++)
            {
                if(selectedProduct.Equals(OrderProducts[i]))
                {
                    Console.WriteLine($"{selectedProduct.Name} is in your order list");
                    return OrderProducts.Remove(selectedProduct);

                }
                
                
            }
            Console.WriteLine("Product is not in the list");
            return false;
          
           
        }


    }
}
