using System.ComponentModel.DataAnnotations;

namespace MertBayraktar.Homeworks.Week1.DTOs
{
    public class ProductUpdateDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public float Price { get; set; }
    }
}
