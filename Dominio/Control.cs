namespace Dominio
{
    public class Control : Producto
    {
        public ETipoControl Tipo { get; set; }

        public Control() { } // metodo constructor vacio, que no necesita argumentos

        public Control(ETipoControl tipo)
        {
            this.Tipo = tipo;

        }
    }
}