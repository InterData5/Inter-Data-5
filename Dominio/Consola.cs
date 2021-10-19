namespace Dominio
{
    public class Consola : Producto
    {
        public int Almacenamiento { get; set; }

        public ETipoAlmacenamiento Tipo { get; set; }

        public int VelocidadRAM { get; set; }

        public int VelocidadProcesador { get; set; }

        public int NumeroControles { get; set; }

        public Consola(){} // metodo constructor vacio, que no necesita argumentos

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