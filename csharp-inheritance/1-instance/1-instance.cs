using System;
using System.Collections.Generic;
/// <summary> class Obj </summary>
public class Obj
{
    /// <summary> IsInstanceOfArray method </summary>
    public static bool IsInstanceOfArray(object obj)
    {
        if (obj.GetType() == typeof(Array) || obj is Array)
            return true;
        return false;
    }
}