using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SimpleMVCApp.Models;

namespace SimpleMVCApp.Controllers
{
    public class ContactController : Controller
    {

  
        public IActionResult Index()
        {
            return View(new ContactViewModel());
        }

      
       [HttpPost]
        public IActionResult Index(ContactViewModel model)
        {
            return View("ShowData", model);
        }
       
      
       

    }
}
