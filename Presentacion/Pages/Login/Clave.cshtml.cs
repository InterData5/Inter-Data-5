using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Dominio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Presentacion.Pages.Login
{
    public class ClaveModel : PageModel
    {
        private readonly Persistencia.Conexion _context;
   
        public ClaveModel(Persistencia.Conexion context)
        {
            _context = context;
        }
        public string Mensaje { get; set; }
        [BindProperty]
        public string Users { get; set; }
        [BindProperty]
        [Required]
        public string Password1 { get; set; }
        [BindProperty]
        [Required]
        public string Password2 { get; set; }

        [TempData]
        public string Users1 { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            Usuario usu = _context.Usuarios.FirstOrDefault(u => u.User == Users);


            if (Users != null)
            {
                
                if (Password1 == Password2)
                {
                    usu.Pass = Password1;
                    usu.CambioClave = false;
                    _context.SaveChanges();

                    return RedirectToPage("../Index");
                }
                else
                {
                    Mensaje = "la Clave No Coincide";
                }
            }
            else
            {
                return Page();
            }
            return Page();
        }
    }
}
