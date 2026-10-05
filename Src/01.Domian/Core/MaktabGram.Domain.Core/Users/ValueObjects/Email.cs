

using System.Text.RegularExpressions;

namespace MaktabGram.Domain.Core.Users.ValueObjects
{
    public class Email
    {
        public string Value { get; }

        private Email(string value)
        {
            Value = value;
        }

        public static Email Create(string value)
        {
            var normalizedValue = Normalize(value);

            Validate(normalizedValue);

            return new Email(normalizedValue);
        }

        private static string Normalize(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentException("Email cannot be empty.");

            return input.Trim().ToLowerInvariant();
        }

        private static void Validate(string email)
        {
            if (email.Length > 254)
                throw new ArgumentException("Email is too long.");

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                throw new ArgumentException("Email format is invalid.");
        }

        public override string ToString() => Value;

    }
}
