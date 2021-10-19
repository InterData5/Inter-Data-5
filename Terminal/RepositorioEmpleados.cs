using System.Collections.Generic;
using System.Linq;
using Dominio;
using Persistencia;

namespace Terminal
{
    public class RepositorioEmpleados : ICRUDEmpleado
    {
        Conexion conexion = new Conexion();

        public void crearEmpleado(Empleado empleado)
        {
            conexion.Empleados.Add(empleado);
            conexion.SaveChanges();
        }
        public Empleado consultarEmpleado(string codigoEmpleado)
        {
            Empleado empleado = conexion.Empleados.First(e => e.CodigoEmpleado == codigoEmpleado); // var reconoce el tipo de variable automaticamente
            return empleado;
        }
        public List<Empleado> consultarTodosEmpleados()
        {
            List<Empleado> listaEmpleados = new List<Empleado>();
            foreach (Empleado e in conexion.Empleados)
            {
                listaEmpleados.Add(e);
            }
            return listaEmpleados;
        }
        public void actualizarEmpleado(Empleado empleado)
        {
            var empleadoBusqueda = conexion.Empleados.First(e => e.CodigoEmpleado == empleado.CodigoEmpleado);

            empleadoBusqueda.Nombres = empleado.Nombres;
            empleadoBusqueda.Apellidos = empleado.Apellidos;
            empleadoBusqueda.DocumentoIdentificacion = empleado.DocumentoIdentificacion;
            empleadoBusqueda.TipoEmpleado = empleado.TipoEmpleado;
            empleadoBusqueda.CodigoEmpleado = empleado.CodigoEmpleado;
            empleadoBusqueda.Sucursal = empleado.Sucursal;
            empleadoBusqueda.Usuario = empleado.Usuario;
            empleadoBusqueda.Contrasenia = empleado.Contrasenia;

            conexion.SaveChanges();
        }
        public void eliminarEmpleado(string codigoEmpleado)
        {
            var empleado = conexion.Empleados.First(e => e.CodigoEmpleado == codigoEmpleado);
            conexion.Empleados.Remove(empleado);
            conexion.SaveChanges();
        }
    }
}