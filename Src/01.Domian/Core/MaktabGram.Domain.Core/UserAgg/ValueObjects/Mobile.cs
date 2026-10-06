using System.Text.RegularExpressions;

namespace MaktabGram.Domain.Core.UserAgg.ValueObjects;

public class Mobile
{
    #region Properties

    public string Value { get; }

    #endregion

    #region Constructors

    private Mobile(string value)
    {
        Value = value;
    }

    #endregion

    #region Factory

    public static Mobile Create(string value)
    {
        var normalizedValue = Normalize(value);
        Validate(normalizedValue);

        return new Mobile(normalizedValue);
    }

    #endregion

    #region Private Methods

    private static string Normalize(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            throw new ArgumentException("Mobile cannot be empty.", nameof(input));

        var digitsOnly = Regex.Replace(input, @"[^\d]", string.Empty);

        if (digitsOnly.StartsWith("0098"))
        {
            digitsOnly = "0" + digitsOnly[4..];
        }
        else if (digitsOnly.StartsWith("98"))
        {
            digitsOnly = "0" + digitsOnly[2..];
        }

        return digitsOnly;
    }

    private static void Validate(string mobile)
    {
        if (!Regex.IsMatch(mobile, @"^09\d{9}$"))
            throw new ArgumentException("شماره موبایل نامعتبر است.", nameof(mobile));
    }

    #endregion

    public override string ToString() => Value;
}
