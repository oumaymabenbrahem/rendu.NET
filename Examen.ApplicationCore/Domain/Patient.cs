using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Patient
    {
        [Key]
        [StringLength(5, ErrorMessage = "Le code patient doit avoir exactement 5 caractères.", MinimumLength = 5)]
        public int CodePatient { get; set; }

        [StringLength(100)]
        public string EmailPatient { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Informations supplémentaires")]
        public string Informations { get; set; }

        [StringLength(100)]
        public string Nomcomplet { get; set; }

        [StringLength(100)]
        public string Numerotel { get; set; }

        public ICollection<Bilan> Bilans { get; set; }

    }
}
