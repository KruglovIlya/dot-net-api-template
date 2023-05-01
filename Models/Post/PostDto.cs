using ASP.NET_API.Entities.Post;
using System.ComponentModel.DataAnnotations;

namespace ASP.NET_API.Models.Post
{
    public class PostDto
    {
        public Guid Id { get; set; }

        // IsDeleted not set, because it is not needful in this

        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Body { get; set; } = string.Empty;
        public ICollection<PostAttachmentDto> Attachments { get; set; } = new List<PostAttachmentDto>();

    }
}
