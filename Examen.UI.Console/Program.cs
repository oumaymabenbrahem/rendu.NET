using Microsoft.EntityFrameworkCore;
using System;
using Examen.ApplicationCore.Domain;
using Examen.Infrastructure;

public class Program
{
    public static void Main()
    {
        try
        {
            
            string nom = "BenBrahem";
            string prenom = "Oumayma";


            string dbName = $"Labo{nom}{prenom}.db";  

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlite($"Data Source={dbName}") 
                .Options;

            using (var context = new ApplicationDbContext(options))
            {
                context.Database.EnsureDeleted(); 
                context.Database.EnsureCreated(); 

                
                var labo = new Laboratoire
                {
                    Intitule = "Labo Central",
                    Localisation = "Centre-ville de Paris"
                };

                context.Laboratoires.Add(labo);
                context.SaveChanges();

                Console.WriteLine($"Laboratoire ajouté avec succès dans {dbName} !");

              
                var infirmier = new Infirmier
                {
                    NonComplet = "Jean Dupont",
                    Specialite = Specialite.Biochimie
                };
                context.Infirmiers.Add(infirmier);
                context.SaveChanges();

                Console.WriteLine("Infirmier ajouté avec succès !");

               
                var patient = new Patient
                {
                    CodePatient = 12345,
                    EmailPatient = "patient@example.com",
                    Nomcomplet = "Marie Curie",
                    Numerotel = "0123456789"
                };
                context.Patients.Add(patient);
                context.SaveChanges();

                Console.WriteLine("Patient ajouté avec succès !");

             
                var bilan = new Bilan
                {
                    CodeInfirmier = infirmier.InfirmierId,
                    CodePatient = patient.CodePatient,
                    DatePrelevement = DateTime.Now,
                    EmailMedecin = "medecin@example.com",
                    Paye = false
                };

                context.Bilans.Add(bilan);
                context.SaveChanges();

                Console.WriteLine("Bilan ajouté avec succès !");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erreur : {ex.Message}");
        }
    }
}
