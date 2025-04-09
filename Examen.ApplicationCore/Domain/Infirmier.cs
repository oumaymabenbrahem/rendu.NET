using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Infirmier
    {
        [Key]
        public int InfirmierId { get; set; }

        [Required]
        [StringLength(100)]
        public string NonComplet { get; set; }

        public Specialite Specialite { get; set; }

        public ICollection<Bilan> Bilans { get; set; }

    }
}
