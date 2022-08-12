using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Model_In_ASPNETCoreMVC.Models
{
    public class Book
    {
        public int BookId { get; set; }
        [Required(ErrorMessage = "Book name is required")]
        public string BookName { get; set; }
        
        [StringLength(5)]
        [DisplayName("Name of Book Auther")]
        public string Author { get; set; }
        [Range(100,2000)]
        public decimal Price { get; set; }
    }
}
