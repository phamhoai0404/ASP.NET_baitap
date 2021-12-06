using BaiTap14.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace BaiTap14.Controllers
{
    public class HomeController : Controller
    {
        private WineStore2 db = new WineStore2();
        public ActionResult Index()
        {
            //Đoạn code này mình không hiểu ý nghĩa của nó lắm
            //Hình như  khi chưa đăng nhập thì nó sẽ là ở login
            ////còn mấy phần khác khi mình test nó vẫn vào bình thường chắc khi làm bài tập lớn thì cần kiểm tra cái này ở phần nữa đấy mình nghĩ thế 
            if(Session["idUser"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }
        public ActionResult Test()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register([Bind(Include = "manguoidung,hoten,matkhau,email")] nguoidung nguoidung)
        {
            if (ModelState.IsValid)
            {
                db.nguoidungs.Add(nguoidung);
                db.SaveChanges();
                return RedirectToAction("Login");
            }

            return View(nguoidung);
        }

        [HttpGet]
        public ActionResult Login()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string email, string matkhau)
        {
            email = email.Trim();
            
            if (ModelState.IsValid)
            {
                var user = db.nguoidungs.Where(u => u.email.Equals(email) && u.matkhau.Equals(matkhau)).ToList();
                if(user.Count() > 0)
                {
                    //Sử dụng Session : add Session
                    Session["HoTen"] = user.FirstOrDefault().hoten;
                    Session["Email"] = user.FirstOrDefault().email;
                    Session["idUser"] = user.FirstOrDefault().manguoidung;

                    return RedirectToAction("Index");

                }
                else
                {
                    ViewBag.error = "Đăng nhập không thành công!" + email + "matkhau:"+matkhau;
                }
            }


            return View();
        }
        [HttpGet]
        public ActionResult EditHotenAndEmail(int? id)
        {
         

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nguoidung nguoidung = db.nguoidungs.Find(id);
            if (nguoidung == null)
            {
                return HttpNotFound();
            }
            return View(nguoidung);
        }


        //Haha lỗi này cũng có ở phần bài tập lớn chú ý nhá
        //Phần này Include = "manguoidung, hoten, matkhau, email, khoa") kể cả không sửa gì thì vẫn phải ghi vào nó còn liên quan đến cái hidden ở phía view nữa nên thật chú ý nhá nó liên quan đến modelSTat ấy

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditHotenAndEmail([Bind(Include = "manguoidung, hoten, matkhau, email, khoa")] nguoidung nguoidung)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nguoidung).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nguoidung);
        }

        [HttpGet]
        public ActionResult EditPass(int? id)
        {


            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nguoidung nguoidung = db.nguoidungs.Find(id);
            if (nguoidung == null)
            {
                return HttpNotFound();
            }
            return View(nguoidung);
        }


        //Haha lỗi này cũng có ở phần bài tập lớn chú ý nhá
        //Phần này Include = "manguoidung, hoten, matkhau, email, khoa") kể cả không sửa gì thì vẫn phải ghi vào nó còn liên quan đến cái hidden ở phía view nữa nên thật chú ý nhá nó liên quan đến modelSTat ấy

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditPass([Bind(Include = "manguoidung, hoten, matkhau, email, khoa")] nguoidung nguoidung)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nguoidung).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nguoidung);
        }

    }
}