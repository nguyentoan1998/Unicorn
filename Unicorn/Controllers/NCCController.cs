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
    public class NCCController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NCCController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: NCC
        public async Task<IActionResult> Index()
        {
              return View(await _context.NCC.ToListAsync());
        }


        // GET: NCC/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NCC/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID_NCC,Name,Dia_chi,Ghi_chu,Is_KH")] NCC nCC)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nCC);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nCC);
        }

        // GET: NCC/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.NCC == null)
            {
                return NotFound();
            }

            var nCC = await _context.NCC.FindAsync(id);
            if (nCC == null)
            {
                return NotFound();
            }
            return View(nCC);
        }

        // POST: NCC/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ID_NCC,Name,Dia_chi,Ghi_chu,Is_KH")] NCC nCC)
        {
            if (id != nCC.ID_NCC)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nCC);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NCCExists(nCC.ID_NCC))
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
            return View(nCC);
        }

        private bool NCCExists(string id)
        {
          return _context.NCC.Any(e => e.ID_NCC == id);
        }
    }
}
