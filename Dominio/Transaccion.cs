using System.ComponentModel.DataAnnotations;


namespace Dominio
{
    public class Transaccion
    {
        public int Id { get; set; }
        [Display(Name = "Número de Factura")]
        [Required(ErrorMessage = "Campo requerido.")]

        public string NumeroFactura { get; set; }
        [Required(ErrorMessage = "Campo requerido.")]

        public double Valor { get; set; }
        [Required(ErrorMessage = "Campo requerido.")]

        public ESucursal Sucursal { get; set; }
        [Required(ErrorMessage = "Campo requerido.")]

        public string Mes { get; set; }
        [Required(ErrorMessage = "Campo requerido.")]
        [Display(Name = "Es Compra")]

        public bool EsCompra { get; set; }
        [Required(ErrorMessage = "Campo requerido.")]

        public Empleado Empleado { get; set; }

        public Transaccion() { }

        public Transaccion(Empleado empleado, Producto producto, string numeroFactura, string mes, bool esCompra)
        {
            if (esCompra)
            {
                this.Valor = producto.PrecioCompra;
            }
            else
            {
                this.Valor = producto.PrecioVenta;
            }

            this.Empleado = empleado;
            this.NumeroFactura = numeroFactura;
            this.Sucursal = empleado.Sucursal;
            this.Mes = mes;
            this.EsCompra = esCompra;

        }


    }
}