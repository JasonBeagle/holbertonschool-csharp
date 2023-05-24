using System;
using System.Collections.Generic;

/// <summary> base class Shape </summary>
public class Shape
{
    /// <summary> NotImplemented error </summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
