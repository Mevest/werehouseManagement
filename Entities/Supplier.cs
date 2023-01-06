using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using warehouseManagement.Entities.Base;

namespace warehouseManagement.Entities
{
    public class Supplier : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Email { get; set; } = null!;

        public ICollection<Inventory> Inventory { get; set; } = null!;
    }
}
