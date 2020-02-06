using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using Web.Entities;

namespace Web.Data
{
    
        public class WebDbContext : DbContext
        {
            public WebDbContext() : base("WebConnection")
            {

            }

            // instance
            public static WebDbContext Create()
            {
                return new WebDbContext();
            }
            public DbSet<User> Users { get; set; }
            public DbSet<Subject> Subjects { get; set; }
            public DbSet<TeacherRegistration> TeacherRegistrations { get; set; }
            public DbSet<UserType> UserTypes { get; set; }

        }
    
}
