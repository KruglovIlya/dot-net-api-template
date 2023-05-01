using ASP.NET_API.Entities.Post;
using ASP.NET_API.Models.Post;
using AutoMapper;

namespace ASP.NET_API.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<PostEntity, PostDto>().ReverseMap();
            CreateMap<PostAttachmentEntity, PostAttachmentDto>().ReverseMap();
        }
    }
}
