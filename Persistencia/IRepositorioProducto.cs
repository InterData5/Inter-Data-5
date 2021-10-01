using System.Collections.Generic;
using System.Linq;
using Dominio;

namespace Persistencia
{
    public interface IRepositorioProducto
    {
         public List<Producto> ConsultarAllProductos();
         public bool GuardarConsola(Consolas consolas);
         public bool GuardarControles(Controles controles);
         public bool GuardarVideoJuego(VideoJuego videojuegos);
         public bool EliminarProducto(int Id);
         public bool ActualizarConsola(Consolas consolas);
         public bool ActualizarControles(Controles controles);
         public bool ActualizarVideojuego(VideoJuego videojuegos);
         public Producto ConsultarProducto (Producto productos);
         
    }
}