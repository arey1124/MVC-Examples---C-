using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCApp.Controllers
{
    public class Products
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }

        public List<Products> details = new List<Products>();

        public Products()
        {

        }

        public Products(int id,string name,int price,int quantity)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public List<Products> getProducts()
        {
            details.Add(new Products(id = 1 , name = "Apple" , price = 20 , quantity = 5) );
            details.Add(new Products(id = 2, name = "Pineapple", price = 50, quantity = 7));
            return details;
        }
    }
    public class HomeController : Controller
    {

        static Products p = new Products();
        static List<Products> pro = p.getProducts();
        // GET: Home
        public ActionResult Index()
        {
            ViewData["name"] = "Arihant";
            ViewBag.names = new string[]{"Arihant" ,"Chayank","Prajjwal" };
            ViewBag.fruits = new List<string> { "Apple", "Mango", "Orange" };
            ViewBag.products = pro;
            return View();
        }

        [HttpPost]
        public ActionResult Index(string ename)
        {
            ViewData["name"] = "Arihant";
            ViewBag.names = new string[] { "Arihant", "Chayank", "Prajjwal" };
            ViewBag.fruits = new List<string> { "Apple", "Mango", "Orange" };
            ViewBag.products = pro;
            ViewBag.msg = "Welcome Back " + ename;
            return View();
        }
        public ActionResult Details(int id)
        {
            ViewBag.product = pro.FirstOrDefault(u => u.id == id);
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(int id1, string name1 , int price1 , int quantity1)
        {
            pro.Add(new Products { id = id1, name = name1, price = price1, quantity = quantity1 });
            return RedirectToAction("Index");
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Facilities()
        {
            return View();
        }
    }
}