﻿using System.Collections.Generic;

namespace Buildweek1.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Brand { get; set; }
        public string Gender { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string Size { get; set; }
    }
}
