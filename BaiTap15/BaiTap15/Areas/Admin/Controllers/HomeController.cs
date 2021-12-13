using BaiTap15.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTap15.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        MemberDB db = new MemberDB();

        // GET: Admin/Home
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(FormCollection frm)
        {
            string email = frm["email"];
            string password = frm["password"];
            email = email.Trim();
            password = password.Trim();
            if (email != "" && password  != "")
            {
               
                ViewBag.Error = email  + " " + password;
                TaiKhoan user = db.TaiKhoans.Where(s => s.Email.Equals(email) && s.MatKhau.Equals(password)).SingleOrDefault();
                if (user !=null) {

                    if(user.MaQuyen == 1 && user.TinhTrang == true)
                    {
                        Session["tendangnhap"] = user.HoTen;
                        Session["MatKhau"] = user.MatKhau;
                        Session["idUser"] = user.MaTK;
                        return Redirect("/Admin/MainBoard/Index");
                    }
                    else
                    {
                        ViewBag.Error = "Bạn không có quyền truy cập hoặc tài khoản đang bị khóa! ";
                        return View();
                    }
                }
                else
                {
                    ViewBag.Error = "Đăng nhập thất bại kiểm tra lại email và password! ";
                    return View();
                }
            }
            else
            {
                ViewBag.Error = "Phải nhập đầy đủ Email và Password! ";
                return View();
            }

           
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }
    }
}