using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Auto_Bok_Test.Models
{
    public class Auto_Bok_TestContext : DbContext
    {
        public Auto_Bok_TestContext (DbContextOptions<Auto_Bok_TestContext> options)
            : base(options)
        {
        }

        public DbSet<Auto_Bok_Test.Models.Employee> Employee { get; set; }
    }
}
