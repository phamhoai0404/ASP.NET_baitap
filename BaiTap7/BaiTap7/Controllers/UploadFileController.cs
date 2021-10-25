using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTap7.Controllers
{
    public class UploadFileController : Controller
    {
        // GET: UploadFile
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Upload()
        {
            //Lấy file được upload bởi client có name được chỉ rõ
            var file = Request.Files["documentsss"];
            if(file != null && file.ContentLength > 0)
            {
                //Gắn tên file với đường dẫn của nơi lưu file
                var path = Server.MapPath("~/FileUpload/" + file.FileName);
                file.SaveAs(path);

                ViewBag.FileName = file.FileName;
                ViewBag.FielTypessss = file.ContentType;
                ViewBag.FileSizessssss = file.ContentLength;
            }

            return View("Index");

            
        }
    }
}