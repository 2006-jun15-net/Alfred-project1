using ApparelApp.Entities.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsApparelWebApp.Repositories
{
    public class StoreRepo
    {
        private SportsApparelContext contextStores;

        public StoreRepo()
        {
            contextStores = new SportsApparelContext();

        }

        public IEnumerable<SelectListItem> GetAllStores()
        {
            IEnumerable<SelectListItem> objSelectItems = new List<SelectListItem>();
            objSelectItems = (from obj in contextStores.Store
                              select new SelectListItem()
                              {
                                  Text = obj.Location,
                                  Value = obj.StoreId.ToString(),
                                  Selected = true

                              }).ToList();
            return objSelectItems;
        }
    }
}
