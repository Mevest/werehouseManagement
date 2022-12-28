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
    class ShipmentItem : BaseEntity
    {
        [ForeignKey("Inventory")]
        public int ItemId { get; set; }
        public Inventory Inventory { get; set; } = null!;
        public int Quantity { get; set; }

        [ForeignKey("Shipment")]
        public int ShipmentId { get; set; }
        public Shipment Shipment { get; set; } = null!;
    }
}
