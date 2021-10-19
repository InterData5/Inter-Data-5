using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Campo requerido.")]
        [Display(Name = "Cédula")]

        public string Cedula { get; set; }
        [Required(ErrorMessage = "Campo requerido.")]
        [Display(Name = "Usuario")]

        public string User { get; set; }
        [Required(ErrorMessage = "Campo requerido.")]
        [Display(Name = "Contraseña")]

        public string Pass { get; set; }

        [Display (Name="El usuario debe cambiar la contraseña en el siguiente inicio de sesión")]
        public bool CambioClave { get; set; }

        /* public Usuario()
         {

         }
         public Usuario(string Nombre, string Apellido, string Cedula, string User, string Pass)
         {

         }*/
    }
}