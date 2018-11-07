using System.Collections.Generic;

namespace Panaderia.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Foto { get; set; }
        public List<ProductoCategoria> ProductosCategorias { get; set; } // muchos a muchos 

        public Producto() {
            ProductosCategorias = new List<ProductoCategoria>(); 
            //inicializa una lista vacia 
        }
    }
}