using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SatisApp.DataAccess.Repository.IRepository;
using SatisApp.Diger;
using SatisApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SatisApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _UnitOfWork;
        public CategoryController(IUnitOfWork UnitOfWork)
        {
            _UnitOfWork = UnitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var nesne = _UnitOfWork.Category.GetAll();
            return Json(new { data = nesne});
        }

        public IActionResult Upsert(int? id)
        {
            Category category = new Category();

            if (id == null)
            {
                return View(category);
            }

            category = _UnitOfWork.Category.Get(id.GetValueOrDefault());
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Category category)
        {
     
            if (ModelState.IsValid)
            {
                if (category.Id==0)
                {
                    _UnitOfWork.Category.Add(category);
                }
                else
                {
                    _UnitOfWork.Category.Update(category);
                }
                _UnitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }


            return View(category);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var nesne = _UnitOfWork.Category.Get(id);
            if (nesne==null)
            {
                return Json(new { success = false, message = "Silme İşlemi Başarısız" });
            }
            _UnitOfWork.Category.Remove(nesne);
            _UnitOfWork.Save();
            return Json(new { success = true, message = "Silme İşlemi Gerçekleşti" });

        }


    }
}
