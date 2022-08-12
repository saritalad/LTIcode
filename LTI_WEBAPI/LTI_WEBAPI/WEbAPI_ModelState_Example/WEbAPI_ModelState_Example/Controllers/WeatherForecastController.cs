using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEbAPI_ModelState_Example.Controllers
{
    [ApiController]// to validate model 1 check for null value 2 check for the data type 
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
       

       

        [HttpGet]
        public ActionResult <string> Get(string id, int? isTest)
        {
            //var errors = new List<string>();

            //if(isTest==null)
            //{
            //    errors.Add("is Test is required ");

            //}

            //if (string.IsNullOrEmpty(id))
            //{ errors.Add("id is required"); }
            //if (errors.Count > 0)

            //{ return BadRequest(errors); }
           
            //else

            if(isTest==null)
            {
                ModelState.AddModelError(nameof(isTest), "istest is required number ");
            }
            if(string.IsNullOrEmpty(id))
            {
                ModelState.AddModelError(nameof(id), "id field is required ");
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            else

            return $"Id  :{id} Istest :{isTest}";

        }
    }
}
