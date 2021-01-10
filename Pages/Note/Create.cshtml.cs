using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Labont_Dumitru_Proiect.Data;
using Labont_Dumitru_Proiect.Models;

namespace Labont_Dumitru_Proiect.Pages.Note
{
    public class CreateModel : PageModel
    {
        private readonly Labont_Dumitru_Proiect.Data.Labont_Dumitru_ProiectContext _context;

        public CreateModel(Labont_Dumitru_Proiect.Data.Labont_Dumitru_ProiectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            //var curs = _context.Curs;
            //var profesor = _context.Profesor;
            var interograre = from cr in _context.Curs
                              join pr in _context.Profesor
                              on cr.ProfesorID equals pr.ID
                              select new
                              {
                                  ID = cr.ID,
                                  materie = string.Format("{0} -- {1} {2}",cr.Denumire,pr.Nume,pr.Prenume)
                              };
        ViewData["StudentID"] = new SelectList(_context.Student, "ID", "Nume");
        ViewData["CursID"] = new SelectList(interograre, "ID", "materie");
        
            return Page();
        }

        [BindProperty]
        public Nota Nota { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Nota.Add(Nota);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
