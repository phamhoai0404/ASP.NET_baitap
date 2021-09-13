using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTap1.Controllers
{
    public class ViDuController : Controller
    {
        // GET: ViDu
        public ActionResult Index()
        {
            return View();
        }

        public String Welcome()
        {
            return "Đây là Welcome nhá! ";
        }

        public String Welcome2(string name, int numTimes = 1)
        {
            return HttpUtility.HtmlEncode("Xin chào " + name+ ", số lần: " + numTimes);
        }
        public String Welcome3(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Xin chào " + name + ", ID: " + ID);
        }


    }
}