using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public interface ICRUDTransaccion
    {
        public void crearTransaccion(Transaccion transaccion);
        public Transaccion consultarTransaccion(string numeroFactura);
        public List<Transaccion> consultarTodasTransacciones();
        public void actualizarTransaccion(Transaccion transaccion);
        public void eliminarTransaccion(string numeroFactura);
    }
}