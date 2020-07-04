using System;
using Xunit;
using ApparelApp.Domain;
using System.Collections.Generic;
using SportsApparelApp;

namespace UnitTests_SportsApparel
{
    public class UnitTest1
    {
        
        
        [Fact]
        public void TestNumberProductsInStore()
        {
            string[] products = { "soccer ball", "basketball", "tennis ball", "rackets", "Ultra boost shoes" };
            Store store = new Store("New York");

            foreach(var product in products)
            {
                store.StoreProducts.Add(new SportsApparelApp.Product(product));
            }


            Assert.Equal(expected: 5, store.StoreProducts.Count);
    

        }

        [Fact]
        public void testDecreaseProductsInStock()
        {
            string[] products = { "soccer ball", "basketball", "tennis ball", "rackets", "Ultra boost shoes" };
            Store store = new Store("New York");

            foreach (var product in products)
            {
                store.StoreProducts.Add(new SportsApparelApp.Product(product));
            }

            int numberOfProductsRemaining = store.decreaseStock(4);

            Assert.Equal(1, numberOfProductsRemaining);
        }

        [Theory]
        [InlineData("rackets")]
        [InlineData("soccer ball")]
        [InlineData("basketball")]
        public void testAddProductInOrder(string value)
        {
            string[] products = { "soccer ball", "basketball", "tennis ball", "rackets", "Ultra boost shoes" };
            Store store = new Store("New York");

            foreach (var product in products)
            {
                store.StoreProducts.Add(new SportsApparelApp.Product(product));
            }

            //Instantiating customer object
            Customer customer = new Customer("Alfred", "Rwagaju");

            //Instantiating order object
            Order order = new Order(customer, store.Name);

            //adding products in the order, selected from the store
            bool addProd1 = order.addProduct(new SportsApparelApp.Product(value));
            

            Assert.True(addProd1);

           
        }

        [Fact]
        public void testRemoveProductInOrder()
        {

            string[] products = { "soccer ball", "basketball", "tennis ball", "rackets", "Ultra boost shoes" };
            Store store = new Store("New York");

            foreach (var product in products)
            {
                store.StoreProducts.Add(new SportsApparelApp.Product(product));
            }

            //Instantiating customer object
            Customer customer = new Customer("Alfred", "Rwagaju");

            //Instantiating order object
            Order order = new Order(customer, store.Name);

            //adding products in the order
            order.OrderProducts.Add(new SportsApparelApp.Product("rackets"));
            order.OrderProducts.Add(new SportsApparelApp.Product("soccer ball"));



            bool removeProd = order.removeProduct(order.OrderProducts[1]);
            //Assert.True(removeProd);

            //product not in the order
            Product product1 = new Product("Nike running shoes");
            bool removeProd2 = order.removeProduct(product1);

            Assert.False(removeProd2);



        }


    }
}
