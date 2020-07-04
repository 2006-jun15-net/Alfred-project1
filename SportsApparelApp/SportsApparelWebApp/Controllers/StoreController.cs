using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SportsApparelWebApp.Controllers
{
    public class StoreController : Controller
    {
        public string Index()
        {
            return "Hello from Index";
        }

        public string Browse()
        {
            return "Hello from browse";
        }

        public string Details()
        {
            return "Hello from detials";
        }


    }
}
