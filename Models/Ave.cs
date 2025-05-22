using System;
using System.ComponentModel.DataAnnotations;

namespace Laboratorio14.Models
{
    public class Ave: Animal
    {
        [Required]
        public string Vuela { get; set; }
        [Required]
        public int Longitud { get; set; }
    }
}
