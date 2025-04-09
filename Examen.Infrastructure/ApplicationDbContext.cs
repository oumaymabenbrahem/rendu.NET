using Microsoft.EntityFrameworkCore;
using Examen.ApplicationCore.Domain;

namespace Examen.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Laboratoire> Laboratoires { get; set; }
        public DbSet<Analyse> Analyses { get; set; }
        public DbSet<Infirmier> Infirmiers { get; set; }
        public DbSet<Bilan> Bilans { get; set; }
        public DbSet<Patient> Patients { get; set; }

        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

       
        public ApplicationDbContext() { }

        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=LaboBenBrahemOumayma.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Exemple : mapping FluentAPI
            modelBuilder.Entity<Laboratoire>()
                .Property(l => l.Localisation)
                .HasColumnName("AdresseLabo")
                .HasMaxLength(50);

            modelBuilder.ApplyConfiguration(new BilanConfiguration());
        }
    }
}
