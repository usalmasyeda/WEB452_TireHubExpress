using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace TireHubExpress.Models
{
    public class TireTypeViewModel
    {
        public List<Tire> Tires { get; set; }
        public SelectList Types { get; set; }
        public string TireType { get; set; }
        public string SearchString { get; set; }
    }
}
