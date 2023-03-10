using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using warehouseManagement.Entities;

namespace warehouseManagement.Entities.Base
{
    public class OrderItem : BaseEntity
    {
        [ForeignKey("Inventory")]
        public int ItemId { get; set; }
        public Inventory Inventory { get; set; } = null!;
        public int Quantity { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public Order Order { get; set; } = null!;
    }
}
