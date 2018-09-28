using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FirstMVCApp.Models;

namespace FirstMVCApp.Controllers
{
    public class tblAuthenticatesController : Controller
    {
        private StpDBEntities db = new StpDBEntities();

        // GET: tblAuthenticates
        public ActionResult Index()
        {
            var tblAuthenticates = db.tblAuthenticates.Include(t => t.tblUser);
            return View(tblAuthenticates.ToList());
        }

        // GET: tblAuthenticates/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblAuthenticate tblAuthenticate = db.tblAuthenticates.Find(id);
            if (tblAuthenticate == null)
            {
                return HttpNotFound();
            }
            return View(tblAuthenticate);
        }

        // GET: tblAuthenticates/Create
        public ActionResult Create()
        {
            ViewBag.uid = new SelectList(db.tblUsers, "uid", "fname");
            return View();
        }

        // POST: tblAuthenticates/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,uid,userName,password,dateAdded")] tblAuthenticate tblAuthenticate)
        {
            if (ModelState.IsValid)
            {
                db.tblAuthenticates.Add(tblAuthenticate);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.uid = new SelectList(db.tblUsers, "uid", "fname", tblAuthenticate.uid);
            return View(tblAuthenticate);
        }

        // GET: tblAuthenticates/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblAuthenticate tblAuthenticate = db.tblAuthenticates.Find(id);
            if (tblAuthenticate == null)
            {
                return HttpNotFound();
            }
            ViewBag.uid = new SelectList(db.tblUsers, "uid", "fname", tblAuthenticate.uid);
            return View(tblAuthenticate);
        }

        // POST: tblAuthenticates/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,uid,userName,password,dateAdded")] tblAuthenticate tblAuthenticate)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblAuthenticate).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.uid = new SelectList(db.tblUsers, "uid", "fname", tblAuthenticate.uid);
            return View(tblAuthenticate);
        }

        // GET: tblAuthenticates/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblAuthenticate tblAuthenticate = db.tblAuthenticates.Find(id);
            if (tblAuthenticate == null)
            {
                return HttpNotFound();
            }
            return View(tblAuthenticate);
        }

        // POST: tblAuthenticates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblAuthenticate tblAuthenticate = db.tblAuthenticates.Find(id);
            db.tblAuthenticates.Remove(tblAuthenticate);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
