using System.Text.RegularExpressions;

namespace Domain.ValueObjects
{
    public partial record PhoneNumber
    {

        private const int DefaultLength = 9;
        private const string Pattern = @"^(?:-*\d-*){8}$";

        private PhoneNumber(string value) => Value = value;

        public string Value { get; init; }

        public static PhoneNumber? Create(string value)
        {

            if (string.IsNullOrEmpty(value) || !PhoneNumberRegexp().IsMatch(value) || value.Length != DefaultLength)
            {
                return null;
            }

            return new PhoneNumber(value);

        }


        [GeneratedRegex(Pattern)]
        private static partial Regex PhoneNumberRegexp();

    }
}
