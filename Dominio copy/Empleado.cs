namespace Dominio
{
    public class Empleado
    {
        public int Id {get;set;}
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string DocumentoIdentificacion { get; set; }
        public ETipoEmpleado TipoEmpleado { get; set; }
        public string CodigoEmpleado { get; set; }
        public ESucursal Sucursal { get; set; }
        public string Usuario { get; set; }
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