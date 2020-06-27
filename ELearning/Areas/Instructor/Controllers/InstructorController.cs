using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ELearning.DAL;
using ELearning.Models;

namespace ELearning.Areas.Instructor.Controllers
{
    public class InstructorController : Controller
    {
        UserContext db = new UserContext();


        [HttpPost]
        public ActionResult LogOff()
        {
            Session.RemoveAll();
            Session.Abandon();
            Session.Clear();
            AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            //return RedirectToAction("UserCP", "Dashboard", new { area = "Admin" });
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }





        // GET: Instructor/Instructor
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CourseCategory()
        {
            return View();
        }

        [HttpPost]

        public ActionResult CourseCategory(HttpPostedFileBase CourseImage, Int64 CourseCategoryID=0, string CourseName=null, string Description=null, string Duration=null, float Price=0)
        {
            string userid = User.Identity.GetUserId();
            string Status = "";

            string productimg = null;
            productimg = "UploadedData/" + CourseImage.FileName;

            CourseCategory cc = new Models.CourseCategory();

            var Exist = db.CourseCategory.Where(s => s.CourseCategoryID == CourseCategoryID).FirstOrDefault();

            if (Exist == null)
            {
                cc.CourseImage = productimg;
                cc.CourseName = CourseName;
                cc.CreatedOn = DateTime.Now;
                cc.Description = Description;
                cc.Duration = Duration;
                cc.InstructorID = userid;
                cc.Price = Price;

                db.CourseCategory.Add(cc);
                int i = db.SaveChanges();

                Status = "Succeeded";
                string path = Server.MapPath("~/UploadedData/");

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                CourseImage.SaveAs(path + CourseImage.FileName);

            }
            else
            {
                Exist.CourseImage = productimg;
                Exist.CourseName = CourseName;
                Exist.CreatedOn = DateTime.Now;
                Exist.Description = Description;
                Exist.Duration = Duration;
                Exist.InstructorID = userid;
                Exist.Price = Price;
                Exist.CourseCategoryID = CourseCategoryID;

                db.SaveChanges();

                Status = "Succeeded";
                string path = Server.MapPath("~/UploadedImage/");

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                CourseImage.SaveAs(path + CourseImage.FileName);
            }

            TempData["Example"] = Status;
            return RedirectToAction("CourseCategory", "Instructor", new { area = "Instructor" });

        }


        public ActionResult AllCourseCategory()
        {
            ViewData["CourseCategory"] = db.CourseCategory.ToList();
            return View();
        }

        public ActionResult DeleteCourseCategory(Int64 CourseCategoryID=0)
        {
            string Status = "NA";

            var StatusExist = db.CourseCategory.Find(CourseCategoryID);
            if (StatusExist != null)
            {

                db.CourseCategory.Remove(StatusExist);
                int result = db.SaveChanges();
                if (result == 1)
                    Status = "Deleted";
                else

                    Status = "Unsucceeded";
            }
            else
            {

                Status = "Unsucceeded";
            }
            TempData["example"] = Status;
            return RedirectToAction("AllCourseCategory", "Instructor", new { area = "Instructor" });
        }
    }
}



