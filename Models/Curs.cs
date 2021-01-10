using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Labont_Dumitru_Proiect.Models
{
    public class Curs
    {
        public int ID { get; set; }
        [Required,StringLength(150, MinimumLength = 4,ErrorMessage = "Denumire cursului trebuie sa contina minim 4 caractere")]
        public String Denumire { get; set; }
        
        public int ProfesorID { get; set; }
        public Profesor Profesor { get; set; }
        public ICollection<Nota> Note { get; set; }

    }
}
