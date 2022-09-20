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
    public class DesignationController : Controller
    {
      
        private readonly DesignationRepository designationRepository;

        public DesignationController(DesignationRepository designationRepository)
        {
            this.designationRepository = designationRepository;
        }

        // GET: Designation
        public async Task<IActionResult> Index()
        {
            var desgination = await designationRepository.GetAllAsync();
            return View(desgination.ToViewModel());
        }

        // GET: Designation/Details/5
        public async Task<IActionResult> Details(int id)
        {

            var designation = await designationRepository.GetAsync(id);
            return View(designation.ToViewModel());
        }

        // GET: Designation/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Designation/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize]

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,title,category,Description")] DesignationViewModel designationViewModel)
        {
            var designations = await designationRepository.AddAsync(designationViewModel.ToModel());

            return RedirectToAction(nameof(Index));
        }

        // GET: Designation/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
           
            var designation = await designationRepository.GetAsync(id.Value);
           
            return View(designation.ToViewModel());
        }

        // POST: Designation/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize]

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,title,category,Description")] DesignationViewModel designationViewModel)
        {
            var designaitons = await designationRepository.EditAsync(designationViewModel.ToModel());
            return RedirectToAction(nameof(Index));
        }

        // GET: Designation/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
           
            var designation = await designationRepository.GetAsync(id);
               
            return View(designation.ToViewModel());
        }

        // POST: Designation/Delete/5
        [HttpPost, ActionName("Delete")]
        [Authorize]

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (designationRepository == null)
            {
                return Problem("Entity set 'EmployeContext.Designations'  is null.");
            }
            var designation = await designationRepository.GetAsync(id);
            if (designation != null)
            {
                await designationRepository.DeleteAsync(designation);
            }
            return RedirectToAction(nameof(Index));
        }

        private bool DesignationExists(int id)
        {
            var designations = designationRepository.GetAsync(id) != null;
            return designations;
        }
    }
}
