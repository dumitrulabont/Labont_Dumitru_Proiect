using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Labont_Dumitru_Proiect.Data;
using Labont_Dumitru_Proiect.Models;

namespace Labont_Dumitru_Proiect.Pages.Note
{
    public class IndexModel : PageModel
    {
        private readonly Labont_Dumitru_Proiect.Data.Labont_Dumitru_ProiectContext _context;

        public IndexModel(Labont_Dumitru_Proiect.Data.Labont_Dumitru_ProiectContext context)
        {
            _context = context;
        }

        public IList<Nota> Nota { get;set; }

        public async Task OnGetAsync()
        {
            Nota = await _context.Nota
                .Include(n => n.Student).ToListAsync();
        }
    }
}
