using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Entities.Common;
using System.Collections.Generic;
using Domain.Entities.BillAggregate;

namespace Domain.Entities.CustomerAggregate
{
    public class Customer : EntityBase,IAggregateRoot
    {
        public string CustomerName { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string CustomerAddress { get; set; } 
        public string CustomerEmail { get; set; }
        public virtual IList<Bill> Bills { get; set; }


    }
}