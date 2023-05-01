using ASP.NET_API.Models.Post;

namespace ASP.NET_API.Services
{
    public interface INewsService
    {
        public Task<ICollection<PostDto>> GetAllPostsAsync();
        public Task<ICollection<PostDto>> FindPostByNameAsync(string name);
        public Task<PostDto> GetPostByIdAsync(Guid id);
        public Task<PostDto> AddPostAsync(PostDto postDto);
        public Task DeletePostAsync(Guid id);

    }
}
