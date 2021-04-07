using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myApp.ViewModels
{
    public class EmployeeViewModel
    {
        public string EmployeeName { get; set; }
        public double Salary { get; set; }
        public string SalaryColor { get; set; }

        public EmployeeViewModel(string name,double salary) {
            EmployeeName = name;
            Salary = salary;
        }

  



    }
}