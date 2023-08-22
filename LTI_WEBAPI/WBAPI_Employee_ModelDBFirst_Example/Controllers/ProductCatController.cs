using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WBAPI_Employee_ModelDBFirst_Example.Models;
using Microsoft.EntityFrameworkCore;
namespace WBAPI_Employee_ModelDBFirst_Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCatController : ControllerBase
    {
        public ProductCatController(AppDbContext context)
        {
            _context = context;
        }

        public AppDbContext _context { get; }

        [HttpGet]
        public ActionResult<IEnumerable<ProductCatViewModel>>Get()
        {
            var data = _context.ProductsCatwise.FromSqlInterpolated($"dbo.SP_Products_Category ");
            return Ok(data);
        }


        [HttpGet]
        [Route("GetDetails/{id:int}")]
        public ActionResult<IEnumerable<ProductCatViewModel>> Getdetails(int id)
        {
            var data = _context.ProductsCatwise.FromSqlInterpolated($"dbo.ProductsByCatId {id}");
            return Ok(data);
        }
        [HttpGet]
        [Route("GetDetailsByName/{catname:alpha}")]
        public ActionResult<IEnumerable<ProductCatViewModel>> GetdetailsByName(string catname)
        {
            var data = _context.ProductsCatwise.FromSqlInterpolated($"dbo.ProductsByCatname {catname}");
            return Ok(data);
        }
    }
}
