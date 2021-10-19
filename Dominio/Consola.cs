using System.ComponentModel.DataAnnotations;


namespace Dominio
{
    public class Consola : Producto
    {
        [Required(ErrorMessage = "Campo requerido.")]

        public int Almacenamiento { get; set; }
        [Required(ErrorMessage = "Campo requerido.")]

        [Display(Name = "Contraseña")]

        public ETipoAlmacenamiento Tipo { get; set; }
        [Required(ErrorMessage = "Campo requerido.")]
        [Display(Name = "Velocidad de RAM")]

        public int VelocidadRAM { get; set; }
        [Required(ErrorMessage = "Campo requerido.")]
        [Display(Name = "Velocidad de Procesador")]

        public int VelocidadProcesador { get; set; }
        [Required(ErrorMessage = "Campo requerido.")]
        [Display(Name = "Número de Controles")]

        public int NumeroControles { get; set; }

        public Consola() { } // metodo constructor vacio, que no necesita argumentos

        public Consola(int almacenamiento, ETipoAlmacenamiento tipo, int velocidadRAM, int velocidadProcesador, int numeroControles)
        {
            this.Almacenamiento = almacenamiento;
            this.Tipo = tipo;
            this.VelocidadRAM = velocidadRAM;
            this.VelocidadProcesador = velocidadProcesador;
            this.NumeroControles = numeroControles;

        }
    }
}