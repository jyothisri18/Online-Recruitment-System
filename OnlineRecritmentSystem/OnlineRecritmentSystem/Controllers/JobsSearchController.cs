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
    public class JobsSearchController : Controller
    {
        private OnlineRecrutimentModel db = new OnlineRecrutimentModel();

        // GET: JobsSearch
        public ActionResult Index()
        {
            return View(db.Jobs.ToList());
        }

        // GET: JobsSearch/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Job job = db.Jobs.Find(id);
            if (job == null)
            {
                return HttpNotFound();
            }
            return View(job);
        }

        // GET: JobsSearch/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: JobsSearch/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Jobid,Designation,Company,ComapnyName,Salary")] Job job)
        {
            if (ModelState.IsValid)
            {
                db.Jobs.Add(job);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(job);
        }

        // GET: JobsSearch/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Job job = db.Jobs.Find(id);
            if (job == null)
            {
                return HttpNotFound();
            }
            return View(job);
        }

        // POST: JobsSearch/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Jobid,Designation,Company,ComapnyName,Salary")] Job job)
        {
            if (ModelState.IsValid)
            {
                db.Entry(job).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(job);
        }

        // GET: JobsSearch/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Job job = db.Jobs.Find(id);
            if (job == null)
            {
                return HttpNotFound();
            }
            return View(job);
        }

        // POST: JobsSearch/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Job job = db.Jobs.Find(id);
            db.Jobs.Remove(job);
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
        [HttpPost]
        public ActionResult Index(string Company, string skill, int id)
        {
            OnlineRecrutimentModel onm = new OnlineRecrutimentModel();
            var query = from b in onm.Jobs.ToList()
                        where b.ComapnyName == Company || b.Designation == skill || b.Jobid == id
                        select b;
            return View(query);
        }
        //[HttpPost]
        //public ActionResult Index(int id, string skill, string Company)
        //{

        //    if (Session["id"] != null && Session["skill"] != null && Session["Company"].ToString() == "Index")
        //    {
        //        if (id == 0)
        //        {
        //            OnlineRecrutimentModel onm = new OnlineRecrutimentModel();
        //            var query = from b in onm.Jobs.ToList()
        //                where  b.Jobid == id 
        //                select b;
        //            return View(query);
        //        }
        //        else if(skill==null)
        //        {
        //            OnlineRecrutimentModel onm = new OnlineRecrutimentModel();
        //            var query = from b in onm.Jobs.ToList()
        //                        where b.Designation == skill
        //                        select b;
        //            return View(query);
        //        }
        //        else if(Company==null)
        //        {
        //            OnlineRecrutimentModel onm = new OnlineRecrutimentModel();
        //            var query = from b in onm.Jobs.ToList()
        //                        where b.Company == Company
        //                        select b;
        //            return View(query);
        //        }
        //else
        //{
        //    return RedirectToAction("", " ");
        //}
        public ActionResult Capgemini()
        {
            return View();
        }
        public ActionResult Tcs()
        {
            return View();
        }
        public ActionResult Hcl()
        {
            return View();
        }
        public ActionResult Wipro()
        {
            return View();
        }

    }
        }
    
