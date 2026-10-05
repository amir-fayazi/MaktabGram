
using MaktabGram.Domain.Core._common;
using MaktabGram.Domain.Core.Comments;
using MaktabGram.Domain.Core.Posts.Entities;
using MaktabGram.Domain.Core.Users.ValueObjects;

namespace MaktabGram.Domain.Core.Users.Entities
{
    public class User : BaseEntity
    {
        public Mobile Mobile { get; set; }
        public string Password { get; set; }

        //navigation props
        public List<Post> Posts { get; set; }

        public List<PostSave> PostSaves { get; set; } = new();
        public List<PostLike> PostLikes { get; set; } = new();
        public List<Comment> Comments { get; set; } = new();
        public List<User> Followers { get; set; } = new();
        public List<User> Followings { get; set; } = new();
        public List<CommentLike> CommentLikes { get; set; } = new();

    }


}
