using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor_exchange.DAL.Model.DB
{
    public class NewsPhoto
    {
        public int NewsID { get; set; }
        public int NewsPhotoID { get; set; }
        public byte[] Photo { get; set; }
    }
}
