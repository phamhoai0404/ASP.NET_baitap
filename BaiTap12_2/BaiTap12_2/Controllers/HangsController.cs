using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BaiTap12_2.Models;
using PagedList;

namespace BaiTap12_2.Controllers
{
    public class HangsController : Controller
    {
        private fShopDB db = new fShopDB();

        // GET: Hangs
        public ActionResult Index(string sortOrder, string searchString, string currentFiter, int? page)
        {

            //Biến lấy yêu cầu sắp xếp hiện tại
            ViewBag.CurrentSort = sortOrder;


            //Các biến sắp xếp 
            //Tự giải thích:
            //Lần đầu chạy thì sortOrder = null; ViewBag.SapTheoTen = ""; ViewBag.SapTheoGia = "Gia"; và nó sẽ nhảy vào default 
            //Từ những lần sau khi kích vào các link sắp xếp ở phần view index nó sẽ thay đổi theo cái sortOrder vì cái sortOrder cũng thay đổi dựa vào cái ViewBag truyền vào
            ViewBag.SapTheoTen = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.SapTheoGia = sortOrder == "Gia" ? "gia_desc" : "Gia";
            
            //Lấy giá trị của bộ lọc hiện tại
            if(searchString != null)
            {
                page = 1; //Trang đầu tiên
            }
            else
            {
                searchString = currentFiter;
            }
            ViewBag.CurrentFiter = searchString;


            //Lấy danh sách hàng (mình nghĩ hai câu lệnh này có ý nghĩa như nhau)
            //var hangs = db.Hangs.Include(h => h.Nha_CC);
            var hangs = db.Hangs.Select(h => h);

            //Lọc theo tên hàng
            //Nếu nó không null hoặc rỗng thì bắt đầu lọc
            if (!String.IsNullOrEmpty(searchString))
            {
                hangs = hangs.Where(p => p.TenHang.Contains(searchString));
            }


            //Sắp xếp
            switch (sortOrder)
            {
                case "name_desc":
                    hangs = hangs.OrderByDescending(s => s.TenHang);
                    break;
                case "Gia":
                    hangs = hangs.OrderBy(s => s.Gia);
                    break;
                case "gia_desc":
                    hangs = hangs.OrderByDescending(s => s.Gia);
                    break;
                default:
                    hangs = hangs.OrderBy(s => s.TenHang);
                    break;
            }

            int pageSizeFix = 3; //Kích thước trang
            int pageNumber = (page ?? 1);

            return View(hangs.ToPagedList(pageNumber, pageSizeFix));
        }

        // GET: Hangs/Details/5
        public ActionResult Details(string id)
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

        // GET: Hangs/Create
        public ActionResult Create()
        {
            ViewBag.MaNCC = new SelectList(db.Nha_CC, "MaNCC", "TenNCC");
            return View();
        }

        // POST: Hangs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaHang,MaNCC,TenHang,Gia,LuongCo,MoTa,ChietKhau,HinhAnh")] Hang hang)
        {
            if (ModelState.IsValid)
            {
                db.Hangs.Add(hang);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaNCC = new SelectList(db.Nha_CC, "MaNCC", "TenNCC", hang.MaNCC);
            return View(hang);
        }

        // GET: Hangs/Edit/5
        public ActionResult Edit(string id)
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
            ViewBag.MaNCC = new SelectList(db.Nha_CC, "MaNCC", "TenNCC", hang.MaNCC);
            return View(hang);
        }

        // POST: Hangs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaHang,MaNCC,TenHang,Gia,LuongCo,MoTa,ChietKhau,HinhAnh")] Hang hang)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hang).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaNCC = new SelectList(db.Nha_CC, "MaNCC", "TenNCC", hang.MaNCC);
            return View(hang);
        }

        // GET: Hangs/Delete/5
        public ActionResult Delete(string id)
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

        // POST: Hangs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Hang hang = db.Hangs.Find(id);
            db.Hangs.Remove(hang);
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
