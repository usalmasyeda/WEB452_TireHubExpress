using System;
using System.ComponentModel.DataAnnotations;

namespace TireHubExpress.Models
{
    public class Tire
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string Material { get; set; }

        [Required]
        public string  Durability { get; set; }

        [Required]
        public int Stock { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Range(1, 5)]
        public int Review { get; set; }

    }
}
