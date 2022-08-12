using Microsoft.AspNetCore.Mvc;
using Model_In_ASPNETCoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model_In_ASPNETCoreMVC.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            List<Book> booklist = new List<Book>()
            {
                new Book(){ BookId = 1, BookName = "Unleashed asp.net", Author = "Murach", Price = 350 },
             new Book()    { BookId = 2, BookName = "Unleashed asp.net", Author = "Murach", Price = 350 },
            new Book()    { BookId = 3, BookName = "Unleashed asp.net", Author = "Murach", Price = 456 },
            new Book()    { BookId = 4, BookName = "Unleashed asp.net", Author = "Murach", Price = 350 },
            };
            return View(booklist);
        }

        public ActionResult GetBookDetails()
        {
            Book Dotnet = new Book() { BookId = 1, BookName = "Unleashed asp.net", Author = "Murach", Price = 350 };
            return View(Dotnet);

       }

        public ActionResult Edit(int id)
        {
            return View();
        }

      
        public ActionResult Delete(int id)
        {

            return View();
        }




    }
}
