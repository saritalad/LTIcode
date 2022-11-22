using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//https://www.c-sharpcorner.com/article/api-versioning-in-asp-net-core-web-api/
namespace API_Versioning_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeV2Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return new OkObjectResult("employees from v2 controller");
        }
    }
}
