using MaktabGram.Domain.Core._common;
using MaktabGram.Domain.Core.Posts.Entities;
using MaktabGram.Domain.Core.Users.Entities;

namespace MaktabGram.Domain.Core.Comments.Entities
{
    public class Comment : BaseEntity
    {
        public string Text { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }

        public Post Post { get; set; }
        public int PostId { get; set; }


        public List<CommentLike> CommentLikes { get; set; } = [];

        public int? ParentCommentId { get; set; }
        public Comment? ParentComment { get; set; }

        public List<Comment> Replies { get; set; } = [];


    }
}
