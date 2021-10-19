using System.Collections.Generic;
using System.Linq;
using Dominio;
using Persistencia;

namespace Terminal
{
    public class RepositorioProductos : ICRUDProducto
    {
        Conexion conexion = new Conexion();

        public void crearProducto(Producto producto)
        {
            conexion.Productos.Add(producto);
            conexion.SaveChanges();
        }
        public Producto consultarProducto(string nombre)
        {
            Producto producto = conexion.Productos.First(e => e.Nombre == nombre); // var reconoce el tipo de variable automaticamente
            return producto;
        }
        public List<Producto> consultarTodosProductos()
        {
            List<Producto> listaProductos = new List<Producto>();
            foreach (Producto e in conexion.Productos)
            {
                listaProductos.Add(e);
            }
            return listaProductos;
        }
        public void actualizarProducto(Producto producto)
        {
            var productoBusqueda = conexion.Productos.First(e => e.Nombre == producto.Nombre);

            productoBusqueda.Nombre = producto.Nombre;
            productoBusqueda.Version = producto.Version;
            productoBusqueda.Fabricante = producto.Fabricante;
            productoBusqueda.PrecioCompra = producto.PrecioCompra;
            productoBusqueda.PrecioVenta = producto.PrecioVenta;

            conexion.SaveChanges();
        }
        public void eliminarProducto(string nombre)
        {
            var producto = conexion.Productos.First(e => e.Nombre == nombre);
            conexion.Productos.Remove(producto);
            conexion.SaveChanges();
        }
    }
}