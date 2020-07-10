using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApparelApp.Entities.Interfaces;
using ApparelApp.Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using SportsApparelWebApp.Repositories;
using Microsoft.EntityFrameworkCore;

namespace SportsApparelWebApp.Controllers
{
    public class CustomerController : Controller
    {
        public ICustomerRepo _customerRepo { get; }

        public CustomerController()
        {
            _customerRepo = new CustomerRepo();
        }

        //public CustomerController(ICustomerRepo repo) =>
        //_customerRepo = repo ?? throw new ArgumentNullException(nameof(repo));


        [HttpGet]
        public async Task<IActionResult> Index(string SearchString)
        {
            SportsApparelContext sportsApparelContext = new SportsApparelContext();

            var customers = from m in sportsApparelContext.Customer
                            select m;
            if (!String.IsNullOrEmpty(SearchString))
            {
                customers = customers.Where(s => s.FirstName.Contains(SearchString) || s.LastName.Contains(SearchString));
            }

            return View(await customers.ToListAsync());
            
        }

       /* public IActionResult Index()
        {
            var model = _customerRepo.GetAll();
            return View(model);
        }*/

        [HttpGet]
        public ActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCustomer(Customer customer)
        {
            if(ModelState.IsValid)
            {
                _customerRepo.Insert(customer);
                _customerRepo.Save();
                return RedirectToAction("Index", "Customer");
            }
            return View();
        }

        [HttpGet]
        public ActionResult EditCustomer(int ID)
        {
            Customer model = _customerRepo.GetById(ID);
            return View(model);
        }

        public ActionResult EditCustomer(Customer model)
        {
            if (ModelState.IsValid)
            {
                _customerRepo.Update(model);
                _customerRepo.Save();
                return RedirectToAction("Index", "Customer");
            }
            else
            {
                return View(model);
            }
        }

        [HttpGet]
        public ActionResult DeleteCustomer(int ID)
        {
            Customer model = _customerRepo.GetById(ID);
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(int ID)
        {
            _customerRepo.Delete(ID);
            _customerRepo.Save();
            return RedirectToAction("Index", "Customer");
        }









    }
}
