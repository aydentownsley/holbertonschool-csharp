using System;

namespace Text
{
    /// <summary>
    /// Methods to break down string
    /// </summary>
    public class Str
    {
        /// <summary>
        /// searches for unique char in a string
        /// </summary>
        public static int UniqueChar(string s)
        {
            int c;

            if (s == null)
                return (-1);
            else
                s = s.ToLower();

            char [] a = s.ToCharArray();

            for (int x = 0; x < a.Length; x++)
            {
                c = 0;
                for (int y = 0; y < a.Length; y++)
                {
                    if (x != y)
                    {
                        if (a[x] == a[y])
                            c++;
                    }
                }
                if (c == 0)
                    return (x);
            }
            return (-1);
        }
    }
}
