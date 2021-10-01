using System;
namespace Dominio
{
    public class Consolas : Producto
    {
        public string CapacidadAlmacenamientoConsola {get; set;}    
        public TipoAlmacenamiento TipoAlmacenamiento {get; set;}
        public string VelocidadMemoria {get; set;}
        public string VelocidadProcesamiento {get; set;}
        public int NumeroControles {get; set;}

        /*public Consola(string NombreConsola, string VersionConsola, string FabricanteConsola, string CapacidadAlmacenamientoConsola, TipoAlmacenamiento TipoAlmacenamiento, string VelocidadMemoria, string VelocidadProcesamiento, int NumeroControles, double PrecioCompra, double PrecioVenta)
        {
            
        }*/
    }
}