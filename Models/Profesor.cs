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
        public string Nume { get; set; }
        public string Prenume { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data Nasteri")]
        public DateTime DataNasteri { get; set; }
        
        public ICollection<Curs> Cursuri { get; set; }
    }
}
