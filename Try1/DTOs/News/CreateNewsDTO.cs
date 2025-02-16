using System.ComponentModel.DataAnnotations;

namespace Try1.DTOs.News
{
    public class CreateNewsDTO
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
