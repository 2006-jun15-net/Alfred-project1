using ApparelApp.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApparelApp.Entities.Interfaces
{
    public interface IStoreRepo
    {
        IEnumerable<Store> GetAll();
        Store GetById(int ID);
     
        void Update(Store store);
       
        void Save();
    }
}
