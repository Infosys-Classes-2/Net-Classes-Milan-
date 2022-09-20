using HRM.ApplicatonCore.Models;
using HRM.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HRM.Infrastructure.Repository
{
    public class DepartmentRepository
    {
        private readonly EmployeContext db;

        // Dependency injection or (Database sanga connect gareko)
        public DepartmentRepository(EmployeContext db)
        {
            this.db = db;
        }

        public async Task<List<Department>> GetAllAsync()
        {
            var departments = await db.Departments.ToListAsync();
            return departments;
        }
        public async Task<int> AddAsync(Department department)
        {
            db.Departments.Add(department);
            return await CommitAsync();
        }
        public async Task<int> EditAsync(Department department)
        {
            db.Departments.Update(department);
            return await CommitAsync();
        }
        public async Task<int> DeleteAsync(Department department)
        {
            db.Departments.Remove(department);
            return await CommitAsync();
        }
        public async Task<Department> GetAsync(int id) => await db.Departments.FindAsync(id);
       
       

        public Task DeleteAsync(int? id)
        {
            throw new NotImplementedException();
        }
        public async Task<int> CommitAsync()
        {
            var rowsAffected = await db.SaveChangesAsync();
            return rowsAffected;
        }
    }
}
