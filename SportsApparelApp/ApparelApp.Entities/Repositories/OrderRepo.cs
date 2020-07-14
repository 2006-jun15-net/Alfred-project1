using ApparelApp.Entities.Entities;
using ApparelApp.Entities.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApparelApp.Entities.Repositories
{
    public class OrderRepo: IOrderRepo
    {
        private readonly SportsApparelContext _contextStores;

        private readonly ILogger<OrderRepo> _logger;

        public OrderRepo()
        {
            _contextStores = new SportsApparelContext();
        }

        public OrderRepo(SportsApparelContext contextStores, ILogger<OrderRepo> logger)
        {
            _contextStores = contextStores ?? throw new ArgumentNullException(nameof(contextStores));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));


        }

        /// <summary>
        /// Adds the order to the database
        /// </summary>
        /// <param name="orders"></param>
        public void Add(Orders orders)
        {
            
            _contextStores.Orders.Add(orders);

           
            
        }

       

        /// <summary>
        /// Gets all orders
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Orders> GetAll()
        {
            return _contextStores.Orders.ToList();
        }

        /// <summary>
        /// Gets an order by its order id
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Orders GetById(int ID)
        {
            return _contextStores.Orders.Find(ID);

        }

        /// <summary>
        /// Saves the changes to the Order table
        /// </summary>
        public void Save()
        {
            _contextStores.SaveChanges();
            
        }


    }
}
