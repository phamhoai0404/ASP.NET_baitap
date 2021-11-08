using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BaiTap11_3.Models;

namespace BaiTap11_3.Controllers
{
    public class SinhViensController : Controller
    {
        private SinhVienDB db = new SinhVienDB();

        // GET: SinhViens
        public ActionResult Index()
        {
            return View(db.SinhViens.ToList());
        }

        // GET: SinhViens/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SinhVien sinhVien = db.SinhViens.Find(id);
            if (sinhVien == null)
            {
                return HttpNotFound();
            }
            return View(sinhVien);
        }

        // GET: SinhViens/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SinhViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaSV,TenSV,DiaChi,DienThoai,Email,Anh,TenDN,MatKhau,Khoa")] SinhVien sinhVien)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    sinhVien.Anh = null;
                    var f = Request.Files["ImageFilesss"];
                    if (f != null && f.ContentLength > 0)
                    {
                        string FileName = System.IO.Path.GetFileName(f.FileName);
                        string UploadPath = Server.MapPath("~/wwwroot/Images/" + FileName);

                        f.SaveAs(UploadPath);

                        sinhVien.Anh = FileName;
                    }
                    db.SinhViens.Add(sinhVien);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");


            }
            catch (Exception ex)
            {
                ViewBag.Error = "Có lỗi xảy ra ! " + ex.Message;
                return View(sinhVien);
            }
            
        }

        // GET: SinhViens/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SinhVien sinhVien = db.SinhViens.Find(id);
            if (sinhVien == null)
            {
                return HttpNotFound();
            }
            return View(sinhVien);
        }

        // POST: SinhViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaSV,TenSV,DiaChi,DienThoai,Email,Anh,TenDN,MatKhau,Khoa")] SinhVien sinhVien)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var f = Request.Files["ImageFile"];
                    if (f != null && f.ContentLength > 0)
                    {
                       
                        string FileName = System.IO.Path.GetFileName(f.FileName);
                        string UploadPath = Server.MapPath("~/wwwroot/Images/" + FileName);
                        
                        f.SaveAs(UploadPath);
                       
                        sinhVien.Anh = FileName;
                    }
                    db.Entry(sinhVien).State = EntityState.Modified;
                    db.SaveChanges();
                }
                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {

                ViewBag.Error = "Lỗi sửa dữ liệu! " + ex.Message;
                return View(sinhVien);
            }
        }

        // GET: SinhViens/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SinhVien sinhVien = db.SinhViens.Find(id);
            if (sinhVien == null)
            {
                return HttpNotFound();
            }
            return View(sinhVien);
        }

        // POST: SinhViens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            SinhVien sinhVien = db.SinhViens.Find(id);
            db.SinhViens.Remove(sinhVien);
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
