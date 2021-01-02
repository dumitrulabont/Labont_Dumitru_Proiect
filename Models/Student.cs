using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Labont_Dumitru_Proiect.Models
{
    public enum TipScolarizare
    {
        Bugent,
        Taxa
    }
    public class Student
    {
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        [DataType(DataType.Date)]
        [Display(Name ="Data Nasterii")]//am adaugat spatiu la denumire
        public DateTime DataNasterii { get; set; }
        [Display(Name = "Tip Scolarizare")]
        public TipScolarizare TipScolarizare { get; set; }

        public ICollection<Nota> Note { get; set; }
    }
}
