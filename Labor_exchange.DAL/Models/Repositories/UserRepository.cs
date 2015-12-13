using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labor_exchange.DAL.Models.EF;
using Labor_exchange.DAL.Models.Interfaces;
using System.Data.Entity;

namespace Labor_exchange.DAL.Models.Repositories
{
    public class PhoneRepository : IRepository<Applicants>
    {
        private UserContext db;

        public PhoneRepository(UserContext context)
        {
            this.db = context;
        }

        public IEnumerable<Applicants> GetAll()
        {
            return db.Applicants;
        }

        public Applicants Get(int id)
        {
            return db.Applicants.Find(id);
        }

        public void Create(Applicants applicants)
        {
            db.Applicants.Add(applicants);
        }

        public void Update(Applicants applicants)
        {
            db.Entry(applicants).State = EntityState.Modified;
        }

        public IEnumerable<Applicants> Find(Func<Applicants, Boolean> predicate)
        {
            return db.Applicants.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Applicants applicants = db.Applicants.Find(id);
            if (applicants != null)
                db.Applicants.Remove(applicants);
        }
    }
}
