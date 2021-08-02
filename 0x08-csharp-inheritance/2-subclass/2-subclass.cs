using System;

/// <summary>
/// Contains method for testing inheritance.
/// </summary>
public class Obj
{
    /// <summary>
    /// Checks if derivedType is instance of inherited type.
    /// </summary>
    /// <param name="derivedType">Derived type.</param>
    /// <param name="inheritedType">Inherited type.</param>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.IsSubclassOf(baseType))
            return true;
        return false;
    }
}
