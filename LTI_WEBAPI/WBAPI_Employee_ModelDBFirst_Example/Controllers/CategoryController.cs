using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;
using WBAPI_Employee_ModelDBFirst_Example.Models;

namespace WBAPI_Employee_ModelDBFirst_Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        public CategoryController(AppDbContext context)
        {
            _context = context;
        }

        public AppDbContext _context { get; }

        public IEnumerable<Category> Get()
        {
            return _context.Categories.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {

            var data = _context.Categories.FirstOrDefault(c => c.catid == id);
            if (data == null)
                return NotFound();
            else
                return Ok(data);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Category newcategory)
        {

            _context.Categories.Add(newcategory);
            _context.SaveChanges();
            return Ok();
             // return CreatedAtAction("Get", new { id = newcategory.catid }, newcategory);

        }
        [HttpPut("{id}")]
        public ActionResult Put(int id ,[FromBody]Category modified)
        {
            var cat = _context.Categories.FirstOrDefault(c => c.catid == id);
            if(cat==null)
            {
                return NotFound();
            }
            else
            {
                cat.Catname = modified.Catname;
                _context.SaveChanges();
                return Ok();
            }
        }
    }
       
        

    }

