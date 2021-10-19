using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public interface ICRUDEmpleado
    {
        public void crearEmpleado(Empleado empleado);
        public Empleado consultarEmpleado(string codigoEmpleado);
        public List<Empleado> consultarTodosEmpleados();
        public void actualizarEmpleado(Empleado empleado);
        public void eliminarEmpleado(string codigoEmpleado);
    }
}