using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor_exchange.DAL.Model.DB
{
    public class Vacansy
    {
        public int VacansyID { get; set; }
        public int CompanyID { get; set; }
        public string Position { get; set; }
        public int DurationOfWork { get; set; }
        public DateTime TimeOfWork { get; set; }
        public DateTime StartOfWork { get; set; }
        public float Salary { get; set; }
        public string InformationAboutWork { get; set; }
        public string ContactID { get; set; }
        public DateTime DateOfCreating { get; set; }
        public bool Active { get; set; }
        public int PriorityID { get; set; }
    }
}
