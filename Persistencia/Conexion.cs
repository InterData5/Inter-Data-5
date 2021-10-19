using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Dominio; // en capa de Persistencia correr: dotnet add reference ..\ConsolasExito.App.Dominio\

namespace Persistencia
{
    public class Conexion : DbContext // Conecta aplicacion con base de datos. Hereda de DbContext que esta en Microsoft.EntityFrameworkCore
    {
        public DbSet<Empleado> Empleados { get; set; }

        public DbSet<Producto> Productos { get; set; }

        public DbSet<Transaccion> Transacciones { get; set; }

        //Metodo para poder crear la base de datos y sus respectivas tablas
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data source = (localdb)\\MSSQLLocalDB; Initial Catalog = ConsolasExito.db"); // conexion a la base de datos denomindada "ConsolasExito.Data" (no tiene que ser .Data)
            }

        }

    }
}