using System;
using System.ComponentModel.DataAnnotations;

namespace TireHubExpress.Models
{
    public class Tire
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Type { get; set; }
        public string Material { get; set; }
        public string  Durability { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int Review { get; set; }

    }
}
