﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore20190217a.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "关于本站-Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "联系页面-Your contact page.";

            return View();
        }
    }
}