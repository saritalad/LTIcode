using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WBAPI_Employee_ModelDBFirst_Example.Models
{
    public class Category
    {
        [Key]
        public int catid { get; set; }
        public string Catname { get; set; }
    }
}
