using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using warehouseManagement.Entities.Base;

namespace warehouseManagement.NewFolder
{
    public class Location : BaseEntity
    {
        public string Aisle { get; set; }
        public string Shelf { get; set; }
        public string Bin { get; set; }

        public ICollection<Inventory> Inventory { get; set; }
    }
}
