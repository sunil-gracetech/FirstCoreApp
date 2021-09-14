using FirstCoreApp.Utils;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreApp.Models
{
    public class ApplicationContext:DbContext
    {

        public ApplicationContext(DbContextOptions<ApplicationContext> options ) : base(options) { }
        public DbSet<Customer> Customers { get; set; }

        /*
        protected override void OnConfiguring(DbContextOptionsBuilder contextOptionsBuilder)
        {
            contextOptionsBuilder.UseSqlServer(DbConnectionConfig.dbconnection);
        }
        */
    }
}
