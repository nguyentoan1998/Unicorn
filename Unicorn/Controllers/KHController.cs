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
    public class KHController : Controller
    {
        private readonly ApplicationDbContext _context;

        public KHController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: KH
        public async Task<IActionResult> Index()
        {
              return View(await _context.KH.ToListAsync());
        }

        // GET: KH/Details/5

        // GET: KH/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: KH/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID_KH,Name,Dia_chi,Ghi_chu,Is_NCC")] KH kH)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kH);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kH);
        }

        // GET: KH/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.KH == null)
            {
                return NotFound();
            }

            var kH = await _context.KH.FindAsync(id);
            if (kH == null)
            {
                return NotFound();
            }
            return View(kH);
        }

        // POST: KH/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ID_KH,Name,Dia_chi,Ghi_chu,Is_NCC")] KH kH)
        {
            if (id != kH.ID_KH)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kH);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KHExists(kH.ID_KH))
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
            return View(kH);
        }
        public ActionResult Delete(String id)
        {
            var item = _context.KH.Find(id);
            if (item != null)
            {
                _context.KH.Remove(item);
                _context.SaveChanges();
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }
        private bool KHExists(string id)
        {
          return _context.KH.Any(e => e.ID_KH == id);
        }
    }
}
