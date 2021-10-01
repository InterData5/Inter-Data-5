using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dominio;
using Persistencia;

namespace Presentacion.Pages.CrudControles
{
    public class DeleteModel : PageModel
    {
        private readonly Persistencia.Conexion _context;

        public DeleteModel(Persistencia.Conexion context)
        {
            _context = context;
        }

        [BindProperty]
        public Controles Controles { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Controles = await _context.Controles.FirstOrDefaultAsync(m => m.Id == id);

            if (Controles == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Controles = await _context.Controles.FindAsync(id);

            if (Controles != null)
            {
                _context.Controles.Remove(Controles);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
