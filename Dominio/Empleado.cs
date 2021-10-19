using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Empleado : Usuario
    {
        [Required(ErrorMessage = "Campo requerido.")]
        [Display(Name = "Código de Empleado")]

        public int CodigoEmpleado {get; set;}
        
        public string Sucursal {get; set;}
        public Rol rol {get; set;}
                [Required(ErrorMessage = "Campo requerido.")]
        [Display(Name = "Acceso a Reportes")]

        public bool AccesoReportes {get; set;}
        /*public Empleado(string Nombre, string Apellido, string Cedula, string Sucursal, Rol rol, string User, string Pass):base( Nombre, Apellido, Cedula, User, Pass) 
        {
            
        }*/
    }
}

