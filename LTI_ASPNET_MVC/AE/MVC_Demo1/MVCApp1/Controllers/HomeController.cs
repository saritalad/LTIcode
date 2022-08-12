using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApp1.Controllers
{

    public class HomeController : Controller
    {
        // attribute route is configured here



        //[Route("")]
        //[Route("Home")]
        //[Route("home/index/{id?}")]
        public string Index(string id)
        {
            if (id != null)
            {
                return "Received " + id.ToString();
            }
            else
            {
                return "Received nothing";
            }
        }

        public ActionResult Welcome()
        {

            return View();
        }



    }
}