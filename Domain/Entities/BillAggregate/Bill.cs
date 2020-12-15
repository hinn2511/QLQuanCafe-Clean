using System;
using System.Collections.Generic;
using Domain.Entities.Common;
using Domain.Entities.CustomerAggregate;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.BillAggregate 
{
    public class Bill : EntityBase, IAggregateRoot
    {
        public string BillNumber { get; set; }
        public DateTime BillDate { get; set; }
        public decimal Total { get; set; }

        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
        //public Customer 
        public virtual IList<BillDetail> BillDetails { get; set; }
        
    }
        
}