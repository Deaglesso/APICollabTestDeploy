using System.ComponentModel.DataAnnotations;

namespace Try1.DTOs.News
{
    public class GetNewsDTO
    {
        
        public Guid Id { get; set; }
        public required string Title { get; set; }
        public required string Content { get; set; }
        public required DateTime PublishedDate { get; set; }
        public string? ImageUrl { get; set; }
    }
}
