using System.Text.RegularExpressions;

namespace MaktabGram.Domain.Core.UserAgg.ValueObjects;

public class Email
{
    #region Properties

    public string Value { get; }

    #endregion

    #region Constructors

    private Email(string value)
    {
        Value = value;
    }

    #endregion

    #region Factory

    public static Email Create(string value)
    {
        var normalizedValue = Normalize(value);
        Validate(normalizedValue);

        return new Email(normalizedValue);
    }

    #endregion

    #region Private Methods

    private static string Normalize(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            throw new ArgumentException("Email cannot be empty.", nameof(input));

        return input.Trim().ToLowerInvariant();
    }

    private static void Validate(string email)
    {
        if (email.Length > 254)
            throw new ArgumentException("Email is too long.", nameof(email));

        if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            throw new ArgumentException("Email format is invalid.", nameof(email));
    }

    #endregion

    public override string ToString() => Value;
}
