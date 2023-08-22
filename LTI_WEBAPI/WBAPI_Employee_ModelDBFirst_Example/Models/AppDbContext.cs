using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WBAPI_Employee_ModelDBFirst_Example.Models
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }

        public  DbSet <Employee> Employees { get; set; }
        public DbSet <Category> Categories { get; set; }// tablename in sql database
        public DbSet<Product> Products { get; set; }//tablename in sql database 

        public DbSet<ProductCatViewModel> ProductsCatwise { get; set; }// no table in sql database 
    }
}
