﻿namespace Catalog.Api.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default; // default set to null when instantiate
        public List<string> Category { get; set; } = new();
        public string Description { get; set; } = default;
        public string ImageFile { get; set; } = default;
        public decimal Price { get; set; }
    }
}
