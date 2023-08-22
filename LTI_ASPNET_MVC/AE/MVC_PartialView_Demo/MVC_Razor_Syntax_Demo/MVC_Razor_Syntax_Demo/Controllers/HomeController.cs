using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_Razor_Syntax_Demo.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Razor_Syntax_Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Index1()
        {

            return View();
        }

        public ActionResult Index2()
        {

            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

      
    }
}
