using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SportsApparelWebApp.Repositories;

namespace SportsApparelWebApp.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            CustomerRepo customerRepo = new CustomerRepo();
            StoreRepo storeRepo = new StoreRepo();
            ProductRepo productRepo = new ProductRepo();

            var objModel = new Tuple<IEnumerable<SelectListItem>, IEnumerable<SelectListItem>, IEnumerable<SelectListItem>>
                (customerRepo.GetAllCustomers(), storeRepo.GetAllStores(), productRepo.GetAllProducts());


            return View(objModel);
        }
    }
}
