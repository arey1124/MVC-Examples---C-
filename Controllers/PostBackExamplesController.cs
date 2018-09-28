using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCApp.Controllers
{
    public class PostBackExamplesController : Controller
    {
        // GET: PostBackExamples
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ex2()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ex2(string num1,string num2 , string b1)
        {
            if (b1 == "Add")
            {
                ViewBag.result = Convert.ToInt32(num1) + Convert.ToInt32(num2);
            }
            else
            {
                ViewBag.result = Convert.ToInt32(num1) - Convert.ToInt32(num2);
            }
            
            return View();
        }
        public ActionResult Ex4()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ex4(string name, string gender , string cb,string[] hobb)
        {
            if (cb == "true")
            { 
                ViewBag.msg = "Welcome , " + gender + "  " + name + "  , Hobbies are :  ";
                for (int i = 0; i < hobb.Length; i++)
                {
                    if (hobb[i] != "false")
                    {
                        ViewBag.msg += hobb[i]+" ";
                    } 
                }
            }
            else
            {
                ViewBag.msg = "Please accept Terms & Services";
            }
            return View();
        }
        public ActionResult Ex5()
        {
            List<string> operations = new List<string> { "Addition" , "Subtraction" , "Multiply" , "Divide" };
            TempData["operations"] = operations;
            return View();
        }
        [HttpPost]
        public ActionResult Ex5(string op)
        {
            ViewBag.msg = op;
            return View();
        }
        public ActionResult Ex6()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ex6(string b1)
        {
            if (b1 == "ex1")
            {
                return RedirectToAction(b1);
            }
            else if( b1 == "ex2")
            {
                return RedirectToAction(b1);
            }
            return View();
        }
    }
}