using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineRecritmentSystem.Controllers
{
    public class UploadResumeController : Controller
    {
        // GET: UploadResume
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UploadFile()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UploadFile(HttpPostedFileBase file)
        {
            try
            {
                if (file.ContentLength > 0)
                {
                    string _FileName = Path.GetFileName(file.FileName);
                    string _Path = Path.Combine(Server.MapPath("~/UploadedCV"), _FileName);
                    file.SaveAs(_Path);
                }
                ViewBag.Message = "File Uploaded Successfully";
                return View();
            }
            catch
            {
                ViewBag.Message = "File Uploaded Failed";
                return View();
            }
        }
    }
}