using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_ViewModel_Demo.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Catname  { get; set; }

        public List<Product> products { get; set; }
    }
}
