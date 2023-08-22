using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WBAPI_Employee_ModelDBFirst_Example.Models
{
    public class Product
    {   [Key]
        public int ProductId { get; set; }
        public string Productname { get; set; }
        public decimal Price { get; set; }
        public int catid { get; set; }
      
    }
}
