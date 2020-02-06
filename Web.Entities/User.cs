using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Web.Entities
{
    public class User : IdentityUser
    {
        public string fullName { get; set; }

        public string phone { get; set; }
        public Gender? gender { get; set; }
        public string address { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int status { get; set; }
        //user type
        public int? userTypeId { get; set; }
        public UserType userType { get; set; }
        // 1 - n subject || null -> if is user
        public int? subjectId { get; set; }
        public Subject subject { get; set; }
    }
}
