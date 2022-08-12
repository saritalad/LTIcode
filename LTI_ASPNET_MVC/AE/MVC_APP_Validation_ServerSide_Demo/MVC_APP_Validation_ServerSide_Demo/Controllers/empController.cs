using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVC_APP_Validation_ServerSide_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class empController : ControllerBase
    {
        // GET: api/<empController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<empController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<empController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<empController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<empController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
