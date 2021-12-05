using Google.Apis.Admin.Directory.directory_v1.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SatisApp.DataAccess.Data;
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
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _db;
        public UserController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LockUnLock([FromBody] string id)
        {
            var nesne = _db.ApplicationUsers.FirstOrDefault(u => u.Id == id);

            if (nesne == null)
            {
                return Json(new {success=false,message="Hesap Açma/Kapama Sırasında Bir hata ile karşılaşıldı"});
            }
            if (nesne.LockoutEnd !=null && nesne.LockoutEnd>DateTime.Now)
            {
                nesne.LockoutEnd = DateTime.Now;
            }
            else
            {
                nesne.LockoutEnd = DateTime.Now.AddYears(10);
            }
            _db.SaveChanges();
            return Json(new { success = true, message = "İşlem Başarılı" });
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            var userList = _db.ApplicationUsers.ToList();
            var userRole = _db.UserRoles.ToList();
            var Roles = _db.Roles.ToList();

            foreach (var item in userList)
            {
                var roleId = userRole.FirstOrDefault(u => u.UserId == item.Id).RoleId;
                item.Role = Roles.FirstOrDefault(u=> u.Id==roleId).Name;

            }

            return Json(new { data = userList });
        }
         

    }
}
