using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestFulWbAPI_Product.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestFulWbAPI_Product.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("Getproducts")]
        public async Task<ActionResult<IEnumerable<Product>>> Getproducts()
        {
            return await _context.Products.ToListAsync();
        }




    }
}
