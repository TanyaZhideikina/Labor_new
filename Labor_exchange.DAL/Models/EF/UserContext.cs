using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Labor_exchange.DAL.Models;


namespace Labor_exchange.DAL.Models.EF
{
   public class UserContext : DbContext
    {
        public DbSet<Applicants>  Applicants{ get; set; }
        public DbSet<Education> Educations { get; set; }

        static UserContext()
        {
            Database.SetInitializer<UserContext>(new UserDbInitializer());
        }
        public UserContext(string connectionString)
            : base(connectionString)
        {
        }
    }
    public class UserDbInitializer : DropCreateDatabaseIfModelChanges<UserContext>
    {
        protected override void Seed(UserContext db)
        {
            db.Applicants.Add(new Applicants
            {
                IdApplicant = 000001,
                Name = "Tania",
                SecondName = "Zhidejkina",
                Patronymic = "Anatoliivna",
                Age = 18,
                DateOfBirth = DateTime.Now,
                City = "Kiev",
                IdContact = 000001,
                IdEducation = 000001,
                DesiredPosition = "Asp.Net programmer",
                DesiredRate = 5000,
                Achievements = "cool girl",
                Requirements = ""
            });
            db.SaveChanges();
        }
    }
}
