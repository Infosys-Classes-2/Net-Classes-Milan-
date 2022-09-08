using Hrm.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Hrm.Web.Data
{
    public class HrmContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=HrmDb;"
            + "Integrated Security=true");
        }

        public DbSet<Employee> Employees { get; set; }
       // public DbSet<Department> Departments { get; set; }
      //  public DbSet<Designation> Designations { get; set; }
    }
}
