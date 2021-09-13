using BaiTap02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTap02.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult MyLink()
        {
            ViewBag.Message = "Your MyLink nha page.";

            return View();
        }

        public ActionResult ViewProduct()
        {
            Product product = new Product();
            product.MaSP = 10;
            product.TenSP = "Lập trình ASP.NET MVC";
            product.Gia = 120000;
            product.SoLuong = 34;

            ViewBag.Message = "Xem sản phẩm ";

            return View(product);

        }
    }
}