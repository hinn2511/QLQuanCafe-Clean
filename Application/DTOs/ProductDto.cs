using System;
using System.ComponentModel.DataAnnotations;

namespace Application.DTOs
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductAvailable { get; set; }        
        public string ProductType { get; set; } 
        public DateTime ProductAddingDate { get; set; }
        
    }
}