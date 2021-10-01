using System;
using System.Collections.Generic;
using Dominio;
using Persistencia;
using System.Linq;
namespace Consola
{
    public class RepositorioProducto : IRepositorioProducto
    {
         public List<Producto> ConsultarAllProductos(){
             Conexion db = new Conexion();
             return db.Productos.Where(e => e.Id >= 0).ToList();
         }
         public bool GuardarConsola(Consolas consolas){
             Conexion db = new Conexion();
             db.Consolas.Add(consolas);
             db.SaveChanges();
             var prod = db.Consolas.Where(e => e.Version == consolas.Version);
             if(prod!=null){
             Console.WriteLine("Producto registrado con Exito");
             return true;
             }
             return false;
         }
         public bool GuardarControles(Controles controles){
             Conexion db = new Conexion();
             db.Controles.Add(controles);
             db.SaveChanges();
             var prod = db.Controles.Where(e => e.Version == controles.Version);
             if(prod!=null){
             Console.WriteLine("Producto registrado con Exito");
             return true;
             }
             return false;
         }
         public bool GuardarVideoJuego(VideoJuego videojuegos){
             Conexion db = new Conexion();
             db.VideoJuegos.Add(videojuegos);
             db.SaveChanges();
             var prod = db.VideoJuegos.Where(e => e.Version == videojuegos.Version);
             if(prod!=null){
             Console.WriteLine("Producto registrado con Exito");
             return true;
             }
             return false;
         }
         public bool EliminarProducto(int Id){
             Conexion db = new Conexion();
             return true;
         }
         public bool ActualizarConsola(Consolas consolas){
             Conexion db = new Conexion();
            var prod = db.Consolas.First(e => e.Version == consolas.Version);
            if (prod!=null){
                prod.Nombre = consolas.Nombre;
                prod.Version = consolas.Version;
                prod.Fabricante = consolas.Fabricante;
                prod.PrecioVenta = consolas.PrecioVenta;
                prod.PrecioCompra = consolas.PrecioCompra;
                prod.CapacidadAlmacenamientoConsola = consolas.CapacidadAlmacenamientoConsola;
                prod.TipoAlmacenamiento = consolas.TipoAlmacenamiento;
                prod.VelocidadMemoria = consolas.VelocidadMemoria;
                prod.VelocidadProcesamiento = consolas.VelocidadProcesamiento;
                prod.NumeroControles = consolas.NumeroControles;
                return true;
            }    
            return false;
         }
         public bool ActualizarControles(Controles controles){
             Conexion db = new Conexion();
            var prod = db.Controles.First(e => e.Version == controles.Version);
            if (prod!=null){
                prod.Nombre = controles.Nombre;
                prod.Version = controles.Version;
                prod.Fabricante = controles.Fabricante;
                prod.PrecioVenta = controles.PrecioVenta;
                prod.PrecioCompra = controles.PrecioCompra;
                prod.Tipo = controles.Tipo;
                return true;
            }    
            return false;
         }
         public bool ActualizarVideojuego(VideoJuego videojuegos){
             Conexion db = new Conexion();
            var prod = db.VideoJuegos.First(e => e.Version == e.Version);
            if (prod!=null){
                prod.Nombre = videojuegos.Nombre;
                prod.Version = videojuegos.Version;
                prod.Fabricante = videojuegos.Fabricante;
                prod.PrecioVenta = videojuegos.PrecioVenta;
                prod.PrecioCompra = videojuegos.PrecioCompra;
                prod.Plataforma = videojuegos.Plataforma;
                return true;
            }    
            return false;
         }
         public Producto ConsultarProducto (Producto productos){
             Conexion db = new Conexion();
             var prod = db.VideoJuegos.First(e => e.Version == e.Version);
             return prod;
         }
    }
}