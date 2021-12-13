using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTap15.Areas.Admin.Controllers
{
    public class MainBoardController : Controller
    {
        // GET: Admin/DieuKhien
        public ActionResult Index()
        {
            if(Session["idUser"] != null)
            {
                return View();
            }
            else
            {
                return Redirect("/Admin/Home/Index");
            }
        }
    }
}