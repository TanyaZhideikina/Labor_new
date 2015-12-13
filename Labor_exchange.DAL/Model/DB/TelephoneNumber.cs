using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor_exchange.DAL.Model.DB
{
    public class TelephoneNumber
    {
        public int TelphoneNumberID { get; set; }
        public int ContactID { get; set; }
        public int MobileTelephone { get; set; }
        public int HomeTelephone { get; set; }     
    }
}
