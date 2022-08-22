using Microsoft.AspNetCore.Mvc;
using MVC_ViewModel_Demo.Models;
using MVC_ViewModel_Demo.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_ViewModel_Demo.Controllers
{
    public class ProductController : Controller
    {    

        public ActionResult Details()
        {
            Category C = new Category()
            {
                Id = 1,
                Catname = "Soap",
                products = new List<Product>()
                { new Product (){Id=1,ProductName ="Dove",Price=25},
                new Product (){Id=2,ProductName ="Lyril",Price=35},
                new Product (){Id=3,ProductName ="Lux",Price=45},
                new Product (){Id=4,ProductName ="Rexona",Price=45}
                }

            };
            return View(C);
        }
        
    }
}
