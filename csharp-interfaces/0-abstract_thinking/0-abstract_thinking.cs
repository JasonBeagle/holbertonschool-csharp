using System;
/// <summary> Base class </summary>
public abstract class Base
{
    /// <summary> Name property </summary>
    public string name {get; set;}
    /// <summary> overrides ToString </summary>
    public override string ToString()
    {
        return $"{name} is a {this.GetType()}";
    }
}
