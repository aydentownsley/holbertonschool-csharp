using System;
using System.Collections.Generic;


/// <summary>
/// Class containting method for type checking
/// </summary>
public class Obj
{
    /// <summary>
    /// check input is of type int
    /// <param namme="obj">input object</param>
    /// </summary>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj is int)
            return true;
        return false;
    }
}
