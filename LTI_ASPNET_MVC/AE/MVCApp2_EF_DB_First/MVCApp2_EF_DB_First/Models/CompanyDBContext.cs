using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApp2_EF_DB_First.Models
{
    public class CompanyDBContext:DbContext
    {
        public CompanyDBContext(DbContextOptions<CompanyDBContext> options):base(options)
        {
                
        }

        public DbSet<Employee>employees { get; set; }

    }
}
