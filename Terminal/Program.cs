using System;
using Dominio;
//using Persistencia;

namespace Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            RepositorioEmpleados repositorioEmpleados = new RepositorioEmpleados();

            Empleado empleado = new Empleado();

            empleado.Nombres = "Pepito";
            empleado.Apellidos = "Perez";
            empleado.DocumentoIdentificacion = "123456789";
            empleado.TipoEmpleado = ETipoEmpleado.VENDEDOR;
            empleado.CodigoEmpleado = "V01";
            empleado.Sucursal = ESucursal.MEDELLIN;
            empleado.Usuario = "PePe";
            empleado.Contrasenia = "987654321";

            //repositorioEmpleados.crearEmpleado(empleado);

            RepositorioTransacciones repositorioTransacciones = new RepositorioTransacciones();

            Transaccion transaccion = new Transaccion();

            transaccion.Valor = 500000;
            transaccion.Empleado = empleado;
            transaccion.NumeroFactura = "F01";
            transaccion.Sucursal = ESucursal.MEDELLIN;
            transaccion.Mes = "10";
            transaccion.EsCompra = false;

            //repositorioTransacciones.crearTransaccion(transaccion);

            RepositorioProductos repositorioProductos = new RepositorioProductos();

            Producto producto = new Producto();

            producto.Nombre = "XBOX";
            producto.Version = "SERIES S";
            producto.Fabricante = EFabricante.MICROSOFT;
            producto.PrecioCompra = 200000;
            producto.PrecioVenta = 500000;

            repositorioProductos.crearProducto(producto);

        }
    }
}
