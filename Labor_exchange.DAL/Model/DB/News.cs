using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor_exchange.DAL.Model.DB
{
    public class News
    {
        public int NewsID { get; set; }
        public string NewsTItle { get; set; }
        public string NewsText { get; set; }
        public DateTime Date { get; set; }
        public int AuthorID { get; set; }
        public int AdminID { get; set; }

    }
}
