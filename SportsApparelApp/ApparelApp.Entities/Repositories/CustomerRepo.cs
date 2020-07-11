using ApparelApp.Entities.Interfaces;
using ApparelApp.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Globalization;

namespace SportsApparelWebApp.Repositories
{
    public class CustomerRepo : ICustomerRepo
    {
        

        private readonly SportsApparelContext _contextStores;

        private readonly ILogger<CustomerRepo> _logger;

        public CustomerRepo()
        {
            _contextStores = new SportsApparelContext();
        }

        public CustomerRepo(SportsApparelContext contextStores, ILogger<CustomerRepo> logger)
        {
            _contextStores = contextStores ?? throw new ArgumentNullException(nameof(contextStores));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));


        }

        public void Delete(int ID)
        {
            Customer customer = _contextStores.Customer.Find(ID);
            _contextStores.Customer.Remove(customer);

        }

      

        public IEnumerable<Customer> GetAll()
        {
            return _contextStores.Customer.ToList();
           
        }

        public IEnumerable<SelectListItem> GetAllCustomers()
        {
            var selectList = new List<SelectListItem>();
            selectList = (from obj in _contextStores.Customer
                          select new SelectListItem()
                          {
                              Text = obj.LastName,
                              Value = obj.CustId.ToString(),
                              Selected = true
                          }).ToList();
            return selectList;
        }

        public Customer GetById(int ID)
        {
            return _contextStores.Customer.Find(ID);
        }

        public void Insert(Customer customer)
        {
            _contextStores.Customer.Add(customer);
        }

        public void Save()
        {
            _contextStores.SaveChanges();
        }

        public void Update(Customer customer)
        {
            _contextStores.Entry(customer).State = EntityState.Modified;
        }


        public IEnumerable<Customer> GetCustomers(string search)
        {
            IQueryable<Customer> customers = _contextStores.Customer;
            if(!String.IsNullOrEmpty(search))
            {
                customers = customers.Where(x => x.LastName.Contains(search));
            }
            return customers.ToList();
                
        }


    }
}
