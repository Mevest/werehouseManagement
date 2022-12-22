using System.ComponentModel.DataAnnotations;

namespace werehouseManagement.Entities.Base
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
