using MaktabGram.Domain.Core.Users.Entities;

namespace MaktabGram.Domain.Core.Posts.Entities
{
    public class PostSave
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
