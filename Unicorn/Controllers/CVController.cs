using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Unicorn.Data;
using Unicorn.Models;

namespace Unicorn.Controllers
{
    public class CVController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CVController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CV
        public async Task<IActionResult> Index()
        {
              return View(await _context.CV.ToListAsync());
        }

        // GET: CV/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.CV == null)
            {
                return NotFound();
            }

            var cV = await _context.CV
                .FirstOrDefaultAsync(m => m.ID_CV == id);
            if (cV == null)
            {
                return NotFound();
            }

            return View(cV);
        }

        // GET: CV/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CV/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID_CV,Name,Ghi_chu")] CV cV)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cV);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cV);
        }

        // GET: CV/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.CV == null)
            {
                return NotFound();
            }

            var cV = await _context.CV.FindAsync(id);
            if (cV == null)
            {
                return NotFound();
            }
            return View(cV);
        }

        // POST: CV/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ID_CV,Name,Ghi_chu")] CV cV)
        {
            if (id != cV.ID_CV)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cV);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CVExists(cV.ID_CV))
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
            return View(cV);
        }

        // GET: CV/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.CV == null)
            {
                return NotFound();
            }

            var cV = await _context.CV
                .FirstOrDefaultAsync(m => m.ID_CV == id);
            if (cV == null)
            {
                return NotFound();
            }

            return View(cV);
        }

        // POST: CV/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.CV == null)
            {
                return Problem("Entity set 'ApplicationDbContext.CV'  is null.");
            }
            var cV = await _context.CV.FindAsync(id);
            if (cV != null)
            {
                _context.CV.Remove(cV);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CVExists(string id)
        {
          return _context.CV.Any(e => e.ID_CV == id);
        }
    }
}
