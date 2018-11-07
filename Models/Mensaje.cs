using System.ComponentModel.DataAnnotations;

namespace Panaderia.Models
{
    public class Mensaje
    {
        public int Id { get; set; }
        
        [EmailAddress]
        [Required]
        public string Correo { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Texto { get; set; }
    }
}