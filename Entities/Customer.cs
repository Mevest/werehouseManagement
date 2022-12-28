using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Controls;
using warehouseManagement.Entities.Base;

namespace warehouseManagement.Entities
{
    class Customer : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string ContactInformation { get; set; } = null!;

        public ICollection<Order> Orders { get; set; } = null!;
    }
}
