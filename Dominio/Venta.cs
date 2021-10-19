using System;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Venta
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo requerido.")]
        [Display(Name = "Fecha de Venta")]

        public DateTime FechaVenta { get; set; }
    }
}