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
    }

}
