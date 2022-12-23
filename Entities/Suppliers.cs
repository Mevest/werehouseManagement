using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using warehouseManagement.Entities.Base;

namespace warehouseManagement.NewFolder
{
    class Suppliers
    {
        [Key]
        public int SupplierId { get; set; }
        public string Name { get; set; }
        public string ContactInformation { get; set; }

        public ICollection<Inventory> Inventory { get; set; }
    }
}
