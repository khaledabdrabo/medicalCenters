using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Medicalcenter.Models
{
    public class SignUp
    {
        public int ID { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string gender { get; set; }
        public string phone { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        
    }
}