using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MergeTable
{
    public static class Extentions
    {
        /// <summary>
        /// Checks to see if the text matches, but the casing of the text does not match.
        /// </summary>
        /// <param name="str1">string to compare</param>
        /// <param name="str2">string to compare</param>
        /// <returns>true if the text matches, but the casing of the text does not match</returns>
        public static bool MatchesTextButNotCase(this string str1, string str2)
        {
            // Text doesnt even match //
            if (!str1.Equals(str2, StringComparison.OrdinalIgnoreCase)) return false;

            // Text and casing MATCH //
            if (str1.Equals(str2, StringComparison.Ordinal)) return false;

            return true;
        }
    }
}
