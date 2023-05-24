using System;
using System.Collections.Generic;

/// <summary> class Obj </summary>
public class Obj
{
    /// <summary> IsOnlyASubclass method </summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.IsSubclassOf(baseType))
        {
            return true;
        }
        return false;
    }
}