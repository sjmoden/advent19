using System;
using System.Text.RegularExpressions;

namespace DayFour
{
    public static class PasswordValidator
    {
        public static ValidPasswordEnum ValidationException(int password)
        {
            var valid = ValidPasswordEnum.Neither;

            var digits = Array.ConvertAll(password.ToString().ToCharArray(),c => int.Parse(c.ToString()));

            if (!CheckLength(password.ToString()) || !CheckIncreasingValues(digits))
            {
                return valid;
            }

            
            if (CheckDuplicateDigits(password.ToString()))
            {
                valid = ValidPasswordEnum.Original;
            }

            if (CheckNewDuplicateDigits(password.ToString()))
            {
                if (valid == ValidPasswordEnum.Original)
                {
                    return ValidPasswordEnum.Both;
                }
                valid = ValidPasswordEnum.New;
            }

            return valid;
        }

        private static bool CheckLength(string password)
        {
            return password.Length == 6;
        }

        private static bool CheckIncreasingValues(int[] digits)
        {
            var previousDigit = 0;
            foreach (var digit in digits)
            {
                if (previousDigit > digit)
                {
                    return false;
                }
                previousDigit = digit;
            }

            return true;
        }

        private static bool CheckDuplicateDigits(string password)
        {
            var  pattern = @"([0-9])\1";
            var rgx = new Regex(pattern);
            return rgx.IsMatch(password);
        }

        public static bool CheckNewDuplicateDigits(string password)
        {
            var pattern = @"([^1]|^)(1){2}([^1]|$)|([^2]|^)(2){2}([^2]|$)|([^3]|^)(3){2}([^3]|$)|([^4]|^)(4){2}([^4]|$)|([^5]|^)(5){2}([^5]|$)|([^6]|^)(6){2}([^6]|$)|([^7]|^)(7){2}([^7]|$)|([^8]|^)(8){2}([^8]|$)|([^9]|^)(9){2}([^9]|$)|([^0]|^)(0){2}([^0]|$)";
            var rgx = new Regex(pattern);
            return rgx.IsMatch(password);
        }
    }
}
