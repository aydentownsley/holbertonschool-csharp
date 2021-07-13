using System;

class Character
{
    public static bool IsLower(char c)
    {
        if ((int)c > 64 && (int)c < 91)
            return false;
        else
            return true;
    }
}
