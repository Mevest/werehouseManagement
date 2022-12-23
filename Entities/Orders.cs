using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using warehouseManagement.Entities.Base;

namespace warehouseManagement.NewFolder
{
    class Orders
    {
        [Key]
        public int OrdersId { get; set; }
        public DateTime OrdersDate { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customers Customers { get; set; }

        public ICollection<OrderItem> OrderItem { get; set; }
    }
}
