using System.ComponentModel.DataAnnotations;
using Try1.Entities.Base;

namespace Try1.Entities
{
    public class News : BaseEntity
    {
        [Required]
        [StringLength(255)]
        public required string Title { get; set; }

        [Required]
        public required string Content { get; set; }

        [Required]
        public required DateTime PublishedDate { get; set; }

        public string? ImageUrl { get; set; }
    }
}
