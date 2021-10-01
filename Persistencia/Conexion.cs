
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using Dominio;
using System.Collections.Generic; 

namespace Persistencia 
{
    public class Conexion : DbContext
    {
        
        public DbSet <Usuario> Usuarios {get; set;}
        public DbSet <Empleado> Empleados {get; set;}
        public DbSet <Cliente> Clientes {get; set;}
        public DbSet <Producto> Productos {get; set;}
        public DbSet <Controles> Controles {get; set;}
        public DbSet <Consolas> Consolas {get; set;}
        public DbSet <VideoJuego> VideoJuegos {get; set;}
        public DbSet <Compra> Compras {get; set;}
        public DbSet <Venta> Ventas {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder conn){
           if(!conn.IsConfigured){
               conn.UseSqlServer("Data source = (localdb)\\MSSQLLocalDB; Initial Catalog = ProyectoExito5");
           }
       }
    }
}