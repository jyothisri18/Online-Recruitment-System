using OnlineRecritmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace OnlineRecritmentSystem.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(int? UserId, string Password)
        {
            OnlineRecrutimentModel tr = new OnlineRecrutimentModel();
            if (ModelState.IsValid)
            {
                var obj = tr.Firsttimeusers.Where(a => a.UserId == UserId && a.Password.Equals(Password)).FirstOrDefault();
                if (obj != null)
                {
                    Session["UserID"] = obj.UserId.ToString();
                    Session["Password"] = obj.Password.ToString();
                    //return RedirectToAction("Index","JobsSearch");
                    return RedirectToAction("Index","MainContextSection");
                    //return Content($"Welcome {obj.Name.ToString()}");
                }
            }
            return View(UserId);
        }
        public ActionResult LogOut()
        {
            Session.Clear();
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}