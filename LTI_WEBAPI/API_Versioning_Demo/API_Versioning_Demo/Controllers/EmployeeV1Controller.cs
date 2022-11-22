using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Versioning_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeV1Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return new OkObjectResult("employees from v1 controller");
        }
    }
}
