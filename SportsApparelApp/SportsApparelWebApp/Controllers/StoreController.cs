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
    public class StoreController : Controller
    {
        public IStoreRepo _storeRepo { get; }

        public StoreController()
        {
            _storeRepo = new StoreRepo();
        }
        public IActionResult Index()
        {
            var model = _storeRepo.GetAll();
            return View(model);
        }

        //details of the store
        public ActionResult Details(int id)
        {
            Store store = _storeRepo.GetById(id);
            return null;
        }



    }
}
