﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Routing_Example.Controllers
{
    [Route("Emp")]
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("My")]
        public ActionResult MyView()
        {

            return View();
        }

    }
}
