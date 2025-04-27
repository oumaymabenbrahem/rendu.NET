using Examen.ApplicationCore.Domain;
using Examen.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infrastructure
{
    public class ExamContext : DbContext
    {
        //les dbsets
        public DbSet<Bilan> bilans { get; set; }
        public DbSet<BilanConfiguration> bilanconfigs { get; set; }
        public DbSet<Infirmier> infirmiers { get; set; }
        public DbSet<Laboratoire> laboratoires { get; set; }
        public DbSet<Patient> patients { get; set; }
       
        public DbSet<Analyse> analyses { get; set; }

        //....................
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
                                          Initial Catalog=Oumaymabenbrahem;
                                          Integrated Security=true;
                                          MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLazyLoadingProxies(); //activer lazy loading
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveMaxLength(50);
        }
    }
}
