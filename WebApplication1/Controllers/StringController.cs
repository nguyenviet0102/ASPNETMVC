using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Process;

namespace WebApplication1.Controllers
{
    public class StringController : Controller
    {

        //Khai bao object trong class StringProcess
        StringProcess strPro = new StringProcess();
        public IActionResult XuLyChuoi()
        {
            return View();
        }
        [HttpPost]
        public IActionResult XuLyChuoi(string strInput)
        {
            ViewBag.Thongtin = strPro.RemoveRemainingSpace(strInput);

            ViewBag.Message = strPro.LowerToUpperString(strInput);
            return View();
        }
    }
}
