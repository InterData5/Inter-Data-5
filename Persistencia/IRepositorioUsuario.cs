using System.Collections.Generic;
using System.Linq;
using Dominio;
namespace Persistencia
{
    public interface IRepositorioUsuario
    {
         public List<Usuario> ConsultarAllUsuarios();
         public bool GuardarCliente(Cliente Clientes);
         public bool GuardarEmpleado(Empleado Empleados);
         public bool EliminarUsuario(int Id);
         public bool ActualizarCliente(Cliente Clinetes);
         public bool ActualizarEmpleado(Empleado Empleados);
         public Usuario ConsultarUsuario(Usuario Usuarios);
    }
}