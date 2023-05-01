using ASP.NET_API.Models.Post;

namespace ASP.NET_API.Services.Impl
{
    public class NewsService : INewsService
    {
        public Task<PostDto> AddPostAsync(PostDto postDto)
        {
            throw new NotImplementedException();
        }

        public Task DeletePostAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<PostDto>> FindPostByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<PostDto>> GetAllPostsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PostDto> GetPostByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
