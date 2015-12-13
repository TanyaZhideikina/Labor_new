using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor_exchange.DAL.Model.DB
{
    public class Experience
    {
        public int ExperienceID { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public string Duration { get; set; }
    }
}
