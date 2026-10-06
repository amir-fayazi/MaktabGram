
using MaktabGram.Domain.Core.Users.Enum;
using MaktabGram.Domain.Core.Users.ValueObjects;

namespace MaktabGram.Domain.Core.Users.Entities
{
    public class UserProfile
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Email? Email { get; set; }
        public string Bio { get; set; }
        public bool IsPrivate { get; set; }
        public DateOnly BirthDate { get; set; }
        public GenderEnum Gender { get; set; }


        public User User { get; set; }
        public int UserId { get; set; }

        public void SetPrivate() => IsPrivate = true;
        public void SetPublic() => IsPrivate = false;
    }
}
