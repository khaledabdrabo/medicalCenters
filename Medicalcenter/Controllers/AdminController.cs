using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Medicalcenter.DA;
using Medicalcenter.Models;
namespace Medicalcenter.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        private Context db = new Context();
        //public ActionResult AdminPanel()
        //{
        //    var x = db.MedicalCenters.Count();
        //    var d = db.doctors.Count();
        //    var s = db.Subscribers.Count();
        //    ViewBag.subscribe = s;
        //    ViewBag.doctors = d;
        //    ViewBag.medical = x;
        //    var z = db.Subscribers.SqlQuery("select * from Subscribers ").ToList();
        //    var cv = db.ContactUs.SqlQuery("select * from ContactUs ").ToList();
        //    var xx = db.MedicalCenters.SqlQuery("select * from MedicalCenters ").ToList();
        //    var yy = db.doctors.SqlQuery("select * from doctors ").ToList();
        //    ViewBag.SubscribersList = z;
        //    ViewBag.medicalCenters = xx;
        //    ViewBag.doctorss = yy;
        //    ViewBag.ContactUsUsers = cv;
        //    return View();
        //}

        public ActionResult AdminPanel1()
        {
            
            return View();
        }
        public ActionResult getscribers()
        {
            var z = db.Subscribers.SqlQuery("select * from Subscribers ").ToList();
            ViewBag.SubscribersList = z;
            return View();
        }
        public ActionResult statistics()
        {
            var x = db.MedicalCenters.Count();
            var d = db.doctors.Count();
            var s = db.Subscribers.Count();
            ViewBag.subscribe = s;
            ViewBag.doctors = d;
            ViewBag.medical = x;
            return View();
        }
        public ActionResult contactUs()
        {
            var cv = db.ContactUs.SqlQuery("select * from ContactUs ").ToList();
            ViewBag.ContactUsUsers = cv;
            return View();
        }
        public ActionResult MedicalCenters()
        {
            var xx = db.MedicalCenters.SqlQuery("select * from MedicalCenters ").ToList();
            ViewBag.medicalCenters = xx;
            return View();
        }
        public ActionResult doctors()
        {
            var yy = db.doctors.SqlQuery("select * from doctors ").ToList();
            ViewBag.doctorss = yy;
            return View();
        }
        public ActionResult delete(int id,string n)
        {
            if (n=="S")
            {
                var productrow = db.Subscribers.Find(id);
                db.Subscribers.Remove(productrow);

                db.SaveChanges();
                return RedirectToAction("getscribers");
            }
            else if (n=="M")
            {
                var productrow = db.MedicalCenters.Find(id);
                db.MedicalCenters.Remove(productrow);

                db.SaveChanges();
                return RedirectToAction("medicalCenters");
            }
            else if (n == "C")
            {
                var productrow = db.ContactUs.Find(id);
                db.ContactUs.Remove(productrow);

                db.SaveChanges();
                return RedirectToAction("contactUs");
            }
            else
            {
                var productrow = db.doctors.Find(id);
                db.doctors.Remove(productrow);

                db.SaveChanges();
                return RedirectToAction("doctorData");
            }
           
            return RedirectToAction("AdminPanel1");
        }
        public string update(int id)
        {

            return "done";
        }
        [HttpPost]
        public ActionResult doctorData(doctor d)
        {
            int output;

            if (d.Image==null) {
                 output = db.Database.ExecuteSqlCommand("Update doctors set name={0},doctors.role={1},specialization={2},timeOfWork={3},experience={4},doctors.description={5},saterday={6},sunday={7},tuesday={8},wednesday={9},thruday={10},frayday={11} where ID=" + d.ID, d.name, d.role, d.specialization, d.timeOfWork, d.experience, d.description, d.saterday, d.sunday, d.tuesday, d.wednesday, d.thruday, d.frayday);
            }
            else {
                 output = db.Database.ExecuteSqlCommand("Update doctors set name={0},doctors.role={1},specialization={2},Image={3},timeOfWork={4},experience={5},doctors.description={6},saterday={7},sunday={8},tuesday={9},wednesday={10},thruday={11},frayday={12} where ID=" + d.ID, d.name, d.role, d.specialization, d.Image, d.timeOfWork, d.experience, d.description, d.saterday, d.sunday, d.tuesday, d.wednesday, d.thruday, d.frayday);
            }

               if (output > 0)
            {
                ViewBag.Itemmsg = " updated seccussfully";
            }
            
            


            db.SaveChanges();
           
            return RedirectToAction("doctorData");
        }
        [HttpPost]
        public ActionResult centerData(MedicalCenter d)
        {
            int output;

            if (d.Image==null) {
                 output = db.Database.ExecuteSqlCommand("Update MedicalCenters set Name={0},Email={1},adderess={2},telphone={3},fax={4},discription={5} where ID=" + d.ID, d.Name, d.Email, d.adderess, d.telphone, d.fax, d.discription);
            }
            else
            {
                 output = db.Database.ExecuteSqlCommand("Update MedicalCenters set Name={0},Email={1},adderess={2},telphone={3},fax={4},discription={5},Image={6} where ID=" + d.ID, d.Name, d.Email, d.adderess, d.telphone, d.fax, d.discription, d.Image);

            }

                 if (output > 0)
            {
                ViewBag.Itemmsg = " updated seccussfully";
            }




            db.SaveChanges();
            
            return RedirectToAction("medicalCenters");
        }
        [HttpPost]
        public ActionResult AddCenter(MedicalCenter d)
        {
            int output = db.Database.ExecuteSqlCommand("insert into MedicalCenters values( {0},{1},{2},{3},{4},{5},{6})", d.Name, d.Email, d.adderess, d.telphone, d.fax, d.discription, d.Image);
            if (output > 0)
            {
                ViewBag.Itemmsg = " updated seccussfully";
            }




            db.SaveChanges();

            return RedirectToAction("medicalCenters");
           
        }
        [HttpPost]
        public ActionResult AddDoctors(doctor d)
        {
            int output = db.Database.ExecuteSqlCommand("insert into doctors values( {0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13})", d.experience, d.description, d.saterday, d.sunday, d.tuesday, d.wednesday, d.thruday,d.frayday,d.timeOfWork,d.MedicalCenters,d.name,d.role,d.specialization,d.Image);
            if (output > 0)
            {
                ViewBag.Itemmsg = " added seccussfully";
            }




            db.SaveChanges();

            return RedirectToAction("doctorData");

        }
    }
}