using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor_exchange.DAL.Model.DB
{
    public class CompanySertification
    {
       public int SertificationID { get; set; }
       public int CompanyID { get; set; }
       public byte[] PhotoOfSertificat { get; set; }
       public string InfoAboutSertificat { get; set; }
    }
}
