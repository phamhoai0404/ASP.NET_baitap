using BaiTap9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTap9.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        public ActionResult Index()
        {
            return View();
        }

        // GET: Member/Details/5
        public ActionResult Details(Member me)
        {
            if(me.ImagePath == null)
            {
                
            }
            return View(me);
        }

        // GET: Member/Create
        [HttpGet]
        public ActionResult Create()
        {
            List<string> Address = new List<string>
                {
                    "Hà Nội", "Hải Phòng", "Nam Định", "Thái Bình", "Huế", "Đà Nẵng", "TP Hồ Chí Minh", "Phạm Thị Hoài"
                };
            ViewBag.Address = Address;
            
            return View();
        }

        // POST: Member/Create
        [HttpPost]
        public ActionResult Create(Member mem)
        {
            try
            {
                var file = Request.Files["ImageFilesss"];
                
                if (file != null && file.ContentLength > 0)
                {
                    //Gắn tên file với đường dẫn của nơi lưu file
                    var path = Server.MapPath("~/wwwroot/images/" + file.FileName);
                    file.SaveAs(path);

                    mem.ImagePath = "~/wwwroot/images/" + file.FileName;
                }
                else
                {
                    mem.ImagePath = "~/wwwroot/images/noImage.png";
                }

                return RedirectToAction("Details", mem);
            }
            catch
            {
                return View();
            }
        }

        // GET: Member/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Member/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Member/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Member/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
