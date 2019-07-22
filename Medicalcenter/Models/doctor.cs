using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Medicalcenter.Models
{
    public class doctor
    {
        public String specialization { get; set; }
        public int ID { get; set; }
        public string name { get; set; }
        public string role { get; set; }
        public double experience { get; set; }
        public string description { get; set; }
        public bool saterday { get; set; }
        public bool sunday { get; set; }
        public bool tuesday { get; set; }
        public bool wednesday { get; set; }
        public bool thruday { get; set; }
        public bool frayday { get; set; }
        public string timeOfWork { get; set; }
        public string Image { get; set; }
        public virtual MedicalCenter MedicalCenters { get; set; }//علشان اربط

    }
}