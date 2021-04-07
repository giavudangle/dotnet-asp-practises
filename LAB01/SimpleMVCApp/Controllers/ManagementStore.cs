using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SimpleMVCApp.Controllers
{
    public class ManagementStore : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddMobile(){
            return View("ManagementAddMobile");
        }

        public IActionResult GetListMobile(){
            return View("ManagementList");
        }
        public IActionResult EditMobile(){
            return View("ManagementEditMobile");
        }
    }
}
