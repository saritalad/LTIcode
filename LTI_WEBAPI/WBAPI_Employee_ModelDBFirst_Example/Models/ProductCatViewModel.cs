using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WBAPI_Employee_ModelDBFirst_Example.Models
{
    public class ProductCatViewModel
    {   [Key]
        public int Productid { get; set; }
        public int Catid { get; set; }
        public string catName { get; set; }
        
        public string productname { get; set; }
        public decimal price { get; set; }

    }
}
