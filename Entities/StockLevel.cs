using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using warehouseManagement.Entities.Base;

namespace warehouseManagement.NewFolder
{
    class StockLevel : BaseEntity
    {
        [ForeignKey("Inventory")]
        public int ItemId { get; set; }
        public Inventory Inventory { get; set; }
        public int CurrentLevel { get; set; }
        public int MinimumLevel { get; set; }
        public int MaximumLevel { get; set; }
    }
}
