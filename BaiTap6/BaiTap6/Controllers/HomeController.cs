﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTap6.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LeftSidebar()
        {
            return View();
        }
        public ActionResult RightSidebar()
        {
            return View();
        }
        public ActionResult NoSidebar()
        {
            return View();
        }
    }
}