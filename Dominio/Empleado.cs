using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Empleado
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo requerido.")]

        public string Nombres { get; set; }
        [Required(ErrorMessage = "Campo requerido.")]

        public string Apellidos { get; set; }
        [Required(ErrorMessage = "Campo requerido.")]
        [Display(Name = "Documento de Identificación")]

        public string DocumentoIdentificacion { get; set; }
        [Required(ErrorMessage = "Campo requerido.")]
        [Display(Name = "Tipo de Empleado")]

        public ETipoEmpleado TipoEmpleado { get; set; }
        [Required(ErrorMessage = "Campo requerido.")]
        [Display(Name = "Código de Empleado")]

        public string CodigoEmpleado { get; set; }
        [Required(ErrorMessage = "Campo requerido.")]

        public ESucursal Sucursal { get; set; }
        [Required(ErrorMessage = "Campo requerido.")]

        public string Usuario { get; set; }

        [Required(ErrorMessage = "Campo requerido.")]
        [Display(Name = "Contraseña")]
        public string Contrasenia { get; set; }

        public Empleado() { } // metodo constructor vacio, que no necesita argumentos

        public Empleado(string nombres, string apellidos, string documentoIdentificacion, ETipoEmpleado tipoEmpleado, string codigoEmpleado, ESucursal sucursal, string usuario, string contrasenia)
        {
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.DocumentoIdentificacion = documentoIdentificacion;
            this.TipoEmpleado = tipoEmpleado;
            this.CodigoEmpleado = codigoEmpleado;
            this.Sucursal = sucursal;
            this.Usuario = usuario;
            this.Contrasenia = contrasenia;

        }

    }
}