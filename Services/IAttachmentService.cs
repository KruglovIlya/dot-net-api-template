using ASP.NET_API.Models.Post;

namespace ASP.NET_API.Services
{
    public interface IAttachmentService
    {
        public Task<PostAttachmentDto> AddAttachmentToPostAsync(Guid postId, PostAttachmentDto attachment);
        public Task<ICollection<PostAttachmentDto>> GetAttachmentsByPostIdAsync(Guid postId);

    }
}
