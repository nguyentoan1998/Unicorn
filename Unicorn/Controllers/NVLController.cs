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
    public class NVLController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NVLController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: NVL
        public async Task<IActionResult> Index()
        {
              return View(await _context.NVL.ToListAsync());
        }
        [HttpGet]
        public async Task<IActionResult> GetData()
        {
            var _NVL = await _context.NVL.ToListAsync();
            return Json(new { data = _NVL });
        }

        // GET: NVL/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.NVL == null)
            {
                return NotFound();
            }

            var nVL = await _context.NVL
                .FirstOrDefaultAsync(m => m.ID_NVL == id);
            if (nVL == null)
            {
                return NotFound();
            }

            return View(nVL);
        }

        // GET: NVL/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NVL/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID_NVL,Name,ID_DVT,Mo_ta,SL_ton,Nguon_goc,DG_mua,DG_ban,ImageFile,Size,ID_Loai")] NVL nVL)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nVL);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nVL);
        }

        // GET: NVL/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.NVL == null)
            {
                return NotFound();
            }

            var nVL = await _context.NVL.FindAsync(id);
            if (nVL == null)
            {
                return NotFound();
            }
            return View(nVL);
        }

        // POST: NVL/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ID_NVL,Name,ID_DVT,Mo_ta,SL_ton,Nguon_goc,DG_mua,DG_ban,ImageFile,Size,ID_Loai")] NVL nVL)
        {
            if (id != nVL.ID_NVL)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nVL);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NVLExists(nVL.ID_NVL))
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
            return View(nVL);
        }
        public ActionResult Delete(String id)
        {
            var item = _context.NVL.Find(id);
            if (item != null)
            {
                _context.NVL.Remove(item);
                _context.SaveChanges();
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }
        private bool NVLExists(string id)
        {
          return _context.NVL.Any(e => e.ID_NVL == id);
        }
    }
}
