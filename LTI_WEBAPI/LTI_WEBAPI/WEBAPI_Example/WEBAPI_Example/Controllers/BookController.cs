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
    public class BookController : ControllerBase
    {
        public List<Book> books = new List<Book>()
        {
            new Book{ BookId=101,Bookname="Agnipankh",Price=150,Author="AP J"},
             new Book{ BookId=102,Bookname="Idea",Price=160,Author="Kiran Bedi"}


        };

        public IEnumerable<Book> Get()
        {
            return books;

        }


    }
}
