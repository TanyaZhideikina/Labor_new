using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor_exchange.DAL.Models.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Applicants> Applicants { get; }
        IRepository<Education> Educations { get; }
        void Save();
    }
}
