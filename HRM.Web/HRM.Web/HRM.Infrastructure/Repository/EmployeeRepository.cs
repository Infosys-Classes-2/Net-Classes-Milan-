using HRM.ApplicatonCore.Models;
using HRM.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HRM.Infrastructure.Repository
{
    public class EmployeeRepository
    {
        private readonly EmployeContext db;

        public EmployeeRepository(EmployeContext db)
        {
            this.db = db;
        }

        // for Listing or Getting data from the Database
        public async Task<List<Employee>> GetallAsync(string searchText)
        {
            var employees = await db.Employees
           .Where(e => e.Active.Value && string.IsNullOrEmpty(searchText)  //short-circuit
               || e.FirstName.Contains(searchText)
               || e.LastName.Contains(searchText))
           .Include(x => x.Department)
           .Include(y => y.Designation).ToListAsync();

            return employees;
        }

        // Find the data by id
        public async Task<Employee> GetAsync(int id) => await db.Employees.FindAsync(id);

        // For saving the data in database
        public async Task<int> AddAsync(Employee emp)
        {
            db.Employees.Add(emp);
            return await CommitAsync();
        }


        //For Edititng
        public async Task<int> EditAsync(Employee emp)
        {
            db.Employees.Update(emp);
            return await CommitAsync();
        }

        // For saving the data
        public async Task<int> CommitAsync()
        {
            var rowsAffected = await db.SaveChangesAsync();
            return rowsAffected;

        }
        // for deleing
        //public async Task<int> DeleteAsync (Employee emp)
        //{
        //    db.Employees.Remove(emp.id);
        //    var rowsAffected = await db.SaveChangesAsync();
        //    return rowsAffected;
        //}

    }
}
