﻿

namespace Shop.Domain
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string? CategoryName { get; set; }
        public string? Description { get; set; }
        
        public string? CategoryPhoto { get; set; }
        public List<Product>? Product { get; set; }
    }
}
