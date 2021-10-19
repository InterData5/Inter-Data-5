using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace Presentacion.Pages
{
    public class LoginModel : PageModel
    {
        //private readonly Persistencia.Conexion _context;

        /*         public CreateModel(Persistencia.Conexion context)
                {
                    _context = context;
                } */

        [BindProperty]
        public string us { get; set; }

        [BindProperty]
        public string Contrasenia { get; set; }

        [BindProperty]
        public string MensajeContrasenia { get; set; }

        [BindProperty]
        public string MensajeUsuario { get; set; }

        public void OnGet()
        {

        }

        [BindProperty]
        public bool login {get;set;}
        public IActionResult OnPost()
        {
            Conexion conexion = new Conexion();
            Usuario usuario = conexion.Usuarios.FirstOrDefault(e => e.User == us);
            if (usuario != null)
            {
                if (usuario.Pass.Equals(Contrasenia))
                {
                    login = true;
                    return RedirectToPage("../Index");
                }
                else
                {
                    MensajeContrasenia = "Contraseña no coincide.";
                    return Page();
                }

            }
            else
            {
                MensajeUsuario = "Usuario no encontrado.";
                return Page();
            }

            //return RedirectToPage("./Index");
        }
    }
}
