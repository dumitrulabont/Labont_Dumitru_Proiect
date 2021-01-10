using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Labont_Dumitru_Proiect.Models
{
    public class Profesor
    {
        public int ID { get; set; }

        [RegularExpression(@"^[A-Z][a-z]+$",ErrorMessage = "Numele invalid"),Required,StringLength(60,MinimumLength = 3,ErrorMessage = "Numele trebuie sa contina minim 3 caractere")]
        public string Nume { get; set; }

        [RegularExpression(@"^[A-Z][a-z]+$", ErrorMessage = "Prenume invalid"), Required, StringLength(60, MinimumLength = 3, ErrorMessage = "Prenume trebuie sa contina minim 3 caractere")]

        public string Prenume { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data Nasteri")]
        public DateTime DataNasteri { get; set; }
        
        public ICollection<Curs> Cursuri { get; set; }
    }
}
