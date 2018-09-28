using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCApp.Controllers
{
    public class MobileController : Controller
    {
        // GET: Mobile
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Sales()
        {
            return View();
        }
        public ActionResult Services()
        {
            return View();
        }
    }
}