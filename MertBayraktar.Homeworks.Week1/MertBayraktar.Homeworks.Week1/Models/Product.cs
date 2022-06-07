using System.ComponentModel.DataAnnotations;

namespace MertBayraktar.Homeworks.Week1.Models
{
    public class Product
    {

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public float Price { get; set; }




    }
}
