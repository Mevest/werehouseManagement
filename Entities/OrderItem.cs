using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using warehouseManagement.NewFolder;

namespace warehouseManagement.Entities.Base
{
    class OrderItem
    {
        [Key]
        public int OrderItemId { get; set; }

        [ForeignKey("Inventory")]
        public int ItemId { get; set; }
        public Inventory Inventory { get; set; }
        public int Quantity { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public Orders Orders { get; set; }
    }
}
