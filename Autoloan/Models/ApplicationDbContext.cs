using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Autoloan.Models
{

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        //dbsets
        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<CarInsurance> CarInsurancs { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }

}