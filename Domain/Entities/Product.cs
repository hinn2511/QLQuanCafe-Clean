using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using Domain.Entities.BillAggregate;

namespace Domain.Entities
{
    public class Product : EntityBase, IAggregateRoot
    {
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductAvailable { get; set; }        
        public string ProductType { get; set; } 
        public DateTime ProductAddingDate { get; set; }
        public virtual IList<BillDetail> BillDetails { get; set; }
    }
}