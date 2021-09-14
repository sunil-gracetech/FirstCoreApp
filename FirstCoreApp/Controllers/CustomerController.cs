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
            //var cc = customer.GetModel();
            //ViewBag.msg=customer.Message();
            var cc = customer.GetCustomers();
            return View(cc);
        }

        public ActionResult Delete(int id)
        {
            bool result=customer.DeleteCustomer(id);
            if(result)
            {
                ViewBag.message = "customer deleted successfully !";
            }
            else
            {
                ViewBag.message = "customer not deleted successfully !";

            }
            return RedirectToAction("Index");
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer cust)
        {
            if (ModelState.IsValid)
            {
                if (customer.ValidateUser(cust.Mobile))
                {
                    ModelState.AddModelError("Mobile", "mobile number already registered !");
                    return View(cust);
                }
                else
                {
                    customer.AddCustomer(cust);
                    return RedirectToAction("Index");
                }
            }
            return View(cust);
        }

        public ActionResult Edit(int id)
        {
            var result = customer.GetCustomer(id);
            return View(result);
        }

        [HttpPost]
        public ActionResult Edit(Customer cc)
        {
            customer.UpdateCustomer(cc);
            return RedirectToAction("Index");
        }
    }
}