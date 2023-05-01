using System.ComponentModel.DataAnnotations;

namespace ASP.NET_API.Models.Post
{
    public class PostAttachmentDto
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Url { get; set; } = string.Empty;

    }
}
