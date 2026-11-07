using MaktabGram.Domain.Core.UserAgg.Enum;
using MaktabGram.Domain.Core.UserAgg.ValueObjects;

namespace MaktabGram.Domain.Core.UserAgg.Entities;

public class UserProfile
{
    #region Properties

    public int Id { get; set; }

    public string? FirstName { get; set; } 
    public string? LastName { get; set; } 
    public Email? Email { get; set; }
    public string? Bio { get; set; } 

    public bool IsPrivate { get; private set; }
    public DateOnly BirthDate { get; set; }
    public GenderEnum Gender { get; set; }

    #endregion

    #region Navigation Properties

    public int UserId { get; set; }
    public User User { get; set; } = null!;

    #endregion

    #region Behaviors

    public void SetPrivate() => IsPrivate = true;
    public void SetPublic() => IsPrivate = false;

    #endregion
}
