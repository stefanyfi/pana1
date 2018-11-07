using System.Collections.Generic;

namespace Panaderia.Models
{
    public class Sucursal
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public List<Empleado> Empleados { get; set; } //muchos a muchos 

        public Sucursal() {
            Empleados = new List<Empleado>();
            //inicializa una lista nueva 
        }
    }
}