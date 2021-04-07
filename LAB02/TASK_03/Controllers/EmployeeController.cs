
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using myApp.ViewModels;

namespace myApp.Controllers
{
  public class EmployeeController : Controller
  {
    public string Index()
    {
      return "Hello this is Employee controller";
    }

    public string Welcome()
    {
      return "Hi . I'm  employee controller welcome function ^^";
    }

    public ActionResult GetListEmployees()
    {
      EmployeeListViewModel viewModel = new EmployeeListViewModel();
      viewModel.employeeList = new List<EmployeeViewModel>(){
        new EmployeeViewModel("VuDang",180000),
        new EmployeeViewModel("Vudang Clone",12000),
        new EmployeeViewModel("Vudang  of Clone",200000),
      };

      foreach(EmployeeViewModel it in viewModel.employeeList){
        if(it.Salary > 15000) {
          it.SalaryColor = "blue";
        } else {
          it.SalaryColor ="green";
        }
      }
    
      return View("Employee",viewModel);
    }

  }
}
