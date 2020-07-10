using ApparelApp.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApparelApp.Entities.Interfaces
{
    public interface IProductRepo
    {
        IEnumerable<Product> GetAll();
        Product GetById(int ID);
        void Insert(Product product);
        void Update(Product product);
        void Delete(int ID);
        void Save();
    }
}
