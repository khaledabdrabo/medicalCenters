using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Medicalcenter.Models
{
    public class MedicalCenter
    {
        public MedicalCenter()
        {
            this.doctors = new HashSet<doctor>();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string adderess { get; set; }
        public string telphone { get; set; }
        public string fax { get; set; }
        public string discription { get; set; }
        public string Image { get; set; }
        public virtual ICollection<doctor> doctors { get; set; }//علشان اربط
    }
}