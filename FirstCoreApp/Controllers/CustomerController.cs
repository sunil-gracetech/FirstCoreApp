using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FirstCoreApp.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            string message = "i am dynamic message";
            ViewBag.msg = message;
            ViewData["msg"] = message;

            List<string> courses = new List<string>()
            {
                "php",
                "MVC",
                "Python",
                "C sharp",
                "SQL"
            };

            ViewBag.courses = courses;




            return View();
        }
    }
}