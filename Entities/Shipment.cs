using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using warehouseManagement.Entities.Base;

namespace warehouseManagement.Entities
{
    class Shipment : BaseEntity
    {
        public DateTime ShipDate { get; set; }
        public string Destination { get; set; } = null!;

        public ICollection<ShipmentItem> ShipmentItems { get; set; } = null!;
    }
}
