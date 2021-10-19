using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Dominio;
using Persistencia;

namespace Presentacion.Pages.CrudTransaccion
{
    public class EditModel : PageModel
    {
        private readonly Persistencia.Conexion _context;

        public EditModel(Persistencia.Conexion context)
        {
            _context = context;
        }

        [BindProperty]
        public Transaccion Transaccion { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Transaccion = await _context.Transacciones.FirstOrDefaultAsync(m => m.Id == id);

            if (Transaccion == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Transaccion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TransaccionExists(Transaccion.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TransaccionExists(int id)
        {
            return _context.Transacciones.Any(e => e.Id == id);
        }
    }
}
