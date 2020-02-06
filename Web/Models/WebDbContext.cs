using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

using Web.Models;

namespace Web.Models
{
    
        public class WebDbContext : IdentityDbContext<User>
        {
            public WebDbContext() : base("WebConnection")
            {

            }

            // instance
            public static WebDbContext Create()
            {
                return new WebDbContext();
            }
           
            public DbSet<Subject> Subjects { get; set; }
            public DbSet<TeacherRegistration> TeacherRegistrations { get; set; }
            public DbSet<UserType> UserTypes { get; set; }

        }
    
}
