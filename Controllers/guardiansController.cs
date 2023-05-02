using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RodeSafetyTool.Models;

namespace RodeSafetyTool.Controllers
{
    public class guardiansController : Controller
    {
        private readonly guardianDbContext _context;

        public guardiansController(guardianDbContext context)
        {
            _context = context;
        }

        // GET: guardians
        public async Task<IActionResult> Index()
        {
              return View(await _context.guardians.ToListAsync());
        }

        // GET: guardians/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.guardians == null)
            {
                return NotFound();
            }

            var guardian = await _context.guardians
                .FirstOrDefaultAsync(m => m.Id == id);
            if (guardian == null)
            {
                return NotFound();
            }

            return View(guardian);
        }

        // GET: guardians/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: guardians/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Relation,Contact,City")] guardian guardian)
        {
            if (ModelState.IsValid)
            {
                _context.Add(guardian);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(guardian);
        }

        // GET: guardians/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.guardians == null)
            {
                return NotFound();
            }

            var guardian = await _context.guardians.FindAsync(id);
            if (guardian == null)
            {
                return NotFound();
            }
            return View(guardian);
        }

        // POST: guardians/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Relation,Contact,City")] guardian guardian)
        {
            if (id != guardian.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(guardian);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!guardianExists(guardian.Id))
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
            return View(guardian);
        }

        // GET: guardians/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.guardians == null)
            {
                return NotFound();
            }

            var guardian = await _context.guardians
                .FirstOrDefaultAsync(m => m.Id == id);
            if (guardian == null)
            {
                return NotFound();
            }

            return View(guardian);
        }

        // POST: guardians/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.guardians == null)
            {
                return Problem("Entity set 'guardianDbContext.guardians'  is null.");
            }
            var guardian = await _context.guardians.FindAsync(id);
            if (guardian != null)
            {
                _context.guardians.Remove(guardian);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool guardianExists(int id)
        {
          return _context.guardians.Any(e => e.Id == id);
        }
    }
}
