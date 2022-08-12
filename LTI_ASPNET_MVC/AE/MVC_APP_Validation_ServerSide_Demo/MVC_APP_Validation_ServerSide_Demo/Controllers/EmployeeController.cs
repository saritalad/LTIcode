using Microsoft.AspNetCore.Mvc;
using MVC_APP_Validation_ServerSide_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_APP_Validation_ServerSide_Demo.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
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
            ViewBag.msg = emp.Id+emp.Dob.ToString();


            return View();
        }

    }
}
