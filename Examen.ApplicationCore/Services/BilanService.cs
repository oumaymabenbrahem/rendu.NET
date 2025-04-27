using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;

namespace Examen.ApplicationCore.Services
{
    public class BilanService : IBilanService
    {
        public double CalculerMontantTotalBilan(Bilan bilan, List<Analyse> analyses)
        {
            
            var analysesDuBilan = analyses.Where(a => a.Bilan == bilan).ToList();

            double montantTotal = analysesDuBilan.Sum(a => a.PrixAnalyse);

           
            int nombrePrelevements = analyses
                .Where(a => a.Bilan.CodePatient == bilan.CodePatient)
                .Select(a => a.Bilan.DatePrelevement)
                .Distinct()
                .Count();

            if (nombrePrelevements > 5)
            {
                montantTotal *= 0.9; 
            }

            return montantTotal;
        }

        public double CalculerPourcentageInfirmiersParSpecialite(Specialite specialite, List<Infirmier> infirmiers)
        {
            int totalInfirmiers = infirmiers.Count();
            if (totalInfirmiers == 0) return 0;

            int nombreAvecSpecialite = infirmiers.Count(i => i.Specialite == specialite);

            return (nombreAvecSpecialite / (double)totalInfirmiers) * 100;
        }

        public Dictionary<Bilan, List<Analyse>> RecupererAnalysesAnormalesParPatient(Patient patient, List<Bilan> bilans, List<Analyse> analyses)
        {
            var result = new Dictionary<Bilan, List<Analyse>>();

            foreach (var bilan in bilans.Where(b => b.CodePatient == patient.CodePatient && b.DatePrelevement.Year == DateTime.Now.Year))
            {
                var analysesAnormales = analyses
                    .Where(a => a.Bilan == bilan)
                    .Where(a => a.ValeurAnalyse < a.ValeurMinNormale || a.ValeurAnalyse > a.ValeurMaxNormale)
                    .ToList();

                if (analysesAnormales.Any())
                {
                    result.Add(bilan, analysesAnormales);
                }
            }

            return result;
        }

        public DateTime EstimerDateDisponibiliteBilan(Bilan bilan, List<Analyse> analyses)
        {
            var analysesBilan = analyses.Where(a => a.Bilan == bilan).ToList();

            if (!analysesBilan.Any())
                return DateTime.MinValue;

            int dureeMax = analysesBilan.Max(a => a.DureeResultat);

            return bilan.DatePrelevement.AddDays(dureeMax);
        }
    }

}
