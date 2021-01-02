using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Labont_Dumitru_Proiect.Data;
using Labont_Dumitru_Proiect.Models;

namespace Labont_Dumitru_Proiect.Pages.Profesori
{
    public class DetailsModel : PageModel
    {
        private readonly Labont_Dumitru_Proiect.Data.Labont_Dumitru_ProiectContext _context;

        public DetailsModel(Labont_Dumitru_Proiect.Data.Labont_Dumitru_ProiectContext context)
        {
            _context = context;
        }

        public Profesor Profesor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Profesor = await _context.Profesor.FirstOrDefaultAsync(m => m.ID == id);

            if (Profesor == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
