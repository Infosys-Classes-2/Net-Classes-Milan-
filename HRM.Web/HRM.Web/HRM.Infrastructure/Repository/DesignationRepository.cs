using HRM.ApplicatonCore.Models;
using HRM.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;


namespace HRM.Infrastructure.Repository
{
    public class DesignationRepository
    {
        private readonly EmployeContext db;

        public DesignationRepository(EmployeContext db)
        {
            this.db = db;
        }
        public async Task<List<Designation>> GetAllAsync()
        {
            var designations = await db.Designations.ToListAsync();
            return designations;
        }
        public async Task<Designation> GetAsync(int id) => await db.Designations.FindAsync(id);

        public async Task<int> AddAsync(Employee employee)
        {
            await db.Employees.AddAsync(employee);
            return await CommitAsync();
        }
        public async Task<int> EditAsync(Employee employee)
        {
             db.Employees.Update(employee);
            return await CommitAsync();
        }
        public async Task<int> DeleteAsync(Employee employee)
        {
            db.Employees.Remove(employee);
            return await CommitAsync();
        }
        public async Task<int> CommitAsync()
        {
            var rowsAffected = db.SaveChangesAsync();
            return await rowsAffected;
        }
    }

}
