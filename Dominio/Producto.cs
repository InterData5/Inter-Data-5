using System.ComponentModel.DataAnnotations;


namespace Dominio
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo requerido.")]
        [Display(Name = "Versión")]
        public string Version { get; set; }
        public string Fabricante { get; set; }
        [Required(ErrorMessage = "Campo requerido.")]
        [Display(Name = "Precio de Venta")]

        public float PrecioVenta { get; set; }
        [Required(ErrorMessage = "Campo requerido.")]
        [Display(Name = "Precio de Compra")]

        public float PrecioCompra { get; set; }
    }
}