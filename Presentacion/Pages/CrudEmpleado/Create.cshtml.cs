using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Dominio;
using Persistencia;

namespace Presentacion.Pages.CrudEmpleado
{
    public class CreateModel : PageModel
    {
        private readonly Persistencia.Conexion _context;

        public CreateModel(Persistencia.Conexion context)
        {
            _context = context;
        }

        public SelectList sucursalesFront; // crear lista select para mostrar lista de sucursales en el front

        public IActionResult OnGet()
        {
            //List<Sucursal> listaSucursales = _context.Sucursales.ToList(); // en caso que se cree una clase con sucursales
            
            List<string> listaSucursales = new List<string>();
            
            listaSucursales.Add("Seleccione opción");
            listaSucursales.Add("BOGOTA");
            listaSucursales.Add("MEDELLIN");
            listaSucursales.Add("CALI");
            listaSucursales.Add("BARRANQUILLA");
            listaSucursales.Add("CALDAS");

            //sucursalesFront = new SelectList(listaSucursales, nameof(Sucursales.Id), nameof(sucursalesFront.Nombre)); // usar si hay clase Sucursal con atributos Id, Nombre.
            sucursalesFront = new SelectList(listaSucursales); 
            
            return Page();
        }

        [BindProperty]
        public Empleado Empleado { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Empleados.Add(Empleado);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
