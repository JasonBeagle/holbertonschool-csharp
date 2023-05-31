using System;
/// <summary> interactive interface </summary>
public interface IInteractive
{
    /// <summary>
    /// Performs an interaction.
    /// </summary>
    void Interact();
}
/// <summary> IBreakable interface </summary>
public interface IBreakable
{
    /// <summary>
    /// Gets or sets the durability of the object.
    /// </summary>
    int Durability { get; set; }

    /// <summary>
    /// Breaks the object.
    /// </summary>
    void Break();
}
/// <summary> ICollectable interface </summary>
public interface ICollectable
{
    /// <summary>
    /// Gets or sets a value indicating whether the object is collected.
    /// </summary>
    bool IsCollected { get; set; }

    /// <summary>
    /// Collects the object.
    /// </summary>
    void Collect();
}
/// <summary> Base class </summary>
public abstract class Base
{
    /// <summary>
    /// Gets or sets the name of the object.
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// Returns a string representation of the object.
    /// </summary>
    /// <returns>The string representation of the object.</returns>
    public override string ToString()
    {
        return $"{name} is a {this.GetType()}";
    }
}
/// <summary> TestObject </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    /// <summary>
    /// Gets or sets the durability of the TestObject.
    /// </summary>
    public int Durability { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the TestObject is collected.
    /// </summary>
    public bool IsCollected { get; set; }

    /// <summary>
    /// Performs an interaction with the TestObject.
    /// </summary>
    public void Interact()
    {
        // Implementation of the Interact method
    }

    /// <summary>
    /// Breaks the TestObject.
    /// </summary>
    public void Break()
    {
        // Implementation of the Break method
    }

    /// <summary>
    /// Collects the TestObject.
    /// </summary>
    public void Collect()
    {
        // Implementation of the Collect method
    }
}
