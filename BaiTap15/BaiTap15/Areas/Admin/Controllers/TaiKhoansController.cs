using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BaiTap15.Models;

namespace BaiTap15.Areas.Admin.Controllers
{
    public class TaiKhoansController : Controller
    {
        private MemberDB db = new MemberDB();

       
        public ActionResult Index()
        {
            if (Session["idUser"] != null)
            {
                var taiKhoans = db.TaiKhoans.Include(t => t.Quyen).ToList();
                string idUser = Session["idUser"] + "";
                for (int i = 0; i < taiKhoans.Count(); i++)
                {
                    if (taiKhoans[i].MaTK + "" == idUser)
                    {
                        taiKhoans.Remove(taiKhoans[i]);
                        break;
                    }
                }
                return View(taiKhoans);
            }
            else
            {
                return Redirect("/Admin/Home/Index");
            }
          
        }

        // GET: Admin/TaiKhoans/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaiKhoan taiKhoan = db.TaiKhoans.Find(id);
            if (taiKhoan == null)
            {
                return HttpNotFound();
            }
            return View(taiKhoan);
        }

        // GET: Admin/TaiKhoans/Create
        public ActionResult Create()
        {
            ViewBag.MaQuyen = new SelectList(db.Quyens, "MaQuyen", "TenQuyen");
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaTK,Email,MatKhau,HoTen,DiaChi,DienThoai,Anh,TinhTrang,MaQuyen")] TaiKhoan taiKhoan)
        {
            if (ModelState.IsValid)
            {
                db.TaiKhoans.Add(taiKhoan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaQuyen = new SelectList(db.Quyens, "MaQuyen", "TenQuyen", taiKhoan.MaQuyen);
            return View(taiKhoan);
        }

       [HttpGet]
        public ActionResult EditThongTinCaNhan(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaiKhoan taiKhoan = db.TaiKhoans.Find(id);
            if (taiKhoan == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaQuyen = new SelectList(db.Quyens, "MaQuyen", "TenQuyen", taiKhoan.MaQuyen);
            return View(taiKhoan);
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditThongTinCaNhan([Bind(Include = "MaTK,Email,MatKhau,HoTen,DiaChi,DienThoai,Anh,TinhTrang,MaQuyen")] TaiKhoan taiKhoan)
        {
            if (ModelState.IsValid)
            {
                
                var file = Request.Files["ImageFile"];
                if (file != null && file.ContentLength > 0)
                {
                    //Lấy tên file 
                    string fileName = System.IO.Path.GetFileName(file.FileName);

                    //Lưu file ảnh vào địa chỉ mới
                    string upload = Server.MapPath("~/Areas/Admin/Assets/Images/" + fileName);
                    file.SaveAs(upload);
                    taiKhoan.Anh = fileName;
                }

                db.Entry(taiKhoan).State = EntityState.Modified;
                db.SaveChanges();

                //Sau khi mà thay đổi họ tên thì cái session này sẽ thay đổi theo
                Session["tendangnhap"] = taiKhoan.HoTen;

                return RedirectToAction("Index");
            }


            ViewBag.MaQuyen = new SelectList(db.Quyens, "MaQuyen", "TenQuyen", taiKhoan.MaQuyen);
            return View(taiKhoan);
        }
        [HttpGet]
        public ActionResult EditMatKhau(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaiKhoan taiKhoan = db.TaiKhoans.Find(id);
            if (taiKhoan == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaQuyen = new SelectList(db.Quyens, "MaQuyen", "TenQuyen", taiKhoan.MaQuyen);
            return View(taiKhoan);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditMatKhau([Bind(Include = "MaTK,Email,MatKhau,HoTen,DiaChi,DienThoai,Anh,TinhTrang,MaQuyen")] TaiKhoan taiKhoan)
        {
           
            string cu= Request["matkhaucu"];
            string moi = Request["matkhaumoi"];
            string xacnhan= Request["matkhauxacnhan"];

            if (cu !=null && moi!=null && xacnhan != null)
            {
                cu = cu.Trim();
                moi = moi.Trim();
                xacnhan = xacnhan.Trim();
                if(cu !="" && moi!= "" && xacnhan != "")
                {
                    if(moi == xacnhan)
                    {
                        if (cu == Session["MatKhau"] + "")
                        {
                            taiKhoan.MatKhau = moi;
                            Session["MatKhau"] = moi;
                            db.Entry(taiKhoan).State = EntityState.Modified;
                            db.SaveChanges();
                            return Redirect("/Admin/DieuKhien/Index");
                        }
                        else
                        {
                            ViewBag.LoiMatKhau = "Mật khẩu cũ không khớp!";
                            return View(taiKhoan);
                        }
                    }
                    else
                    {
                        ViewBag.LoiMatKhau = "Mật khẩu mới và xác nhận không khớp!";
                        return View(taiKhoan);
                    }
                    
                }
                else
                {
                    ViewBag.LoiMatKhau = "Không được để trống trường dữ liệu nào!";
                    return View(taiKhoan);
                }
               
            }
            else
            {
                ViewBag.LoiMatKhau = "Không được để trống trường dữ liệu nào!";
                return View(taiKhoan);
            }

            //db.Entry(taiKhoan).State = EntityState.Modified;
            //db.SaveChanges();
            // return RedirectToAction("Index");

            



        }

        // GET: Admin/TaiKhoans/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaiKhoan taiKhoan = db.TaiKhoans.Find(id);
            if (taiKhoan == null)
            {
                return HttpNotFound();
            }
            return View(taiKhoan);
        }

        // POST: Admin/TaiKhoans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            
            TaiKhoan taiKhoan = db.TaiKhoans.Find(id);
            
            db.TaiKhoans.Remove(taiKhoan);
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


        [HttpPost]
        public JsonResult Update(int? id)
        {
                TaiKhoan user = db.TaiKhoans.Find(id);
                if (user == null)
                {
                    return Json("NOT_FOUND", JsonRequestBehavior.AllowGet);
                }

                user.TinhTrang = ! user.TinhTrang ;
               
                db.Configuration.ValidateOnSaveEnabled = false;
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();

                return Json("SUCCESS", JsonRequestBehavior.AllowGet);

        }
    }
}
