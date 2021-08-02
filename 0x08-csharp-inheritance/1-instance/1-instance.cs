using System;
using System.Collections.Generic;

/// <summary>
/// Containes method testing for inheritance
/// from a specific type.
/// </summary>
public class Obj
{
    /// <summary>Checks if obj is inhereited from Array.</summary>
    /// <param name="obj">Object to check.</param>
    public static bool IsInstanceOfArray(object obj)
    {
        if (typeof(Array).IsInstanceOfType(obj))
            return true;
        return false;
    }
}
