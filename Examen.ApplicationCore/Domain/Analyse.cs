using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Analyse
    {
        [Key]
        public int AnalyseId { get; set; }

        public int DureeResultat { get; set; } 

        [Column("Valeur/analyse")]
        public float ValeurAnalyse { get; set; }

        [Column("ValeurMaxNormale")]
        public float ValeurMaxNormale { get; set; }

        [Column("ValeurMinNormale")]
        public float ValeurMinNormale { get; set; }


        [StringLength(100)]
        public string TypeAnalyse { get; set; }
        public double PrixAnalyse { get; set; }
    }
}
