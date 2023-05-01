using ASP.NET_API.Entities.Post;

namespace ASP.NET_API.Repositories
{
    public interface IPostRepository
    {
        public Task<ICollection<PostEntity>> GetAllAsync();
        public Task<ICollection<PostEntity>> GetAllNotRemovedAsync();
        public Task<ICollection<PostEntity>> FindByNameAsync(string name);
        public Task<PostEntity> GetAsync(Guid id);
        public Task DeleteAsync(Guid id);
        public Task AddAsync(PostEntity post);
        public Task AddAttachmentAsync(Guid postId, PostAttachmentEntity attachment);
        public Task<ICollection<PostAttachmentEntity>> GetAttachmentsByPostAsync(Guid postId);
    }
}
