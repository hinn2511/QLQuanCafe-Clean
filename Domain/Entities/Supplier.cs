using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Entities.Common;

namespace Domain.Entities.SupplierAggregate
{
    public class Supplier : EntityBase
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierPhoneNumber { get; set; }
        public string SupplierAddress { get; set; } 
        public string SupplierEmail { get; set; }


    }
}