using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using warehouseManagement.Entities.Base;

namespace warehouseManagement.Entities
{
    public class Location : BaseEntity
    {
        public string Aisle { get; set; } = null!;
        public string Shelf { get; set; } = null!;
        public string Bin { get; set; } = null!;

        public ICollection<Inventory> Inventory { get; set; } = null!;
    }
}
