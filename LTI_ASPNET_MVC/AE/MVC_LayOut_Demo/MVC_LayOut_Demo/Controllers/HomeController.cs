using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_LayOut_Demo.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_LayOut_Demo.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {

        }



        public IActionResult Index()
        {

            return View();
        }
        public ActionResult Welcome()
        {
            Employee Emp = new Employee() { Id = 1, Name = "Nill", Department = "IT" };
            return View(Emp);
        }
        public ActionResult DarkLayoutPage()
        {
            return View();
        }
        public ActionResult SampleMyLayout()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            return View();

        }
          public ActionResult WelcomeHome()
        {

            return View();
        }
    }




}
