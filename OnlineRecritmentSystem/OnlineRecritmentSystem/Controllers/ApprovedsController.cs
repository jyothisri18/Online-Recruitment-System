using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OnlineRecritmentSystem.Models;

namespace OnlineRecritmentSystem.Controllers
{
    public class ApprovedsController : Controller
    {
        private OnlineRecrutimentModel db = new OnlineRecrutimentModel();

        // GET: Approveds
        public ActionResult Index()
        {
            return View(db.Approveds.ToList());
        }

        // GET: Approveds/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Approved approved = db.Approveds.Find(id);
            if (approved == null)
            {
                return HttpNotFound();
            }
            return View(approved);
        }

        // GET: Approveds/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Approveds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name,status")] Approved approved)
        {
            if (ModelState.IsValid)
            {
                db.Approveds.Add(approved);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(approved);
        }

        // GET: Approveds/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Approved approved = db.Approveds.Find(id);
            if (approved == null)
            {
                return HttpNotFound();
            }
            return View(approved);
        }

        // POST: Approveds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Name,status")] Approved approved)
        {
            if (ModelState.IsValid)
            {
                db.Entry(approved).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(approved);
        }

        // GET: Approveds/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Approved approved = db.Approveds.Find(id);
            if (approved == null)
            {
                return HttpNotFound();
            }
            return View(approved);
        }

        // POST: Approveds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Approved approved = db.Approveds.Find(id);
            db.Approveds.Remove(approved);
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
