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
        void Insert(Orders orders);
        void Update(Orders orders);
        void Delete(int ID);
        void Save();

    }
}
