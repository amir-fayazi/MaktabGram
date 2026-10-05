
using MaktabGram.Domain.Core.Comments;
using MaktabGram.Domain.Core._common;
using MaktabGram.Domain.Core.Users.Entities;

namespace MaktabGram.Domain.Core.Posts.Entities
{
      
    public class Post : BaseEntity
    {
        public string Description { get; set; }
        public string MediaUrl { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public List<Comment> Comments { get; set; } = new();
        public List<PostLike> PostLikes { get; set; } = new();
        public List<PostSave> PostSaves { get; set; } = new();
    }
}
