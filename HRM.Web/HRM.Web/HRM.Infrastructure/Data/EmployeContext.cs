using Microsoft.EntityFrameworkCore;
using HRM.ApplicatonCore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using HRM.Infrastructure.Migrations;
using Microsoft.AspNetCore.Identity;

namespace HRM.Infrastructure.Data
{
    public class EmployeContext:IdentityDbContext
    {
        //Constructor banaiera DbContextOptions<EmployeContext> base ma pathako
        public EmployeContext(DbContextOptions<EmployeContext> dbContextOptions): base(dbContextOptions)
        {
        }
        // Db Seeding 
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(
                    new IdentityRole { Id=Guid.NewGuid().ToString(),Name="Admin"},
                     new IdentityRole { Id = Guid.NewGuid().ToString(), Name = "HR" }
                );
        }
        public DbSet<Employee> Employees { get; set; } //table name will be created on db EmployeeContext
        public DbSet<Department>Departments { get; set; }
        public DbSet<Designation> Designations { get; set; }
    }
}
