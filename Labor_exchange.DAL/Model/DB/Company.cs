using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor_exchange.DAL.Model.DB
{
    public class Company
    {
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public int IndustryID { get; set; }
        public DateTime DateOfFoundation { get; set; }
        public string InformationAboutCompany { get; set; }
        public byte[] CompanyPhoto { get; set; }
        public int ContactID { get; set; }
    }
}
