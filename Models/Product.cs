using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductListingAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public decimal Price { get; set; }
    }
}