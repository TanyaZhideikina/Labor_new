using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor_exchange.DAL.Model.DB
{
    public class CV
    {
        public int CV_ID { get; set; }
        public int ApplicantID { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Skills { get; set; }
        public int IndustryID { get; set; }
        public byte[] Photo { get; set; }
        public int AdressID { get; set; }
        public DateTime TimeOfWork { get; set; }
        public string DurationOfWork { get; set; }
        public string Position { get; set; }
        public float Salary { get; set; }
        public DateTime Date { get; set; }
        public bool Active { get; set; }
    }
}
