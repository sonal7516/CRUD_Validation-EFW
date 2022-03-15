using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_EFW.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Department> Departments { get; set;}
        public DbSet<Employee> employees { get; set;}
        public DbSet<Customer> Customers { get; set; }

    }
}
