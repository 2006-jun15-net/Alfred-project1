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
           

          
            //var  objModels = new Tuple<IEnumerable<SelectListItem>, IEnumerable<SelectListItem>, IEnumerable<SelectListItem>>
            return View();
        }
    }
}
