using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SimpleMVCApp.Controllers
{
    public class TeddyStoreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListProducts(){
            return View("TeddyList");
        }

    }
}
