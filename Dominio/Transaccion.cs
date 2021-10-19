namespace Dominio
{
    public class Transaccion
    {
        public int Id {get;set;}

        public string NumeroFactura { get; set; }

        public double Valor { get; set; }

        public ESucursal Sucursal { get; set; }

        public string Mes { get; set; }

        public bool EsCompra { get; set; }

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