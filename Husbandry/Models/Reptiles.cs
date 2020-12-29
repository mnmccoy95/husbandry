using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Husbandry.Models
{
    public class Reptiles
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Temperature { get; set; }
        public string Humidity { get; set; }
        public string Difficulty { get; set; }
        public string Price { get; set; }
        public string CareFrequency { get; set; }
        public string Availability { get; set; }
        public string Handleability { get; set; }
    }
}
