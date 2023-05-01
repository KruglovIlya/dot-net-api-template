using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;

namespace ASP.NET_API.Entities.Post
{
    public class PostEntity
    {
        [BsonId(IdGenerator = typeof(GuidGenerator))]
        public Guid Id { get; set; }
        public bool IsDeleted { get; set; } = false;
        public string Name { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public ICollection<PostAttachmentEntity> Attachments { get; set; } = new List<PostAttachmentEntity>();
    }
}
