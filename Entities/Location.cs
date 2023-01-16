using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using warehouseManagement.Entities.Base;

namespace warehouseManagement.Entities
{
    public class Location : BaseEntity
    {
        public int Aisle { get; set; }
        public int Shelf { get; set; }
        public int Bin { get; set; }

        public ICollection<Inventory> Inventory { get; set; } = null!;
    }
}
