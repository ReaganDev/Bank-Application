using System;
using System.Text.RegularExpressions;

namespace Raph.Commons
{
    public class Utilities
    {
        /// <summary>
        /// valid mail
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool ValidEmail(string email)
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                                    + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(email);

        }


        /// <summary>
        /// remove Digit from start
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static string RemoveDigitFromStart(string val)
        {
            var str = val.Substring(0, 1).ToCharArray();
            var strCode = (int)str[0];
            if (strCode >= 48 && strCode <= 57)
            {
                return RemoveDigitFromStart(val[1..]);
            }

            return val;
        }



        /// <summary>
        /// Change first character to caps
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static string FirstCharacterToUpper(string val)
        {
            var str = val.Substring(0, 1).ToCharArray();
            var strCode = (int)str[0];
            if (strCode >= 97)
            {
                var strCaps = strCode - 32;
                return (char)strCaps + val[1..];
            }

            return val;
        }

        //method to look up connection string 


    }
}
