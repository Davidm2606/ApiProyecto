using System.ComponentModel.DataAnnotations;

namespace APIProductos.Models
{
   
  public class Empleados
    {
        [Key]
        public string? Cedula { get; set; }
        [Required]
        public string? Nombre { get; set; }
        [Required]

        public string? Apellido { get; set; }
        [Required]
        public int Edad { get; set; }
    }
    
    }

