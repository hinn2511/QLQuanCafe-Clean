using Domain.Entities.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.BillAggregate
{
    public class BillDetail : EntityBase
    {
        //public ProductOrdered ProductOrdered { get; set; }
        [ForeignKey("BillId")]
        public virtual Bill Bill { get; set; }

        public int BillId { get; set; }
        
        [ForeignKey("ProductId")]        
        public virtual Product Product { get; set; }

        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal BillDetailTotal { get; set; }

    }
}