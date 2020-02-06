using System;
using System.Collections.Generic;
using System.Text;

namespace Web.Models
{
    public class TeacherRegistration
    {
        public int id { get; set; }
        public string subcriber { get; set; }
        public string teacher { get; set; }
        public Time? time { get; set; }
        public int status { get; set; }
    }
}
