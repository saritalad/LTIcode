using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Consume_ProductAPI
{
    public class Product
    {

        public int productId { get; set; }
        public string ProductName { get; set; }
        public decimal price { get; set; }
        public int catid { get; set; }
    }
}
