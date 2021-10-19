using System.ComponentModel.DataAnnotations;


namespace Dominio
{
    public class VideoJuego : Producto
    {
        [Required(ErrorMessage = "Campo requerido.")]

        public ETipoConsola Plataforma { get; set; }

    }
}