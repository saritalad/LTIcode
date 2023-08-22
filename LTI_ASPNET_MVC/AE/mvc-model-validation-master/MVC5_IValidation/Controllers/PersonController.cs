using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MVC5_IValidation.Models;

namespace MVC5_IValidation.Controllers
{
    public class PersonController : Controller
    {


        // GET: Person
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View(new Person());
        }


        [HttpPost]
        public ActionResult Create(Person p)
        {
            return View(p);
        }
    }
}