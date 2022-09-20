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

        public async Task<int> AddAsync(Designation designation)
        {
            await db.Designations.AddAsync(designation);
            return await CommitAsync();
        }
        public async Task<int> EditAsync(Designation designation)
        {
             db.Designations.Update(designation);
            return await CommitAsync();
        }
        public async Task<int> DeleteAsync(Designation designation)
        {
            db.Designations.Remove(designation);
            return await CommitAsync();
        }
        public async Task<int> CommitAsync()
        {
            var rowsAffected = db.SaveChangesAsync();
            return await rowsAffected;
        }
    }

}
