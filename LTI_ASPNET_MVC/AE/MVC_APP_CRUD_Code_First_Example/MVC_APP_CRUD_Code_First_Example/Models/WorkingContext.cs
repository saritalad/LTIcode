using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_APP_CRUD_Code_First_Example.Models
{
    public class WorkingContext:DbContext
    {
        public WorkingContext(DbContextOptions<WorkingContext>options):base(options)
        {

        }

        public DbSet<User> Users { get; set; }

    }
}
