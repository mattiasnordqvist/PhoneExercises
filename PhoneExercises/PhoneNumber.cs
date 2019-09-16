using System;
using System.Linq;

namespace PhoneExercises
{
    public class PhoneNumber
    {
        private static string[] ValidCountryCodes = { "+46", "+30", "+47" };
        public string Value { get; }

        public PhoneNumber(string phoneNumber)
        {
            phoneNumber = phoneNumber.Replace(" ", "");
            if (phoneNumber[0] == '-')
            {
                throw new ArgumentException("PhoneNumber is invalid");
            }
            phoneNumber = phoneNumber.Replace("-", "");
            if (phoneNumber.Length < 3)
            {
                throw new ArgumentException("phoneNumber is too short.");
            }
            if (phoneNumber[0] == '+' && !ValidCountryCodes.Contains(phoneNumber.Substring(0, 3)))
            {
                throw new ArgumentException("Internation phone number does not have a valid country code");
            }
            if (!long.TryParse(phoneNumber, out var _))
            {
                throw new ArgumentException("phoneNumber is not a valid phone number");
            }
            else
            {
                Value = phoneNumber;
            }
        }

    }
}