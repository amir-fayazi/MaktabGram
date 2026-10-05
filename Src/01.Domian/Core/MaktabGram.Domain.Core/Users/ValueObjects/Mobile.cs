

using System.Text.RegularExpressions;

namespace MaktabGram.Domain.Core.Users.ValueObjects
{
    public class Mobile
    {

        //normalize
        // validate

        public string Value { get; }

        private Mobile(string value)
        {
            Value = value;
        }

        public static Mobile Create(string value)
        {
            var normalizedValue = Normalize(value);
            Validate(normalizedValue);

            return new Mobile(normalizedValue);
        }

        private static string Normalize(string input)
        {
            var digitsOnly = Regex.Replace(input, @"[^\d]", "");

            if (digitsOnly.StartsWith("98")) // 989361234567
            {
                digitsOnly = "0" + digitsOnly.Substring(2);
            }else if (digitsOnly.StartsWith("0098"))
            {
                digitsOnly = "0" + digitsOnly.Substring(4);

            }

            return digitsOnly;
        }

        private static void Validate(string mobile)
        {
            if (!Regex.IsMatch(mobile, @"^09\d{9}$"))
            {
                throw new Exception("شماره موبایل نامعتبر است.");
            }
        }

        public override string ToString()
        {
            return Value;
        }

    }
}
