using System;

namespace Text
{
    /// <summary>
    /// A class for manipulatig strings
    /// </summary>
    public class Str
    {
        /// <summary>
        /// A method for splitting a string into words
        /// </summary>
        public static int CamelCase(string s)
        {
            int count = 0;

            if (s == null)
                return 0;
            if (s.Length == 0)
                return 0;

            foreach (char c in s)
            {
                if (Char.IsUpper(c))
                    count++;
            }
            count += 1;
            return count;
        }
    }
}
