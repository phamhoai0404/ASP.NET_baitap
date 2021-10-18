using BaiTap8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTap8.Controllers
{
    public class ValidationController : Controller
    {
        // GET: Validation

        //[ValidateInput(false)]
        public ActionResult Index(NhanVien nv)
        {
            if (ModelState.IsValid)
            {
                ModelState.AddModelError("", "Chúc mừng bạn đã nhập đúng! ");
            }
            return View("Index");
        }
    }
}