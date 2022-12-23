using System.ComponentModel.DataAnnotations.Schema;
using warehouseManagement.Entities.Base;

namespace warehouseManagement.NewFolder
{
    class Inventory
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }

        [ForeignKey("Locations")]
        public int LocationId { get; set; }
        public Locations Locations { get; set; }
    }
}
