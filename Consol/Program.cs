using System;
using System.Collections.Generic;
using Dominio;
using Persistencia;
using System.Linq;

namespace Consola
{
    class Program
    
    {
        static void Main(string[] args)
        {
            Conexion db = new Conexion();
            Cliente clt = new Cliente();
            clt.Nombre = "pedrito";
            clt.Apellido = "muñoz";
            clt.Cedula = "123456789";
            clt.Email = "pedro@hotmail.com";
            clt.Direccion = "calle 75 b sur 9 b 21";
            clt.Telefono = "3192692409";
            clt.User = "marcos";
            clt.Pass = "123456";
            db.Clientes.Add(clt);
            db.SaveChanges();

        } 
    }
}

