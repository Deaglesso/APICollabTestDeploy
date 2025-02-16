using System.ComponentModel.DataAnnotations;

namespace Try1.Entities.Base
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
    }
}
