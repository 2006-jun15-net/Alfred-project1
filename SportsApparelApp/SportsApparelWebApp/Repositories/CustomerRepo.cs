using ApparelApp.Entities.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using SportsApparelWebApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsApparelWebApp.Repositories
{
    public class CustomerRepo
    {
        private SportsApparelContext contextStores;

        public CustomerRepo()
        {
            contextStores = new SportsApparelContext();
               
        }

        public IEnumerable<SelectListItem> GetAllCustomers()
        {
            IEnumerable<SelectListItem> objSelectItems = new List<SelectListItem>();
            objSelectItems = (from obj in contextStores.Customer
                              select new SelectListItem()
                              {
                                  Text = obj.LastName,
                                  Value = obj.CustId.ToString(),
                                  Selected = true

                              }).ToList();
            return objSelectItems;
        }


    }
}
