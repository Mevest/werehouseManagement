using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Controls;
using warehouseManagement.Entities.Base;

namespace warehouseManagement.NewFolder
{
    class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string ContactInformation { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
