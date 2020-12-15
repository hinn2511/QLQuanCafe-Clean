using Domain.Entities.Common;
using System;

namespace Domain.Entities
{
    public class Tool : EntityBase, IAggregateRoot
    {
        public string ToolName { get; set; }
        public decimal ToolQuantity { get; set; }      
        public string ToolType { get; set; }
    }
}