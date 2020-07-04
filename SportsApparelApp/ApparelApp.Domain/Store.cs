using SportsApparelApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApparelApp.Domain
{
    public class Store
    {
        // A store has products and the quantity of those products
        // decrease the stock by the quantity of products order by the customer

        public string Name { get; }

        public int Stock { get; set; }
       




        public List<Product> StoreProducts { get; set; }


        public Store(string name)
        {
            this.Name = name;
            this.StoreProducts = new List<Product>();
            

        }

        //decrease the stock when a customer places an order
        public int decreaseStock(int cartAmount)
        {
            int newStock = 0; //storing the newStock quantity
            //validating the number of products in the cart 
            if(cartAmount > StoreProducts.Count)
            {
                Console.WriteLine("The number of products in your cart not exceed the stock");
            }
            else
            {
                newStock = StoreProducts.Count - cartAmount;
            }
            return newStock; 
        }
    }
}
