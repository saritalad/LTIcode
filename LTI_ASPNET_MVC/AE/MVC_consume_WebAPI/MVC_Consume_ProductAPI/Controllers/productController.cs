using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
namespace MVC_Consume_ProductAPI.Controllers
{
    public class productController : Controller
    {
        // web api Project is RestfullWbAPI_Product
        public  ActionResult <IEnumerable<IActionResult>> Index()
        {
            string apiUrl = "http://localhost:3833/api/product/getproducts";
            List<Product> productList = new List<Product>();


            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.GetAsync(apiUrl).Result;
            if (response.IsSuccessStatusCode)
            {
                productList = JsonConvert.DeserializeObject<List<Product>>(response.Content.ReadAsStringAsync().Result);
            }


            return View(productList);
        }
    }
}
