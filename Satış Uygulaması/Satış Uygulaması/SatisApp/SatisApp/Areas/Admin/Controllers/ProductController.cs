using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SatisApp.DataAccess.Repository.IRepository;
using SatisApp.Models;
using SatisApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using SatisApp.Diger;

namespace SatisApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles =SD.Role_Admin)]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _UnitOfWork;
        IWebHostEnvironment _hostEnvironment;


        public ProductController(IUnitOfWork UnitOfWork, IWebHostEnvironment hostEnvironment)
        {
            _UnitOfWork = UnitOfWork;
            _hostEnvironment = hostEnvironment;


        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var nesne = _UnitOfWork.Product.GetAll(includeProporties: "Category");
            return Json(new { data = nesne });
        }

        //[Route("{product}-{id}")]
        public IActionResult Upsert(string product, int? id)
        {
            ProductVM ProductVM = new ProductVM()
            {
                Product = new Product(),
                CategoryList = _UnitOfWork.Category.GetAll().Select(i => new SelectListItem { Text = i.Name, Value = i.Id.ToString() })
            };

            if (id == null)
            {
                return View(ProductVM);
            }

            ProductVM.Product = _UnitOfWork.Product.Get(id.GetValueOrDefault());
            if (ProductVM.Product == null)
            {
                return NotFound();
            }
            return View(ProductVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(ProductVM ProductVM)
        {

            if (ModelState.IsValid)
            {
                string webRootPath = _hostEnvironment.WebRootPath;
                var files = HttpContext.Request.Form.Files;

                if (files.Count > 0)
                {
                    string filename = Guid.NewGuid().ToString();
                    var uploads = Path.Combine(webRootPath, @"images\products");
                    var extenstion = Path.GetExtension(files[0].FileName);
                    if (ProductVM.Product.ImageUrl != null)
                    {
                        var imagePath = Path.Combine(webRootPath, ProductVM.Product.ImageUrl.TrimStart('\\'));

                        if (System.IO.File.Exists(imagePath))
                        {
                            System.IO.File.Delete(imagePath);
                        }
                    }

                    using (var filesStreams = new FileStream(Path.Combine(uploads, filename + extenstion), FileMode.Create))
                    {

                        files[0].CopyTo(filesStreams);

                    }
                    ProductVM.Product.ImageUrl = @"\images\products\" + filename + extenstion;

                }

                else
                {
                    if (ProductVM.Product.Id != 0)
                    {
                        var nesne = _UnitOfWork.Product.Get(ProductVM.Product.Id);
                        ProductVM.Product.ImageUrl = nesne.ImageUrl;
                    }
                }


                if (ProductVM.Product.Id == 0)
                {
                    _UnitOfWork.Product.Add(ProductVM.Product);
                }
                else
                {
                    _UnitOfWork.Product.Update(ProductVM.Product);
                }
                _UnitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ProductVM.CategoryList = _UnitOfWork.Category.GetAll().Select(i => new SelectListItem { Text = i.Name, Value = i.Id.ToString() });
                if (ProductVM.Product.Id != 0)
                {
                    ProductVM.Product = _UnitOfWork.Product.Get(ProductVM.Product.Id);
                }
            }


            return View(ProductVM);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var nesne = _UnitOfWork.Product.Get(id);
            if (nesne == null)
            {
                return Json(new { success = false, message = "Silme İşlemi Başarısız" });
            }
            string webRootPath = _hostEnvironment.WebRootPath;
            var imagePath = Path.Combine(webRootPath, nesne.ImageUrl.TrimStart('\\'));

            if (System.IO.File.Exists(imagePath))
            {
                System.IO.File.Delete(imagePath);
            }

            _UnitOfWork.Product.Remove(nesne);
            _UnitOfWork.Save();
            return Json(new { success = true, message = "Silme İşlemi Gerçekleşti" });

        }


    }
}
