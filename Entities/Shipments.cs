using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using warehouseManagement.Entities.Base;

namespace warehouseManagement.NewFolder
{
    class Shipments
    {
        [Key]
        public int ShipmentId { get; set; }
        public DateTime ShipDate { get; set; }
        public string Destination { get; set; }

        public ICollection<ShipmentItem> ShipmentItems { get; set; }
    }
}
