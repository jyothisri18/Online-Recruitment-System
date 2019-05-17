using OnlineRecritmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineRecritmentSystem.Controllers
{
    public class msgController : Controller
    {
        OnlineRecrutimentModel tr = new OnlineRecrutimentModel();
        // GET: msgS
        public ActionResult Index()
        {
            //  return View();
           
            return Content("successfully Approved");
        }
    }
}