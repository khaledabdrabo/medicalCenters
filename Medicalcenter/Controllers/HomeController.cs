using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Medicalcenter.DA;
using Medicalcenter.Models;
namespace Medicalcenter.Controllers
{
    public class HomeController : Controller
    {
        private Context db = new Context();

        public string Index()
        {

            var x = db.ContactUs.Create();
            x.Email = "k@gamil.com";
            x.subject = "kk";
            x.inquiry = "lklklkl";
            db.ContactUs.Add(x);
            db.SaveChanges();
            return "done";
        }
        public ActionResult home()
        {
            return View();
        }
        public ActionResult centerProfile(int ID)
        {
            var x = db.MedicalCenters.SqlQuery("select * from MedicalCenters where ID="+ID).ToList();
            var y = db.doctors.SqlQuery("select * from doctors where MedicalCenters_ID="+ID).ToList();
            //ViewBag.Message = "Your application description page.";
            ViewBag.doctors = y;

            return View(x[0]);
            //return View("c",y);
        }

        public ActionResult getCenters()
        {
            var x = db.MedicalCenters.SqlQuery("select * from MedicalCenters ").ToList();

            //ViewBag.Message = "Your application description page.";

            
            return View(x);
        }

        public ActionResult ContactUS(ContactU c)
        {
            var x = db.ContactUs.Create();
            x.Email = c.Email;
            x.subject = c.subject;
            x.inquiry = c.inquiry;
            db.ContactUs.Add(x);
            db.SaveChanges();

            ViewBag.msg = "Done";
            return RedirectToAction("home");
        }

        [HttpPost]
        public ActionResult Booking(booking b)
        {
            var x = db.bookings.Create();
            x.name = b.name;
            x.email = b.email;
            x.tephone = b.tephone;
            x.date = b.date.ToString() ;
            x.message = b.message;
            db.bookings.Add(x);
            db.SaveChanges();

            ViewBag.msg1 = "Done";
           return RedirectToAction("home");
           //return View("y",x);
        }
        public ActionResult getdocprofile(int ID)
        {
            var x = db.doctors.SqlQuery("select * from doctors where ID=" + ID).ToList();
            return View(x[0]);
        }
        public ActionResult subscribe(Subscriber s)
        {
            var x = db.Subscribers.Create();
            x.Email = s.Email;
            
            db.Subscribers.Add(x);
            db.SaveChanges();

            //ViewBag.msg = "Done";
            return RedirectToAction("home");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult search(string name)
        {
           
          
            if (name== "مركز الاورام")
            {
            
                return RedirectToAction("centerProfile",new { ID=3});
            }
            else if (name == "مركز الامل") { return RedirectToAction("centerProfile", new { ID = 2 }); }
            else if (name == "مركز الشفاء") { return RedirectToAction("centerProfile", new { ID = 1 }); }
            else if (name == "مركز الخصوبة") { return RedirectToAction("centerProfile", new { ID = 4 }); }
            else if (name == "مركز الكلى") { return RedirectToAction("centerProfile", new { ID = 5 }); }
            else { 
            return RedirectToAction("home") ;
            }
        }
    }
}