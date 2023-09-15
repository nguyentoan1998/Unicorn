
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using Unicorn.Models;

namespace Unicorn.Controllers
{
    public class NhanvienController : Controller
    {
        private readonly ApplicationDbContext _DBContext;
        private readonly IWebHostEnvironment _WebHost;
        public NhanvienController(ApplicationDbContext dBContext, IWebHostEnvironment webHost)
        {
            _DBContext = dBContext;
            _WebHost = webHost;
        }
        #region Controller Nhân viên
        // GET: Nhanvien
        public async Task<ActionResult> Index()
        {
            var item = _DBContext.NV;
            return View(item);
        }
        public ActionResult Add()
        {
            ViewBag.ID_ToList = ListToAll();
            ViewBag.ID_CVList = ListCVAll();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Add([Bind("ID_NV,ImageFile,Name,Nam_sinh,Gioi_tinh,Que_quan,SDT,CMT,Ngay_vao,Ngay_tao,ID_To,ID_CV")] NV nV)
        {
            if (ModelState.IsValid)
            {
                if (nV.ImageFile != null)
                {
                    string wwwRootPath = _WebHost.WebRootPath;
                    string Filename = Path.GetFileName(nV.ImageFile.FileName);
                    nV.Image = "/Image/" + "Nhanvien." + nV.ID_NV + ".png";
                    string path = Path.Combine(wwwRootPath + "/Image/" + "Nhanvien." + nV.ID_NV + ".png");
                    using (var FileStream = new FileStream(path, FileMode.Create))
                    {
                        await nV.ImageFile.CopyToAsync(FileStream);
                    }
                }    
                _DBContext.NV.Add(nV);
                await _DBContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nV);
        }
        public List<SelectListItem> ListToAll()
        {
            var ListTo = new List<SelectListItem>();
            List<To> To = _DBContext.To.ToList();
            ListTo = To.Select(ct => new SelectListItem()
            {
                Value = ct.ID_To,
                Text = ct.Name
            }).ToList();
            var defItem = new SelectListItem()
            {
                Value="",
                Text="----- Select Tổ -----"
            };
            ListTo.Insert(0, defItem);
            return ListTo;
        }
        public List<SelectListItem> ListCVAll()
        {
            var ListTo = new List<SelectListItem>();
            List<CV> CV = _DBContext.CV.ToList();
            ListTo = CV.Select(ct => new SelectListItem()
            {
                Value = ct.ID_CV,
                Text = ct.Name
            }).ToList();
            var defItem = new SelectListItem()
            {
                Value = "",
                Text = "----- Select Chức vụ -----"
            };
            ListTo.Insert(0, defItem);
            return ListTo;
        }
        public async Task<IActionResult> Edit(String id)
        {
            ViewBag.ID_ToList = ListToAll();
            ViewBag.ID_CVList = ListCVAll();
            if (id == null || _DBContext.NV == null)
            {
                return NotFound();
            }

            var nv = await _DBContext.NV.FindAsync(id);
            ViewBag.Image = nv.Image;
            ViewBag.Date = nv.Nam_sinh.ToString("yyyy-MM-dd");
            ViewBag.Ngay_vao = nv.Ngay_vao.ToString("yyyy-MM-dd");
            if (nv == null)
            {
                return NotFound();
            }
            return View(nv);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(String id, [Bind("ID_NV,ImageFile,Name,Nam_sinh,Gioi_tinh,Que_quan,SDT,CMT,Ngay_vao,Ngay_tao,ID_To,ID_CV")] NV nV)
        {
            if (id != nV.ID_NV)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                if (nV.ImageFile != null)
                {
                    string wwwRootPath = _WebHost.WebRootPath;
                    string Filename = Path.GetFileName(nV.ImageFile.FileName);
                    nV.Image = "/Image/" + "Nhanvien." + nV.ID_NV + ".png";
                    string path = Path.Combine(wwwRootPath + "/Image/" + "Nhanvien." + nV.ID_NV + ".png");
                    using (var FileStream = new FileStream(path, FileMode.Create))
                    {
                        await nV.ImageFile.CopyToAsync(FileStream);
                    }
                }
                else
                {
                    //var image = await _DBContext.NV.FindAsync(nV.ID_NV);
                    nV.Image = "/Image/" + "Nhanvien." + nV.ID_NV + ".png";
                }
                try
                {

                    _DBContext.Update(nV);
                    await _DBContext.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NVExists(nV.ID_NV))
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
            return View(nV);
        }
        [HttpPost]
        public ActionResult Delete(String id)
        {
            var item = _DBContext.NV.Find(id);
            if (item != null)
            {
                _DBContext.NV.Remove(item);
                _DBContext.SaveChanges();
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }
        private bool NVExists(String id)
        {
            return _DBContext.NV.Any(e => e.ID_NV == id);
        }
        #endregion
    }
}
