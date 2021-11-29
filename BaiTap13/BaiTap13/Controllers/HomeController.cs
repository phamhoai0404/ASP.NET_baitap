using BaiTap13.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace BaiTap13.Controllers
{
    public class HomeController : Controller
    {
        private fShopDB db = new fShopDB();

        // GET: Hangs
        public ActionResult Index(string id, int? page)
        {
            List<Hang> hangs = new List<Hang>();
            if( id== null)
            {
                //Nếu mà không có id truyền vào thì lấy toàn bộ
                hangs = db.Hangs.Select(h => h).ToList();
            }
            else
            {
                //Nếu có id thì lấy hàng theo mã nhà cung cấp
                hangs = db.Hangs.Where(h => h.MaNCC.Equals(id)).Select(h => h).ToList();
            }

            int pageSizeFix = 6; //Kích thước trang
            int pageNumber = (page ?? 1);

            return View(hangs.ToPagedList(pageNumber, pageSizeFix));
        }

        public ActionResult ChiTietSanPham(string id)
        {
            

             if (id == null)
             {
                 return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
             }
             Hang hang = db.Hangs.Find(id);
             if (hang == null)
             {
                 return HttpNotFound();
             }
             return View(hang);

        }



        //Truyền dữ liệu vào partial thì có 2 kiểu 
        //Kiểu thứ 1
        public PartialViewResult _Nav()
        {
            var nhacc = db.Nha_CC.Select(n => n);
            return PartialView(nhacc);
        }

        //Kiểu thứ 2
        [ChildActionOnly]
        public ActionResult _Aside()
        {
            //Lấy 3 bản ghi đầu tiên với danh sách hàng sắp xếp theo chiều số lượng giảm dần
            var listHang = db.Hangs.OrderByDescending(h => h.LuongCo).Select(h => h).Take(3);
            return PartialView(listHang);
        }


        public PartialViewResult _Search()
        {
            var nhacc = db.Nha_CC.Select(n => n);
            return PartialView(nhacc);
        }
    }
}