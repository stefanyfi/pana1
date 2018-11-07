using System.ComponentModel.DataAnnotations;

namespace Panaderia.Models
{
    public class Empleado
    {
        public int Id { get; set; }

        [Required]
        public string Nombres { get; set; }
        [Required]
        public string Apellidos { get; set; }
        public Sucursal Sucursal { get; set; }
        public int? SucursalId { get; set; } // soporta nulos (AGREGACION)
        //public int SucursalId { get; set; } -> atributo fantasma:asociación (COMPOSICION)
    }
}