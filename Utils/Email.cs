using System;
using System.Text.RegularExpressions;

namespace Utils
{
    public static class Email
    {
        public static bool IsValidEmail(string candidatingEmail)
        {
            string regexPattern = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";

            if (String.IsNullOrWhiteSpace(candidatingEmail))
                return false;

            try
            {
                return Regex.IsMatch(candidatingEmail, regexPattern, RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
    }
}
