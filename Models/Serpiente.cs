using System;
using System.ComponentModel.DataAnnotations;

namespace Laboratorio14.Models
{
    public class Serpiente:Animal
    {
        [Required]
        public string EsVenenosa { get; set; }
        [Required]
        public int Longitud { get; set; }
    }
}
