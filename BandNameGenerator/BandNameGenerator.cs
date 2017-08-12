using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandNameGenerator
{
    public class BandNameGenerator
    {
        public static string GenerateBandName(string str)
        {
            // Happy coding
            if (string.IsNullOrEmpty(str))
                throw new ArgumentException("input string should not be null or empty"); ;

            return IsStartELetterqualsEnd(str) ? DoCaption(str) + RemoveFirstLetter(str) : "The " + DoCaption(str);
        }

        private static bool IsStartELetterqualsEnd(string str)
        {
            var start = str[0].ToString();
            var end = str[str.Length - 1].ToString();

            return start.Equals(end);
        }

        private static string DoCaption(string str)
        {
            return str[0].ToString().ToUpper() + RemoveFirstLetter(str);
        }

        private static string RemoveFirstLetter(string str)
        {
            return str.Substring(1, str.Length - 1);
        }
    }
}
