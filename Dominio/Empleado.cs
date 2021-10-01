namespace Dominio
{
    public class Empleado : Usuario
    {
        public int CodigoEmpleado {get; set;}
        public string Sucursal {get; set;}
        public Rol rol {get; set;}
        public bool AccesoReportes {get; set;}
        /*public Empleado(string Nombre, string Apellido, string Cedula, string Sucursal, Rol rol, string User, string Pass):base( Nombre, Apellido, Cedula, User, Pass) 
        {
            
        }*/
    }
}

