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
    public class ToController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ToController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: To
        public async Task<IActionResult> Index()
        {
              return View(await _context.To.ToListAsync());
        }

        // GET: To/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.To == null)
            {
                return NotFound();
            }

            var to = await _context.To
                .FirstOrDefaultAsync(m => m.ID_To == id);
            if (to == null)
            {
                return NotFound();
            }

            return View(to);
        }

        // GET: To/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: To/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID_To,Name,Ghi_chu")] To to)
        {
            if (ModelState.IsValid)
            {
                _context.Add(to);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(to);
        }

        // GET: To/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.To == null)
            {
                return NotFound();
            }

            var to = await _context.To.FindAsync(id);
            if (to == null)
            {
                return NotFound();
            }
            return View(to);
        }

        // POST: To/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ID_To,Name,Ghi_chu")] To to)
        {
            if (id != to.ID_To)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(to);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ToExists(to.ID_To))
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
            return View(to);
        }

        // GET: To/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.To == null)
            {
                return NotFound();
            }

            var to = await _context.To
                .FirstOrDefaultAsync(m => m.ID_To == id);
            if (to == null)
            {
                return NotFound();
            }

            return View(to);
        }

        // POST: To/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.To == null)
            {
                return Problem("Entity set 'ApplicationDbContext.To'  is null.");
            }
            var to = await _context.To.FindAsync(id);
            if (to != null)
            {
                _context.To.Remove(to);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ToExists(string id)
        {
          return _context.To.Any(e => e.ID_To == id);
        }
    }
}
