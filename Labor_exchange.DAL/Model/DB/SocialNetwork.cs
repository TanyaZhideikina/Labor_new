using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor_exchange.DAL.Model.DB
{
    public class SocialNetwork
    {
        public int SocialNetworkID { get; set; }
        public int ContactID { get; set; }
        public string TitleOfSocialNetwork { get; set; }
        public string UserName { get; set; }
        public string URL { get; set; }
    }
}
