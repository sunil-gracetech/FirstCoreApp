using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstCoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstCoreApp.Controllers
{
    public class CustomerController : Controller
    {
        // private CustomerService customer;

        ICustomer customer;
        public CustomerController( ICustomer _customer)
        {
            customer = _customer;

          //  customer = new CustomerService();
        }

        public IActionResult Index()
        {
            /*
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
            */

            //var cc = customer.GetCustomers();
              var cc = customer.GetModel();
              ViewBag.msg=customer.Message();
            return View(cc);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer cust)
        {
            customer.AddCustomer(cust);
            return View();
        }

    }
}