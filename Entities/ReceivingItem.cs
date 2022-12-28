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
    class ReceivingItem : BaseEntity
    {
        [ForeignKey("Inventory")]
        public int ItemId { get; set; }
        public Inventory Inventory { get; set; } = null!;
        public int Quantity { get; set; }

        [ForeignKey("Receiving")]
        public int ReceivingId { get; set; }
        public Receiving Receiving { get; set; } = null!;
    }
}
