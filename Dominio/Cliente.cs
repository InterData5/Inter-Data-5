using System.Collections.Generic;  
using System.Linq; 
using System; 

namespace Dominio
{
    public class Cliente : Usuario
    {
        public string Email {get; set;}
        public string Direccion {get; set;}
        public string Telefono {get; set;}

        /*public Cliente(string Nombre, string Apellido, string Cedula, string Email, string Direccion, string Telefono, string User, string Pass):base( Nombre, Apellido, Cedula, User, Pass)
        {

        }*/
    }
}