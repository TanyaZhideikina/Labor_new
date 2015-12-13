using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor_exchange.DAL.Model.DB
{
    public class HigherEducation
    {
        public int HigherEducationID { get; set; }
        public int EducationID { get; set; }
        public string UniversityCollage { get; set; }
        public string Degree { get; set; }
        public string Department { get; set; }
        public string Faculty { get; set; }
        public string Specialization { get; set; }
        public DateTime YearOfGraduation { get; set; }
    }
}
