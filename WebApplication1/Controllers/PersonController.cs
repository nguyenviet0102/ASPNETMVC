using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            List<Person> perList = new List<Person>(){
            new Person {PersonID = 1,PersonName = "Nguyen Van A", Age =18},
            new Person {PersonID = 2,PersonName = "Nguyen Van B", Age =19},
            new Person {PersonID = 3,PersonName = "Nguyen Van C", Age =20},
            new Person {PersonID = 4,PersonName = "Nguyen Van D", Age =21},
            new Person {PersonID = 5,PersonName = "Nguyen Van E", Age =22},

           };
            ViewData["Person"] = perList;

            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Person per)
        {
            //string message = per.PersonID + "_";
            //message += per.PersonName + "_";
            // message += per.Age;
            // ViewBag.TT = message;
            return View();
        }
    }
}
