using BaiTap8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTap8.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        
        [HttpGet]
        public ActionResult RegisterForm()
        {
            //Tạo danh sách chọn cho DropDownList "City" trong view RegisterForm
            List<string> Citiessss = new List<string>
            {
                "Hà Nội", "Hải Phòng", "Hải Dương", "Quảng Ninh", "Nam Định", "Thái Bình"
            };
            ViewBag.Cities = Citiessss;
            return View();
        }

        [HttpPost]
        public ActionResult Register(Member mem)
        {
            var f = mem.ImageFile;
            if(f != null && f.ContentLength > 0)
            {
                //Use Namespace called: System.IO
                string FileName = System.IO.Path.GetFileName(f.FileName);

                //Lấy tên file upload
                string UploadPath = Server.MapPath("~/UserImage/" + FileName);

                //Copy và lưu file vào server
                f.SaveAs(UploadPath);

                //Lấy đường dẫn của file upload
                mem.ImagePath = "~/UserImage/" + FileName;
            }
            return View(mem);
        }
        
    }
}