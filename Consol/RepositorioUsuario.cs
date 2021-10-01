using System;
using System.Collections.Generic;
using Dominio;
using Persistencia;
using System.Linq;

namespace Consola
{
    public class RepositorioUsuario : IRepositorioUsuario
    {   
        
         public List<Usuario> ConsultarAllUsuarios(){
             Conexion db = new Conexion();
             return db.Usuarios.Where(e => e.Id >= 0).ToList();
         }

        public bool GuardarCliente(Cliente usuario){
            Conexion db = new Conexion();
             db.Clientes.Add(usuario);
             db.SaveChanges();
             var user = db.Clientes.Where(e => e.Cedula == usuario.Cedula);
             if(user!=null){
             Console.WriteLine("Usuario registrado con Exito");
             return true;
             }
             return false;
        }

        public bool GuardarEmpleado(Empleado usuario){
            Conexion db = new Conexion();
             db.Empleados.Add(usuario);
             db.SaveChanges();
            var user = db.Empleados.Where(e => e.Cedula == usuario.Cedula);
             if(user!=null){
             Console.WriteLine("Usuario registrado con Exito");
             return true;
             }
             return false;
        }

         public bool EliminarUsuario(int id){
             Conexion db = new Conexion();
             var user = db.Usuarios.First(e => e.Id == id);
             if (user!=null){
                db.Usuarios.Remove(user);
                db.SaveChanges();
                return true;
             }
             return false;
         }

         public bool ActualizarCliente(Cliente Clientes){
            Conexion db = new Conexion();
            var user = db.Clientes.First(e => e.Cedula == Clientes.Cedula);
            if (user!=null){
                user.Nombre = Clientes.Nombre;
                user.Apellido = Clientes.Apellido;
                user.Cedula = Clientes.Cedula;
                user.User = Clientes.User;
                user.Pass = Clientes.Pass;
                user.Email = Clientes.Email;
                user.Direccion = Clientes.Direccion;
                user.Telefono = Clientes.Telefono;
                return true;
            }    
            return false;
         }

         public bool ActualizarEmpleado(Empleado Empleados){
             Conexion db = new Conexion();
             var user = db.Empleados.First(e => e.Cedula == Empleados.Cedula);
            if (user!=null){
                user.Nombre = Empleados.Nombre;
                user.Apellido = Empleados.Apellido;
                user.Cedula = Empleados.Cedula;
                user.User = Empleados.User;
                user.Pass = Empleados.Pass;
                user.CodigoEmpleado = Empleados.CodigoEmpleado;
                user.Sucursal = Empleados.Sucursal;
                user.AccesoReportes = Empleados.AccesoReportes;
                return true;
            }    
            return false;
         }

         public Usuario ConsultarUsuario(Usuario  Usuarios){
            Conexion db = new Conexion();    
            var user = db.Clientes.First(e => e.Cedula == Usuarios.Cedula);
                
            return user;
         }
    }
}