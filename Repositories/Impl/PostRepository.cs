using ASP.NET_API.Entities.Post;

namespace ASP.NET_API.Repositories.Impl
{
    public class PostRepository : IPostRepository
    {
        public Task AddAsync(PostEntity post)
        {
            throw new NotImplementedException();
        }

        public Task AddAttachmentAsync(Guid postId, PostAttachmentEntity attachment)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<PostEntity>> FindByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<PostEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<PostEntity>> GetAllNotRemovedAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PostEntity> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<PostAttachmentEntity>> GetAttachmentsByPostAsync(Guid postId)
        {
            throw new NotImplementedException();
        }
    }
}
