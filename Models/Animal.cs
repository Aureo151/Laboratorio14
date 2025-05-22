using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Laboratorio14.Models
{
    public class Animal
    {
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Especie { get; set; }
        [Required]
        public string Tipo { get; set; }
        [Required]
        public string Tipo_Alimentacion { get; set; }
        [Required]
        public int TiempoVida { get; set; }
        
        
    }
}
