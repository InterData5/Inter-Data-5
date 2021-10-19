using System.Collections.Generic;
using System.Linq;
using System;
using System.ComponentModel.DataAnnotations;


namespace Dominio
{
    public class Cliente : Usuario
    {

        public string Email { get; set; }

        [Required(ErrorMessage = "Campo requerido.")]
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Campo requerido.")]
        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }

        /*public Cliente(string Nombre, string Apellido, string Cedula, string Email, string Direccion, string Telefono, string User, string Pass):base( Nombre, Apellido, Cedula, User, Pass)
        {

        }*/
    }
}