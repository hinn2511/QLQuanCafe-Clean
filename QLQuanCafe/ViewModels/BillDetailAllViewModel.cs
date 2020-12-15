using Application.DTOs;
using System.Collections.Generic;

namespace QLQuanCafe.ViewModels
{
    public class BillDetailAllViewModel
    {
        public IEnumerable<BillDetailDto> BillDetails { get; set; }
         public int Id { get; set; }       
        public int BillId { get; set; }    
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal BillDetailTotal { get; set; }
        
    }


}