using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SimpleMVCApp.Controllers
{
    public class ManagementBook : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddBook(){
            return View("ManagementAddBook");
        }

        public IActionResult GetListBook(){
            return View("ManagementListBook");
        }
        public IActionResult EditBook(){
            return View("ManagementEditBook");
        }
    }
}
