using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp1.EmpServices;
using WebApp1.Models;
namespace WebApp1.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            
            List<Employee>employees= EmpService.GetAll();

            return View(employees);
        }
    }
}
