using Hrm.Web.Data;
using Hrm.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hrm.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly HrmContext db;

        // Dependency injection (DI), built-in
        public EmployeeController(HrmContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public async Task<IActionResult> List(string searchText)
        {
            var employees = await db.Employees;
                //.Where(e => string.IsNullOrEmpty(searchText)  //Short-circuit
                //        || e.FirstName.Contains(searchText)
                //        || e.LastName.Contains(searchText))
                //.Include(x => x.Department)
                //.Include(y => y.Designation).ToListAsync();

            return View(employees);
        }

        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Delete()
        {
            return View();
        }
       
    }
}
