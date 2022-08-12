using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using MVC_Demo1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Demo1.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult GetAllEmployees()
        {
            var employees= new List<Employee>()
            {
                new Employee{ Id=1,Name="Bill",Department="IT"},
                  new Employee{ Id=2,Name="Gill",Department="IT"},
                    new Employee{ Id=3,Name="Jill",Department="IT"},
            };
            return View(employees);
        }
        
        public ActionResult LogIn(Login User)
        {

            if (User.Username == "Admin" && User.Password == "admin")
            {
                TempData["login"] = User.Username;

                return RedirectToAction(nameof(Welcome));
            }

            else

                return View();

        }

        public ActionResult Welcome()
        {
            return View();
        }



        public IActionResult  Index()
        {
            ViewData["emp"] = new Employee()
            {
                Id = 1,
                Name = "Bill",
                Department = "IT"
            };

            return View();
        }

        public IActionResult EmployeeDetails()
        {
            ViewBag.emp = new Employee()
            {
                Id = 1,
                Name = "Bill",
                Department = "IT"
            };

            return View();
        }

        public IActionResult ModelDemo()
        {
            Employee emp = new Employee()
            {
                Id = 1,
                Name = "Bill",
                Department = "IT"
            };
            return View(emp);
        }



        public IActionResult Create()
        {
            List<SelectListItem> departments = new List<SelectListItem>()
            {new SelectListItem { Text = "Accounts", Value = "Accounts" },
            new SelectListItem{ Text="Sales",Value="Sales"},
             new SelectListItem{Text="IT",Value="IT"},
            };
            ViewBag.dept = departments;


            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee model)
        {
            string message = "";
            if (ModelState.IsValid)
            {
                message = "Id :" + model.Id + " Name :" + model.Name + " Department :" + model.Department;
            }
            else
                message = " Failed to create Employee Try Again !";
            return Content(message);
        }




    }
}
