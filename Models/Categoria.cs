using System.Collections.Generic;

namespace Panaderia.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<ProductoCategoria> ProductosCategorias { get; set; } //muchos a muchos 

        public Categoria() {
            ProductosCategorias = new List<ProductoCategoria>(); 
            //inicializa un lista vacia 
        }
    }
}