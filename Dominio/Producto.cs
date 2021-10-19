using System.ComponentModel.DataAnnotations;


namespace Dominio
{
    public class Producto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo requerido.")]

        public string Nombre { get; set; }
        [Display(Name = "Versión")]
        [Required(ErrorMessage = "Campo requerido.")]

        public string Version { get; set; }
        [Required(ErrorMessage = "Campo requerido.")]

        public EFabricante Fabricante { get; set; }
        [Required(ErrorMessage = "Campo requerido.")]
        [Display(Name = "Precio de Compra")]

        public double PrecioCompra { get; set; }
        [Required(ErrorMessage = "Campo requerido.")]
        [Display(Name = "Precio de Venta")]

        public double PrecioVenta { get; set; }

        public Producto() { } // metodo constructor vacio, que no necesita argumentos

        public Producto(string nombre, string version, EFabricante fabricante, double precioCompra, double precioVenta)
        {
            //this.Id = id;
            this.Nombre = nombre;
            this.Version = version;
            this.Fabricante = fabricante;
            this.PrecioCompra = precioCompra;
            this.PrecioVenta = precioVenta;
        }
    }
}