using System;

namespace Text
{
    public class Str
    {
        public static int UniqueChar(string s)
        {
            char c;
            int pos = 0;
            int x = 1;
            if (s == null)
                return -1;

            c = s[0];
            pos = 0;
            while (x < s.Length)
            {
                if (s[x + 1] != null)
                {
                    if (c == s[x + 1])
                    {
                        if (s[x + 2] != null)
                        {
                            c = s[x + 2];
                            x = x + 2;
                            pos = x;
                        }
                        else
                            return (-1);
                    }
                    else
                        return (-1);
                }
                return pos;
            }
            return (x);
        }
    }
}
