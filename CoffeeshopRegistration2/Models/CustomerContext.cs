using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeshopRegistration2.Models
{
    public class CustomerContext : DbContext
    {
        public DbSet<Customers> Customer { get; set; }        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                 @"Server=.\SQLEXPRESS;Database=coffeeshopregistration2;Integrated Security=SSPI;");
        }
    }
}
