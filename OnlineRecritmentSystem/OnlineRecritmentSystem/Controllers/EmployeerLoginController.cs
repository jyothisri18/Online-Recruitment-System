using OnlineRecritmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineRecritmentSystem.Controllers
{
    public class EmployeerLoginController : Controller
    {
        // GET: EmployeerLogin
        public ActionResult EmployeerLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EmployeerLogin(int? UserId, string Password)
        {
            OnlineRecrutimentModel tr = new OnlineRecrutimentModel();
            if (ModelState.IsValid)
            {
                var obj = tr.Firsttimeusers.Where(a => a.UserId == UserId && a.Password.Equals(Password)).FirstOrDefault();
                if (obj != null)
                {
                    Session["UserID"] = obj.UserId.ToString();
                    Session["UserName"] = obj.Name.ToString();
                    return RedirectToAction("ReqApplication");
                    //return Content($"Welcome {obj.Name.ToString()}");
                }
            }
            return View(UserId);
        }

        public ActionResult EmployeerDetails()
        {
            return View();
        }

        public ActionResult ReqApplication()
        {
            OnlineRecrutimentModel db = new OnlineRecrutimentModel();
            var res = db.JobSeekers.ToList();
            return View(res);
        }
        [HttpPost]
        public ActionResult ReqApplication(JobSeeker obj)
        {
            //if(obj.Status== "Accepted")
            //    {
            //    ViewBag.job applied succesfully;
            //    return RedirectToAction("")
            //}
            return View();
        }
    }
}