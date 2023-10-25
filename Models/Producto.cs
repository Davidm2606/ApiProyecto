using System.ComponentModel.DataAnnotations;

namespace APIProductos.Models
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        
        public int Cantidad { get; set; }
        public int Valor { get; set; }
    }
}
