using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MYWebAPI_LogIn_Batch1046.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MYWebAPI_LogIn_Batch1046.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public UserController(AppDbContext context)
        {
            _context = context;
        }

        public AppDbContext _context { get; }

        public ActionResult get()
        {
            var data = _context.users.ToList();
            return Ok(data);
        }

             [HttpPost("Authenticate")]
          
        public ActionResult <User>Authenticate([FromBody]User loginuser)
        {
            var data = _context.users.FirstOrDefault(u =>( u.Email == loginuser.Email && u.Password == loginuser.Password));
            if (data == null)
            { return NotFound("no match"); }
           
            return Ok(data);
        }


    }
}
