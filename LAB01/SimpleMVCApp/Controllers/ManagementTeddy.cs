using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SimpleMVCApp.Controllers
{
    public class ManagementTeddy : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddTeddy(){
            return View("ManagementAddTeddy");
        }

        public IActionResult GetListTeddy(){
            return View("ManagementListTeddy");
        }
        public IActionResult EditTeddy(){
            return View("ManagementEditTeddy");
        }
    }
}
