using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Application.DTOs
{
    public class ProductOrderedDto
    {
        public int Id { get; set; } 
        public string ProductName { get; set; }
        public int ProductId { get; set; }
        public decimal ProductPrice { get; set; }
        
        
    }
}