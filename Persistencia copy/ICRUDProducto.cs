using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public interface ICRUDProducto
    {
        public void crearProducto(Producto producto);
        public Producto consultarProducto(string nombre);
        public List<Producto> consultarTodosProductos();
        public void actualizarProducto(Producto producto);
        public void eliminarProducto(string nombre);
    }
}