using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Labont_Dumitru_Proiect.Models;

namespace Labont_Dumitru_Proiect.Data
{
    public class Labont_Dumitru_ProiectContext : DbContext
    {
        public Labont_Dumitru_ProiectContext (DbContextOptions<Labont_Dumitru_ProiectContext> options)
            : base(options)
        {
        }

        public DbSet<Labont_Dumitru_Proiect.Models.Student> Student { get; set; }

        public DbSet<Labont_Dumitru_Proiect.Models.Profesor> Profesor { get; set; }

        public DbSet<Labont_Dumitru_Proiect.Models.Curs> Curs { get; set; }

        public DbSet<Labont_Dumitru_Proiect.Models.Nota> Nota { get; set; }
    }
}
