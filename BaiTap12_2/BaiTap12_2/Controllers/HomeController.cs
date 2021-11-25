
using BaiTap12_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace BaiTap12_2.Controllers
{
    public class HomeController : Controller
    {
        private fShopDB db = new fShopDB();
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
        public ActionResult DisplaySuplier(int? page)
        {
            var supplies = db.Nha_CC.Select(s => s);

            //Cần sắp xếp trước khi phân trang
            supplies = supplies.OrderBy(s => s.MaNCC);

            int pageSizeFix = 3; //kích thước trang cố định mình ghi rõ là 3 dòng 1 trang
            int pageNumber = (page ?? 1);// nếu page bằng null thì trả về 1 trang

            //Chỗ này mới bắt đầu sử dụng thư viện PagedList này còn mấy cái trên kia chỉ là đặt tên thôi
            return View(supplies.ToPagedList(pageNumber, pageSizeFix));
          
        }
    }
}