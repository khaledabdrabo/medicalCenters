using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Medicalcenter.Models;
namespace Medicalcenter.DA
{
    public class Context:DbContext
    {
        public Context() : base("name=DefaultConnection")
        {

        }
        public DbSet<ContactU> ContactUs { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }
        public DbSet<MedicalCenter> MedicalCenters { get; set; }
        public DbSet<doctor> doctors { get; set; }
        public DbSet<booking> bookings { get; set; }
        public DbSet<SignUp> SignUps { get; set; }
        
    }
}
