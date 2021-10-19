using System.ComponentModel.DataAnnotations;

using System;
namespace Dominio
{
    public class Compra
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo requerido.")]
        [Display(Name = "Fecha de Compra")]
        public DateTime FechaCompra { get; set; }
    }
}