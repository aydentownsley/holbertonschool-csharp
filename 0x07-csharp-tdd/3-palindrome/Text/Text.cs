using System;

namespace Text
{
    public class Str
    {
        public static bool IsPalindrome(string s)
        {
            int x, y;
            if (s == null)
                return false;

            s = s.ToLower();
            x = 0;
            y = s.Length - 1;

            while (x < s.Length / 2)
            {
                if ((s[x] < 'A' || s[x] > 'Z') && (s[x] < 'a' || s[x] > 'z'))
                    x++;
                else if ((s[y] < 'A' || s[y] > 'Z') && (s[y] < 'a' || s[y] > 'z'))
                    y--;
                else if (s[x] != s[y])
                    return false;
                else
                {
                    x++;
                    y--;
                }
            }
            return true;
        }
    }
}
