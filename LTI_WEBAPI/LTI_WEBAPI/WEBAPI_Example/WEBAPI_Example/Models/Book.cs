using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAPI_Example.Models
{
    public class Book
    { 


        public int BookId { get; set; }
       public string  Bookname { get; set; }
        public decimal Price { get; set; }
        public string Author { get; set; }
    }
}
