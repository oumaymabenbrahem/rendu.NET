using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Laboratoire
    {
        [Key]
        public int LaboratoireId { get; set; }

        [Required]
        [StringLength(100)]
        public string Intitule { get; set; }

        [Required]
        [StringLength(200)]
        public string Localisation { get; set; }
    }
}
