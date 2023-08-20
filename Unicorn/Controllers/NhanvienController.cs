
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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
        public async Task<ActionResult> Add([Bind("ID_NV,ImageFile,Name,Nam_sinh,Gioi_tinh,Que_quan,SDT,CMT,Ngay_vao,Ngay_tao,ID_To,ID_Chucvu")] NV nV)
        {
            if (ModelState.IsValid)
            {
                if (nV.ImageFile != null)
                {
                    string wwwRootPath = _WebHost.WebRootPath;
                    string Filename = Path.GetFileName(nV.ImageFile.FileName);
                    nV.Image = "/Image/" +  Filename;
                    string path = Path.Combine(wwwRootPath + "/Image", Filename);
                    using (var FileStream = new FileStream(path, FileMode.Create))
                    {
                        await nV.ImageFile.CopyToAsync(FileStream);
                    }
                }    
                else
                {
                    nV.Image = "/image/No_Image.png";
                }
                var To = await _DBContext.To.FindAsync(nV.ID_To);
                var CV = await _DBContext.CV.FindAsync(nV.ID_Chucvu);
                nV.Name_CV = CV.Name;
                nV.Name_To = To.Name;
                nV.Ngay_tao = DateTime.Now;
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
        public async Task<IActionResult> Edit(string id)
        {
            ViewBag.ID_ToList = ListToAll();
            ViewBag.ID_CVList = ListCVAll();
            if (id == null || _DBContext.NV == null)
            {
                return NotFound();
            }

            var nV = await _DBContext.NV.FindAsync(id);
            ViewBag.Image = nV.Image;
            ViewBag.Date = nV.Nam_sinh.ToString("yyyy-MM-dd");
            ViewBag.Ngay_vao = nV.Ngay_vao.ToString("yyyy-MM-dd");
            if (nV == null)
            {
                return NotFound();
            }
            return View(nV);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(String id, [Bind("ID_NV,ImageFile,Name,Nam_sinh,Gioi_tinh,Que_quan,SDT,CMT,Ngay_vao,Ngay_tao,ID_To,ID_Chucvu")] NV nV)
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
                    nV.Image = "/Image/" + Filename;
                    string path = Path.Combine(wwwRootPath + "/Image", Filename);
                    using (var FileStream = new FileStream(path, FileMode.Create))
                    {
                        await nV.ImageFile.CopyToAsync(FileStream);
                    }
                }
                else
                {
                    nV.Image = "/image/No_Image.png";
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

        #region Controller Modal Tổ
        [HttpPost]
        public JsonResult SaveToModal(Models.To model)
        {
            var result = false;
            try
            {
                Models.To Stu = new Models.To();
                Stu.ID_To = model.ID_To;
                Stu.Name = model.Name;
                Stu.Ghi_chu = model.Ghi_chu;
                _DBContext.To.Add(Stu);
                _DBContext.SaveChanges();
                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Json(result);
        }
        #endregion

        #region Controller Modal Chức vụ
        [HttpPost]
        public JsonResult SaveCVModal(Models.CV model)
        {
            var result = false;
            try
            {
                Models.CV Stu = new Models.CV();
                Stu.ID_CV = model.ID_CV;
                Stu.Name = model.Name;
                Stu.Ghi_chu = model.Ghi_chu;
                _DBContext.CV.Add(Stu);
                _DBContext.SaveChanges();
                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Json(result);
        }
        #endregion
    }
}
