using System.ComponentModel.DataAnnotations;

namespace APIProductos.Models
{
    public class Platos
    {
        [Key]
        public int IdPlato { get; set; }
        [Required]
        public string? Nombre { get; set; }
        [Required]
        
        public string? Ingredientes { get; set; }
        public int Cantidad { get; set; }
        [Required]
        public int Precio { get; set; }
    }

    
}
