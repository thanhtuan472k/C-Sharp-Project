using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ModelEF.DAO;
using ModelEF.Model;
using PagedList;

namespace TestUngDung.Areas.Admin.Controllers
{
    public class UserAccountController : Controller
    {
        private NgoThanhTuanContext db = new NgoThanhTuanContext();

   
        // GET: Admin/UserAccount
        public ActionResult Index(string searchString , int? page)
        {
            
            return View(db.UserAccounts.Where(x => x.UserName.Contains(searchString) || searchString == null).ToList().ToPagedList(page ?? 1 ,5));
        }

     

        // Delete User
        public ActionResult Delete(string id)
        {
            var dao = new UserDao().Delete(id);
            return RedirectToAction("Index");
            // lỗi cái redireect ni lam load laị trang khi dùng ajax
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
