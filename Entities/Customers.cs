using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Controls;
using warehouseManagement.Entities.Base;

namespace warehouseManagement.NewFolder
{
    class Customers : BaseEntity
    {
        [Key]
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string ContactInformation { get; set; }

        public ICollection<Orders> Orders { get; set; }
    }
}
