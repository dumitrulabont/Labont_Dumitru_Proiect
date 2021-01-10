using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Labont_Dumitru_Proiect.Models
{
    public class Nota
    {
        public int ID { get; set; }
       
        [Display(Name = "Nota")]
        [Range(1,10,ErrorMessage = "Nota trebuie sa fie un numar intre 1 si 10")]
        public int ValoareNota { get; set; }

        [Display(Name = "Student")]
        public int StudentID { get; set; }
        public Student Student { get; set; }

        public int CursID { get; set; }

        public Curs Curs { get; set; }
    }
}
