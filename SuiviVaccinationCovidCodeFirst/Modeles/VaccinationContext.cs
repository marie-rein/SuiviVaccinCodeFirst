using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviVaccinationCovidCodeFirst.Modeles
{
    public class VaccinationContext : DbContext
    {
        public DbSet<Dose> Doses { get; set; }
        public DbSet<Vaccin> Vaccins { get; set; }
        public DbSet<Immunisation> Immunizations { get; set; }
        public DbSet<Covid19> covid19s { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => 
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Vaccination;Trusted_Connection=True;");
        
    }
}
