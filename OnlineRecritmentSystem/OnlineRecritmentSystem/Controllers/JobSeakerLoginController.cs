using OnlineRecritmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineRecritmentSystem.Controllers
{
    public class JobSeakerLoginController : Controller
    {
        // GET: JobSeakerLogin
        public ActionResult JobSeakerLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult JobSeakerLogin(int? UserId, string Password)
        {
            OnlineRecrutimentModel tr = new OnlineRecrutimentModel();
            if (ModelState.IsValid)
            {
                var obj = tr.Firsttimeusers.Where(a => a.UserId == UserId && a.Password.Equals(Password)).FirstOrDefault();
                if (obj != null)
                {
                    Session["UserID"] = obj.UserId.ToString();
                    Session["Password"] = obj.Password.ToString();
                    return RedirectToAction("Index", "JobSeekers");
                    //return Content($"Welcome {obj.Password.ToString()}");
                }
            }
            return View(UserId);
        }
    }
}