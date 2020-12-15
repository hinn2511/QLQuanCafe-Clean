using Application.DTOs;
using System.Collections.Generic;

namespace QLQuanCafe.ViewModels
{
    public class BillDetailViewModel
    {
        public BillDto Bill;
        public int BillId { get; set; }
        public IEnumerable<BillDetailDto> BillDetails { get; set; }

        public IEnumerable<ProductDto> Product { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        
    }


}