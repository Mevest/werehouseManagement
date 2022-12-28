using System.ComponentModel.DataAnnotations.Schema;
using warehouseManagement.Entities.Base;

namespace warehouseManagement.NewFolder
{
    public class Inventory : BaseEntity
    {
        public string ItemName { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }

        [ForeignKey("Location")]
        public int LocationId { get; set; }
        public Location Location { get; set; }
    }
}
