namespace Dominio
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Version { get; set; }

        public EFabricante Fabricante { get; set; }

        public double PrecioCompra { get; set; }

        public double PrecioVenta { get; set; }

        public Producto(){} // metodo constructor vacio, que no necesita argumentos

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