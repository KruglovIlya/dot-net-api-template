using ASP.NET_API.Exceptions;
using ASP.NET_API.Models.Post;
using ASP.NET_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommonController : ControllerBase
    {
        private readonly ILogger<CommonController> _logger;
        private readonly INewsService _newsService;
        private readonly IAttachmentService _attachmentService;

        public CommonController(ILogger<CommonController> logger, INewsService newsService, IAttachmentService attachmentService)
        {
            _logger = logger;
            _newsService = newsService;
            _attachmentService = attachmentService;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<PostDto>>> GetAll()
        {
            var posts = await _newsService.GetAllPostsAsync();

            return Ok(posts);
        }

        [HttpPost]
        public async Task<ActionResult<PostDto>> CreatePost(PostDto createPost)
        {
            try
            {
                var post = await _newsService.AddPostAsync(createPost);

                return post;
            }
            catch (CommonApiUserException ex)
            {
                return BadRequest(new { errorText = ex.Message });
            }
        }
    }
}