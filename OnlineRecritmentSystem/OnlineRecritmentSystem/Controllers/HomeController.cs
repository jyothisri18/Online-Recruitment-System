using OnlineRecritmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineRecritmentSystem.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Register()
        {
            return View();
        }



        [HttpPost]
        public ActionResult Register(Firsttimeuser newuser)
        {
            OnlineRecrutimentModel tr = new OnlineRecrutimentModel();
            if (ModelState.IsValid)
            {
                Firsttimeuser obj = new Firsttimeuser()
                {
                    UserId = newuser.UserId,
                    Name = newuser.Name,
                    MobileNo = newuser.MobileNo,
                    TelNo = newuser.TelNo,
                    Address = newuser.Address,
                    Emailid = newuser.Emailid,
                    Password = newuser.Password
                };
                tr.Firsttimeusers.Add(obj);
                tr.SaveChanges();
                return RedirectToAction("Login", "Login");
            }
            return View(newuser);
        }

    }
}