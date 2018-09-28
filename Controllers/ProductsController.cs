using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMVCApp.Models;

namespace FirstMVCApp.Controllers
{
    public class ProductsController : Controller
    {
        static List<Product> pro = new List<Product>
        {
            new Product{id=1,pname="TV",brand="LG",price=44000},
            new Product{id=2,pname="Phone",brand="Samsung",price=47000},
            new Product{id=3,pname="Washing Machine",brand="LG",price=45000}
        };
        // GET: Products
        public ActionResult Index()
        {
            return View(pro);
        }
        public ActionResult Details(int id)
        {
            return View(pro.SingleOrDefault(x=>x.id==id));
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product p)
        {
            pro.Add(p);
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            return View(pro.SingleOrDefault(x=>x.id==id));
        }
        [HttpPost]
        public ActionResult Edit(Product p)
        {
            for (int i = 0; i < pro.Count; i++)
            {
                if(pro[i].id == p.id)
                {
                    pro[i] = p;
                    break;
                }
            }
            return RedirectToAction("Index");
            return View();
        }
        public ActionResult Delete(int id )
        {
            pro.Remove(pro.SingleOrDefault(x => x.id == id));
            return RedirectToAction("Index");
            return View();
        }

    }
}