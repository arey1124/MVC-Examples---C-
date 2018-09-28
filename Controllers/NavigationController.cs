using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMVCApp.Models;

namespace FirstMVCApp.Controllers
{
    public class NavigationController : Controller
    {
        // GET: Navigation
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string userName,string password)
        {
            StpDBEntities stpDBEntities = new StpDBEntities();
            var userAuth = stpDBEntities.tblAuthenticates.FirstOrDefault(u => u.userName == userName & u.password == password);
            if (userAuth != null)
            {
                var user = stpDBEntities.tblUsers.FirstOrDefault(u => u.uid == userAuth.uid);
                Session["user"] = user;
                Session["userName"] = userAuth.userName;
                return RedirectToAction("Dashboard");
            }
            return View();
        }
        public ActionResult Dashboard()
        {
            var user = Session["user"] as tblUser;
            ViewBag.name = user.fname.ToString() + " " + user.lname.ToString(); 
            return View();
        }
        public ActionResult Confidential()
        {
            return View();
        }
        public ActionResult Logout()
        {
            return View();
        }
    }
}