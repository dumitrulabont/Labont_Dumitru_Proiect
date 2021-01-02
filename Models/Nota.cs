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
        public int ValoareNota { get; set; }
        public int StudentID { get; set; }
        public Student Student { get; set; }

    }
}
