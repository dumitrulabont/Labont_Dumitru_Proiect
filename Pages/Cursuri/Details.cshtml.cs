using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Labont_Dumitru_Proiect.Data;
using Labont_Dumitru_Proiect.Models;

namespace Labont_Dumitru_Proiect.Pages.Cursuri
{
    public class DetailsModel : PageModel
    {
        private readonly Labont_Dumitru_Proiect.Data.Labont_Dumitru_ProiectContext _context;

        public DetailsModel(Labont_Dumitru_Proiect.Data.Labont_Dumitru_ProiectContext context)
        {
            _context = context;
        }

        public Curs Curs { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Curs = await _context.Curs
                .Include(c => c.Profesor).FirstOrDefaultAsync(m => m.ID == id);

            if (Curs == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
