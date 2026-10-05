using MaktabGram.Domain.Core.Users.Entities;

namespace MaktabGram.Domain.Core.Comments
{
    public class CommentLike
    {
        public User User { get; set; }
        public int UserId { get; set; }

        public int CommentId { get; set; }
        public Comment Comment { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
