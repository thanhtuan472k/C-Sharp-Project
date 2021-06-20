using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ModelEF.Model;
using PagedList;

namespace TestUngDung.Areas.Admin.Controllers
{
    public class SanPhamController : Controller
    {
        private NgoThanhTuanContext db = new NgoThanhTuanContext();

        // GET: Admin/SanPham
        public ActionResult Index(string searchString, int? page)
        {

            //var sanPhams = db.SanPhams.Include(p => p.Category);
            //return View(sanPhams.ToList());
            var sanPhams = db.SanPhams.Include(p => p.Category);
            return View(sanPhams.Where(x => x.NameProduct.Contains(searchString) || searchString == null).ToList().ToPagedList(page ?? 1, 5));
        }

        // GET: Admin/SanPham/Details/
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.SanPhams.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }


        // GET: Admin/SanPham/Create
        public ActionResult Create()
        {
            ViewBag.IDCategory = new SelectList(db.HangMucs, "IDCategory", "NameCategory");
            return View();
        }

        // POST: Admin/SanPham/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,IDCategory,NameProduct,UnitCost,Quantity,Description,StatusProduct")] Product product, HttpPostedFileBase image)
        {
            if (image != null && image.ContentLength > 0)
            {
                string fileName = Path.GetFileName(image.FileName);
                string urlImage = Server.MapPath("/Image/" + fileName);
                image.SaveAs(urlImage);
                product.ImageProduct = "/Image/" + fileName;
            }

            if (ModelState.IsValid)
            {
                db.SanPhams.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IDCategory = new SelectList(db.HangMucs, "IDCategory", "NameCategory", product.IDCategory);
            return View(product);
        }

        // GET: Admin/SanPham/Delete/
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.SanPhams.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Admin/SanPham/Delete/
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Product product = db.SanPhams.Find(id);
            db.SanPhams.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
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
