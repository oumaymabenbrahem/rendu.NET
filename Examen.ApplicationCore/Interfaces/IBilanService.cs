using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen.ApplicationCore.Domain;

namespace Examen.ApplicationCore.Interfaces
{
    public interface IBilanService
    {
        double CalculerMontantTotalBilan(Bilan bilan, List<Analyse> analyses);
        double CalculerPourcentageInfirmiersParSpecialite(Specialite specialite, List<Infirmier> infirmiers);
        Dictionary<Bilan, List<Analyse>> RecupererAnalysesAnormalesParPatient(Patient patient, List<Bilan> bilans, List<Analyse> analyses);
        DateTime EstimerDateDisponibiliteBilan(Bilan bilan, List<Analyse> analyses);
    }
}
