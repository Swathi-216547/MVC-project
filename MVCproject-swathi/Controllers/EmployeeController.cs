using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCproject_swathi.Models;


namespace MVCproject_swathi.Controllers
{
    public class EmployeeController : Controller
    {

        // GET:Employee
        public ActionResult Employeeinfo()
        {
            Employee employee = new Employee()
            {
                EmployeeId = 216547,
                EmployeeName = "Swathi",
                EmployeeLocation = "Bangalore"
            };
                
            
            return View (employee);
        }
    }
}