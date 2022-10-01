using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;


namespace DemoMVC.Controllers
{
    public class EmplpoyeeController : Controller
    {

        public IActionResult Index()
        {
            List<Employee> eplList = new List<Employee>(){
            new Employee {EmployeeID = 1,EmployeeName = "Nguyen Van A", Age =18},
            new Employee {EmployeeID = 2,EmployeeName = "Nguyen Van B", Age =19},
            new Employee {EmployeeID = 3,EmployeeName = "Nguyen Van C", Age =20},
            new Employee {EmployeeID = 4,EmployeeName = "Nguyen Van D", Age =21},
            new Employee {EmployeeID = 5,EmployeeName = "Nguyen Van E", Age =22}


           };
            ViewData["Employee"] = eplList;
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee epl)
        {
            string message = epl.EmployeeID + "_";
            message += epl.EmployeeName + "_";
            message += epl.Age;
            ViewBag.TT = message;
            return View();
        }
    }
}
