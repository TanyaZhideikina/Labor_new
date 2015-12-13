using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor_exchange.DAL.Model.DB
{
    public class Applicant
    {
        public int ApplicantID { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public  byte[] Photo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int ContactID { get; set; }
        public int EducationID { get; set; }
        public string OtherInformation { get; set; }
    }
}
