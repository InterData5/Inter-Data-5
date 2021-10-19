using System;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Consolas : Producto
    {

        [Required(ErrorMessage = "Campo requerido.")]
        [Display(Name = "Capacidad de Almacenamiento")]
        public string CapacidadAlmacenamientoConsola { get; set; }
        [Required(ErrorMessage = "Campo requerido.")]
        [Display(Name = "Tipo de Almacenamiento")]

        public TipoAlmacenamiento TipoAlmacenamiento { get; set; }
        [Required(ErrorMessage = "Campo requerido.")]
        [Display(Name = "Velocidad de RAM")]

        public string VelocidadMemoria { get; set; }
        [Required(ErrorMessage = "Campo requerido.")]
        [Display(Name = "Velocidad de Procesamiento")]

        public string VelocidadProcesamiento { get; set; }
        [Required(ErrorMessage = "Campo requerido.")]
        [Display(Name = "Número de Controles")]

        public int NumeroControles { get; set; }

        /*public Consola(string NombreConsola, string VersionConsola, string FabricanteConsola, string CapacidadAlmacenamientoConsola, TipoAlmacenamiento TipoAlmacenamiento, string VelocidadMemoria, string VelocidadProcesamiento, int NumeroControles, double PrecioCompra, double PrecioVenta)
        {
            
        }*/
    }
}