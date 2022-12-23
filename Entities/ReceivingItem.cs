using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using warehouseManagement.NewFolder;

namespace warehouseManagement.Entities.Base
{
    class ReceivingItem
    {
        [Key]
        public int ReceivingId { get; set; }
        public DateTime ReceivingDate { get; set; }

        [ForeignKey("Supplier")]
        public int SupplierId { get; set; }
        public Suppliers Supplier { get; set; }

        public ICollection<ReceivingItem> ReceivingItems { get; set; }
    }
}
