using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor_exchange.DAL.Model.DB
{
    public class Course
    {
        public int CourseID { get; set; }
        public int EduationID { get; set; }
        public string CourseTitle { get; set; }
        public string CourseInformation { get; set; }
        public float Rating { get; set; }
        public string Duration { get; set; }
        public byte[] Sertificat { get; set; }
    }
}
