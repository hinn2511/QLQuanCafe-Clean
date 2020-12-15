using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.DTOs
{
    public class BillDetailDto
    {
        public int Id { get; set; }       
        public int BillId { get; set; }    
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal BillDetailTotal { get; set; }
        
    }
}