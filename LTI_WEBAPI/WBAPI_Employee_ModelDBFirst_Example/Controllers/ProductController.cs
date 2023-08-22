using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WBAPI_Employee_ModelDBFirst_Example.Models;

namespace WBAPI_Employee_ModelDBFirst_Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        public AppDbContext _context { get; }

        public IEnumerable<Product> Get()
        {
            return _context.Products.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {

            var data = _context.Products.FirstOrDefault(p => p.ProductId == id);
            if (data == null)
                return NotFound();
            else
                return Ok(data);
        }

        [HttpPost]
        public ActionResult Post(Product newProduct)
        {

            _context.Products.Add(newProduct);
            _context.SaveChanges();
        
              return CreatedAtAction("Get", new { id = newProduct.ProductId }, newProduct);

        }
       



    }
}
