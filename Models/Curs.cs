using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labont_Dumitru_Proiect.Models
{
    public class Curs
    {
        public int ID { get; set; }
        public String Denumire { get; set; }
        
        public int ProfesorID { get; set; }
        public Profesor Profesor { get; set; }
    }
}
