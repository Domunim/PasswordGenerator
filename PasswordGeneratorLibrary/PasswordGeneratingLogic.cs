using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGeneratorLibrary
{
    public class PasswordGeneratingLogic
    {

        /// <summary>
        /// Generates a string of pseudo-random characters of given length.
        /// </summary>
        /// <param name="finalLength"></param>
        /// <returns>string of random characters of a given lenght</returns>

        public static string GenerateRandomPart(int finalLength, string charType)
        {
            var stringChars = new char[finalLength];

            Random random = new();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = charType[random.Next(charType.Length)];
            }

            string randomPart = new(stringChars);

            return randomPart;

        }

        /// <summary>
        /// Combines given keyword with a random string.
        /// </summary>
        /// <param name="finalLength"></param>
        /// <param name="keyword"></param>
        /// <param name="charType"></param>
        /// <returns>Final password in a simple model.</returns>
        public static string GenerateSimplePassword(int finalLength, string keyword, string charType)
        {

            if (finalLength - keyword.Length > 0)
            {
                string simplePassword = keyword + GenerateRandomPart(finalLength - keyword.Length, charType);
                return simplePassword;
            }
            else
            {
                return keyword;
            }

        }

        public static string ReplaceKeywordChars(string keyword)
        {
            return keyword.Replace('o', '0').Replace('a', '@').Replace('i', '!').Replace('s', '$').Replace('b', '8');
        }

    }
}
