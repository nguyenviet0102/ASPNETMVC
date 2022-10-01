using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class StudentController : Controller
    {
        Student std = new Student();

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create()
        {
            string message = std.StudentID + "_";
            message += std.StudentName + "_";
            message += std.Age;
            ViewBag.TT = message;
            return View();
        }

    }
}
