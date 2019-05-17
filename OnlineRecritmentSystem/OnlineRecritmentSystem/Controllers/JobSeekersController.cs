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
    public class JobSeekersController : Controller
    {
        private OnlineRecrutimentModel db = new OnlineRecrutimentModel();

        // GET: JobSeekers
        public ActionResult Index()
        {
            return View(db.JobSeekers.ToList());
        }

        //[HttpPost]
        //public ActionResult Index(JobSeeker jsk)
        //{
        //    OnlineRecrutimentModel onm = new OnlineRecrutimentModel();
        //    return View();




        //    //var query = from b in onm.JobSeekers.ToList()
        //    //            where b.Experience == div || b.Skills==skill || b.PreferredJobLocation == loc || b.Position == position 
        //    //            select b;
        //    //return View(query);
        //}
        // GET: JobSeekers
        //public ActionResult Position()
        //{
        //    return View(db.JobSeekers.ToList());
        //}

        //[HttpPost]
        //public ActionResult Position(string div, string Position)
        //{
        //    OnlineRecrutimentModel onm = new OnlineRecrutimentModel();
        //    var query = from b in onm.JobSeekers.ToList()
        //                where b.Position == div 
        //                select b;
        //    return View(query);
        //}

        //[HttpPost]
        //public ActionResult Index()
        //{
        //    OnlineRecrutimentModel onm = new OnlineRecrutimentModel();
        //    var query = from b in onm.JobSeekers.ToList()
        //                where b.Experience == div
        //                select b;
        //    return View(query);
        //}
        //// GET: JobSeekers/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobSeeker jobSeeker = db.JobSeekers.Find(id);
            if (jobSeeker == null)
            {
                return HttpNotFound();
            }
            return View(jobSeeker);
        }

        // GET: JobSeekers/Create
        public ActionResult Create()
        {
            return View();
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name,Password,Emailid,MobileNo,Location,photo,Position,Experience,PreferredJobLocation,Skills,Dateofapplication,Resume")] JobSeeker jobSeeker)
        {
            if (ModelState.IsValid)
            {
                jobSeeker.Status = "Requested";
                db.JobSeekers.Add(jobSeeker);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(jobSeeker);
        }

        // GET: JobSeekers/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobSeeker jobSeeker = db.JobSeekers.Find(id);
            if (jobSeeker == null)
            {
                return HttpNotFound();
            }
            return View(jobSeeker);
        }

        // POST: JobSeekers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Name,Password,Emailid,MobileNo,Location,photo,Position,Experience,PreferredJobLocation,Skills,Dateofapplication,Resume")] JobSeeker jobSeeker)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jobSeeker).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(jobSeeker);
        }

    
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        //// GET: JobSeekers/Details/5
        public ActionResult Search()
        {
            return RedirectToAction("Capgemini", "JobsSearch");

        }
       

    }
}
