using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCApp1.EmpServices;
using MVCApp1.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
//https://www.c-sharpcorner.com/article/different-ways-bind-the-value-to-razor-dropdownlist-in-aspnet-mvc5/
namespace MVCApp1.Controllers
{    [Route("Myhome")]
    public class EmployeesController : Controller
    {


      
     [Route("Index")]
        public IActionResult Index()
        {
            
            List<Employee>employees= EmpService.GetAll();

            return View(employees);
        }
     
      

        [HttpGet]
        //[Route("Login")]
        public ActionResult Login()
        {


            return View();
        }


        [HttpPost]

        public ActionResult LogIn(Login user)
        {

            if (user.Username == "Admin" && user.Password == "admin")
            {
                TempData["login"] = user.Username;
                return RedirectToAction(nameof(Welcome));
            }
            else
            {
               
                return View();
            }
           
        }
        public ActionResult Welcome()
        {
            return View();
        }

        public ActionResult Products()
        {
            Product p1 = new Product()

            {Id=1,ProductName ="Galaxy M33 ",Price=25000, Type="mobile"  }
                ;
               return View(p1);
        }

        [HttpGet]
      
        public ActionResult Create()
        {
            List<SelectListItem> departments = new List<SelectListItem>()
                 {new SelectListItem { Text = "Accounts", Value = "Accounts" },
            new SelectListItem{ Text="Sales",Value="Sales"},
             new SelectListItem{Text="IT",Value="IT"},
            };
            ViewBag.dept = departments;


            return View( );
        }

        [HttpPost]
        public IActionResult Create(Employee newemp)
        {
            string message = "";
            EmpService.Add(newemp);


            message = "Id :" + newemp.Id + " Name :" + newemp.Name + " Department :" + newemp.Department;
            ViewBag.msg = message;
            return View();
        }
        [HttpGet]
        [Route("Edit")]
        public ActionResult Edit(int id)
        {
            return View(EmpService.Getemp(id));
        }

        [HttpPost]
        public IActionResult Edit(int id,Employee modifiedemp)
        {
            modifiedemp.Id = id;
            EmpService.Update(modifiedemp);
            return RedirectToAction(nameof(Index));
        }
        [Route("Details/{id?}")]
        public ActionResult Details(int id)
        {

            return View(EmpService.Getemp(id));
        }
        [Route("Delete")]
        public IActionResult Delete(int id)
        {
            try
            {
                EmpService.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
