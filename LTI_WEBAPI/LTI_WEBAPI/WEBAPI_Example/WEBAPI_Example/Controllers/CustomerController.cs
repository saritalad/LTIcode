using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAPI_Example.Models;

namespace WEBAPI_Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public List<Customer> customers = new List<Customer>()
        {
            new Customer{Id=1,Name="Bill"},
            new Customer{Id=2,Name="Mill"},
            new Customer {Id=3,Name ="Gill"},
            new Customer{Id=4,Name="Jill"},
            new Customer {Id=5,Name="Till"}
        };

        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return customers;
        }
     

    }
}
