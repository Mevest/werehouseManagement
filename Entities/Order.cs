using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using warehouseManagement.Entities.Base;

namespace warehouseManagement.Entities
{
    public class Order : BaseEntity
    {
        public DateTime OrderDate { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; } = null!;
    }
}
