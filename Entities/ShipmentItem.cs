﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using warehouseManagement.NewFolder;

namespace warehouseManagement.Entities.Base
{
    class ShipmentItem
    {
        [Key]
        public int ShipmentItemId { get; set; }

        [ForeignKey("Inventory")]
        public int ItemId { get; set; }
        public Inventory Inventory { get; set; }
        public int Quantity { get; set; }

        [ForeignKey("Shipment")]
        public int ShipmentId { get; set; }
        public Shipments Shipments { get; set; }
    }
}