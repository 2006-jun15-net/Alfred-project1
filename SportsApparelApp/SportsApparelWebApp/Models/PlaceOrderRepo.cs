using ApparelApp.Domain;
using ApparelApp.Entities.Entities;
using ApparelApp.Entities.Interfaces;
using ApparelApp.Entities.Repositories;
using Microsoft.AspNetCore.Authentication.OAuth;
using SportsApparelWebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderDetails = ApparelApp.Entities.Entities.OrderDetails;

namespace SportsApparelWebApp.Models
{
    public class PlaceOrderRepo
    {
        

        private SportsApparelContext sportsApparelContext;

        public PlaceOrderRepo()
        {
            sportsApparelContext = new SportsApparelContext();
        }

        public bool addOrder(OrderViewModel objOrderViewModel)
        {
            Orders orders = new Orders();

            orders.CustId = objOrderViewModel.CustomerId;
            orders.FinalAmount = objOrderViewModel.FinalAmount;
            orders.Datecreated = DateTime.Now;

            sportsApparelContext.Add(orders);
            //sportsApparelContext.SaveChanges();

            int id = orders.OrderId; // accesing the id of the new created order
            foreach (var x in objOrderViewModel.orderDetailViewModels)
            {
                OrderDetails orderDetails = new OrderDetails(); //creating a new order detail
                orderDetails.OrderId = id;
                orderDetails.ProdId = x.ProdId;
                orderDetails.Qty = x.Qty;
                orderDetails.UnitPrice = x.UnitPrice;
                orderDetails.TotalCost = x.TotalCost;

                
                sportsApparelContext.OrderDetails.Add(orderDetails);
                sportsApparelContext.SaveChanges();


            }


            return true;


        }
    }
}
