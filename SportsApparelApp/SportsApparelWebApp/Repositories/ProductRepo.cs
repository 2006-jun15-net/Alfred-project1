using ApparelApp.Entities.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsApparelWebApp.Repositories
{
    public class ProductRepo
    {
        private SportsApparelContext contextStores;

        public ProductRepo()
        {
            contextStores = new SportsApparelContext();

        }

        public IEnumerable<SelectListItem> GetAllProducts()
        {
            IEnumerable<SelectListItem> objSelectItems = new List<SelectListItem>();
            objSelectItems = (from obj in contextStores.Product
                              select new SelectListItem()
                              {
                                  Text = obj.Name,
                                  Value = obj.ProdId.ToString(),
                                  Selected = true

                              }).ToList();
            return objSelectItems;
        }
    }
}
