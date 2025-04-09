using System;
using System.ComponentModel.DataAnnotations;

namespace Examen.ApplicationCore.Domain
{
    public class Bilan
    {
        [Required]
        public int CodeInfirmier { get; set; }

        [Required]
        public int CodePatient { get; set; }

        [Required]
        public DateTime DatePrelevement { get; set; }

        [StringLength(100)]
        public string EmailMedecin { get; set; }

        public bool Paye { get; set; }

        // Relations navigationnelles
        public Infirmier Infirmier { get; set; }
        public Patient Patient { get; set; }
    }
}
