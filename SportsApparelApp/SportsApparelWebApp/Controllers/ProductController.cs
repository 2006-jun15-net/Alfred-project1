using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApparelApp.Entities.Entities;
using ApparelApp.Entities.Interfaces;
using Microsoft.AspNetCore.Mvc;
using SportsApparelWebApp.Repositories;

namespace SportsApparelWebApp.Controllers
{
    public class ProductController : Controller
    {
        public IProductRepo _productRepo { get; }

        public ProductController()
        {
            _productRepo = new ProductRepo();
        }
        public IActionResult Index()
        {
            var model = _productRepo.GetAll();

            return View(model);
        }

        [HttpGet]
        public ActionResult DeleteProduct(int ID)
        {
            Product model = _productRepo.GetById(ID);
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(int ID)
        {
            _productRepo.Delete(ID);
            _productRepo.Save();
            return RedirectToAction("Index", "Product");
        }
    }
}
