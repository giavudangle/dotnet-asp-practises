using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LAB02.Models;

namespace LAB02.Controllers
{
    public class EmployeeController : Controller
    {
     
        public IActionResult Index()
        {
            //ViewData is a dictionary of objects that is derived from ViewDataDictionary class 
            //and accessible using strings as keys. 
            //ViewBag is a dynamic property that takes advantage of the new dynamic features in C# 4.0. 
            //ViewData requires typecasting for complex data type and check for null values to avoid error. 
            //doesn’t require typecasting for complex data type

            Employee e = new Employee()
            {
                FirstName = "GiaVu",
                LastName = "DangLe",
                Salary = 20000
            };
            ViewBag.Employee = e;
            return View();
        }


        public IActionResult StronglyTyped()
        {
            Employee e = new Employee()
            {
                FirstName = "GiaVu",
                LastName = "DangLe",
                Salary = 20000
            };
            return View("Strongly", e);
        }
    }
}
