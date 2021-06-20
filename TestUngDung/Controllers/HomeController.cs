using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelEF.Model;


namespace TestUngDung.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var productDao = new ProductDao();
            ViewBag.NewProducts = productDao.ListNewProduct(10);
            return View();
        }
    }
}

