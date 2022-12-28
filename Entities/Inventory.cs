using System.ComponentModel.DataAnnotations.Schema;
using warehouseManagement.Entities.Base;

namespace warehouseManagement.Entities
{
    public class Inventory : BaseEntity
    {
        public string ItemName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Quantity { get; set; }

        [ForeignKey("Location")]
        public int LocationId { get; set; }
        public Location Location { get; set; }
    }
}
