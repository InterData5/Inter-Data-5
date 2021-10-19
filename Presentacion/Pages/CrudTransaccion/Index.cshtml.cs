using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dominio;
using Persistencia;

namespace Presentacion.Pages.CrudTransaccion
{
    public class IndexModel : PageModel
    {
        private readonly Persistencia.Conexion _context;

        public IndexModel(Persistencia.Conexion context)
        {
            _context = context;
        }

        public IList<Transaccion> Transaccion { get;set; }

        public async Task OnGetAsync()
        {
            Transaccion = await _context.Transacciones.ToListAsync();
        }
    }
}
