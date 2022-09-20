using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRM.ApplicatonCore.Models;
using HRM.Infrastructure.Data;
using HRM.Infrastructure.Repository;
using HRM.Web.Mapper;
using HRM.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;


namespace HRM.Web.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly DepartmentRepository departmentRepository;

        public DepartmentController(DepartmentRepository departmentRepository )
        {
            this.departmentRepository = departmentRepository;
        }

        // GET: Department
        public async Task<IActionResult> Index()
        {
            var departments = await departmentRepository.GetAllAsync();
            var departmentViewModels = departments.ToViewModel();

            return departmentViewModels != null ?
                        View(departmentViewModels) :
                        Problem("No Departments exist on database.");
        }

        // GET: Department/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var department = await departmentRepository.GetAsync(id);
          
            return View(department.ToViewModel());
        }

        // GET: Department/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Department/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize]

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,Established")] DepartmentViewModel departmentViewModel)
        {
           
        var departments =  await departmentRepository.AddAsync(departmentViewModel.ToModel());
             
            return View(departments);
        }

        // GET: Department/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
         var department = await departmentRepository.GetAsync(id);

            return View(department.ToViewModel());
        }
        // POST: Department/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Established")] DepartmentViewModel departmentViewModel)
        {
            var department = departmentRepository.AddAsync(departmentViewModel.ToModel());
               return RedirectToAction(nameof(Index));
        }

        // GET: Department/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            var department = await departmentRepository.GetAsync(id.Value);
            if (department == null)
            {
                return NotFound();
            }

            return View(department.ToViewModel());
        }

        // POST: Department/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
       
            var department = await departmentRepository.GetAsync(id);
            if (department != null)
            {
               await departmentRepository.DeleteAsync(department);
            }
            return RedirectToAction(nameof(Index));
        }
 
        private bool DepartmentExists(int id)
        {
            var departments = departmentRepository.GetAsync (id)  != null;
            return departments;
        }
    }
}
