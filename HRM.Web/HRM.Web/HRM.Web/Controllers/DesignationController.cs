﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRM.ApplicatonCore.Models;
using HRM.Infrastructure.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;


namespace HRM.Web.Controllers
{
    public class DesignationController : Controller
    {
        private readonly EmployeContext _context;

        public DesignationController(EmployeContext context)
        {
            _context = context;
        }

        // GET: Designation
        public async Task<IActionResult> Index()
        {
            return _context.Designations != null ?
                        View(await _context.Designations.ToListAsync()) :
                        Problem("Entity set 'EmployeContext.Designations'  is null.");
        }

        // GET: Designation/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Designations == null)
            {
                return NotFound();
            }

            var designation = await _context.Designations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (designation == null)
            {
                return NotFound();
            }

            return View(designation);
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
        public async Task<IActionResult> Create([Bind("Id,title,category,Description")] Designation designation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(designation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(designation);
        }

        // GET: Designation/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Designations == null)
            {
                return NotFound();
            }

            var designation = await _context.Designations.FindAsync(id);
            if (designation == null)
            {
                return NotFound();
            }
            return View(designation);
        }

        // POST: Designation/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize]

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,title,category,Description")] Designation designation)
        {
            if (id != designation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(designation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DesignationExists(designation.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(designation);
        }

        // GET: Designation/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Designations == null)
            {
                return NotFound();
            }

            var designation = await _context.Designations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (designation == null)
            {
                return NotFound();
            }

            return View(designation);
        }

        // POST: Designation/Delete/5
        [HttpPost, ActionName("Delete")]
        [Authorize]

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Designations == null)
            {
                return Problem("Entity set 'EmployeContext.Designations'  is null.");
            }
            var designation = await _context.Designations.FindAsync(id);
            if (designation != null)
            {
                _context.Designations.Remove(designation);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DesignationExists(int id)
        {
            return (_context.Designations?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
