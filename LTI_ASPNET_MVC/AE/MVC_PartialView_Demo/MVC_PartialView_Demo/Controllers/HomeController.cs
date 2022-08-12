using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_PartialView_Demo.Models;
using System;

using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_PartialView_Demo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
        public ActionResult Countries(List<String> countryData)
        {
            return View(countryData);
        }


    }
}
