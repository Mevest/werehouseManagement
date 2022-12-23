using System.ComponentModel.DataAnnotations;

namespace warehouseManagement.Entities.Base
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
