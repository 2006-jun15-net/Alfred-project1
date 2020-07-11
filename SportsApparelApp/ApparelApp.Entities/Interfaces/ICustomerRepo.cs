using ApparelApp.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApparelApp.Entities.Interfaces
{
    public interface ICustomerRepo
    {
        IEnumerable<Customer> GetAll();
        IEnumerable<Customer> GetCustomers(string search = null);
        Customer GetById(int ID);
        void Insert(Customer customer);
        void Update(Customer customer);
        void Delete(int ID);
        void Save();


    }
}
