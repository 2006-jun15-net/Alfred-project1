using ApparelApp.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApparelApp.Entities.Interfaces
{
    public interface IOrderRepo
    {
        IEnumerable<Orders> GetAll();
        Orders GetById(int ID);
        void Add(Orders orders);
      
        void Save();

    }
}
