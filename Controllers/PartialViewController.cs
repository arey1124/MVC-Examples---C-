using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMVCApp.Models;

namespace FirstMVCApp.Controllers
{
    public class PartialViewController : Controller
    {
        List<Employees> emp = new List<Employees>
        {
            new Employees(1,"Arihant"),
            new Employees(2,"Chayank"),
            new Employees(3,"Prajjwal")
        };
        // GET: PartialView
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult EmployeeDetails()
        {
            return View(emp);
        }
    }

}