using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Application.DTOs
{
    public class BillDto
    {   
       public int Id { get; set; } 
        public string BillNumber { get; set; }
        public DateTime BillDate { get; set; }
        public decimal Total { get; set; }
        public int CustomerId { get; set; }
        
    }
}