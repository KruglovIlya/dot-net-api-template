using ASP.NET_API.Models.Post;

namespace ASP.NET_API.Services.Impl
{
    public class AttachmentService : IAttachmentService
    {
        public Task<PostAttachmentDto> AddAttachmentToPostAsync(Guid postId, PostAttachmentDto attachment)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<PostAttachmentDto>> GetAttachmentsByPostIdAsync(Guid postId)
        {
            throw new NotImplementedException();
        }
    }
}
