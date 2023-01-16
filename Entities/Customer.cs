using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Controls;
using warehouseManagement.Entities.Base;

namespace warehouseManagement.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string Company { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Email { get; set; } = null!;

        public ICollection<Order> Orders { get; set; } = null!;
    }
}
