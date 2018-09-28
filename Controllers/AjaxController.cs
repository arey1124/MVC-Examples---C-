using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMVCApp.Models;

namespace FirstMVCApp.Controllers
{
    public class AjaxController : Controller
    {
        List<People> people;

        public List<People> GetPeople()
        {
            people = new List<People>()
            {
                new People(){Pid=1001,PName="Kiran",Gender="Male",Age=33},
                new People(){Pid=1002,PName="Sameera",Gender="Female",Age=23},
                new People(){Pid=1003,PName="Sarika",Gender="Female",Age=23},
                new People(){Pid=1004,PName="Swathi",Gender="Female",Age=31},
                new People(){Pid=1005,PName="Ashok",Gender="Male",Age=21},
                new People(){Pid=1006,PName="Suresh",Gender="Male",Age=25}
            };
            return people;
        }

        // GET: Ajax
        public ActionResult Index()
        {
            return View();
        }
        public string GetServerTime()
        {
            return DateTime.Now.ToLongTimeString();
        }
        public PartialViewResult AllPeople()
        {
            people = GetPeople();
            return PartialView("_AllPeople", people);
        }
        public PartialViewResult MalePeople()
        {
            people = GetPeople().Where(x => x.Gender == "Male").ToList();
            return PartialView("_AllPeople", people);
        }
        public PartialViewResult FemalePeople()
        {
            people = GetPeople().Where(x => x.Gender == "Female").ToList();
            return PartialView("_AllPeople", people);
        }

    }
}