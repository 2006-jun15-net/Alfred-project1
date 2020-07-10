using ApparelApp.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApparelApp.Entities.Interfaces
{
    public interface IOrderDetailsRepo
    {
        IEnumerable<OrderDetails> GetAll();
        OrderDetails GetById(int ID);
        void Insert(OrderDetails orderDetails);
        void Update(OrderDetails orderDetails);
        void Delete(int ID);
        void Save();
    }
}
