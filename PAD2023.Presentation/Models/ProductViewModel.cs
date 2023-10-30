﻿namespace PAD2023.Presentation.Models
{
    public class ProductViewModel
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public List<string>? ImageUrl { get; set; }
    }
}
