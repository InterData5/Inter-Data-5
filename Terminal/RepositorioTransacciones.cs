using System.Collections.Generic;
using System.Linq;
using Dominio;
using Persistencia;

namespace Terminal
{
    public class RepositorioTransacciones : ICRUDTransaccion
    {
        Conexion conexion = new Conexion();

        public void crearTransaccion(Transaccion transaccion)
        {
            conexion.Transacciones.Add(transaccion);
            conexion.SaveChanges();
        }
        public Transaccion consultarTransaccion(string numeroFactura)
        {
            Transaccion transaccion = conexion.Transacciones.First(e => e.NumeroFactura == numeroFactura); // var reconoce el tipo de variable automaticamente
            return transaccion;
        }
        public List<Transaccion> consultarTodasTransacciones()
        {
            List<Transaccion> listaTransacciones = new List<Transaccion>();
            foreach (Transaccion e in conexion.Transacciones)
            {
                listaTransacciones.Add(e);
            }
            return listaTransacciones;
        }
        public void actualizarTransaccion(Transaccion transaccion)
        {
            var transaccionBusqueda = conexion.Transacciones.First(e => e.NumeroFactura == transaccion.NumeroFactura);

            transaccionBusqueda.Valor = transaccion.Valor;
            transaccionBusqueda.Empleado = transaccion.Empleado;
            transaccionBusqueda.NumeroFactura = transaccion.NumeroFactura;
            transaccionBusqueda.Sucursal = transaccion.Sucursal;
            transaccionBusqueda.Mes = transaccion.Mes;
            transaccionBusqueda.EsCompra = transaccion.EsCompra;

            conexion.SaveChanges();
        }
        public void eliminarTransaccion(string numeroFactura)
        {
            var transaccion = conexion.Transacciones.First(e => e.NumeroFactura == numeroFactura);
            conexion.Transacciones.Remove(transaccion);
            conexion.SaveChanges();
        }
    }
}