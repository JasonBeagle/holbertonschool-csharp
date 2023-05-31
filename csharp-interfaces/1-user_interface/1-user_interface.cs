using System;
public interface IInteractive
{
    /// <summary>
    /// Performs an interaction.
    /// </summary>
    void Interact();
}

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

public abstract class Base
{
    /// <summary>
    /// Gets or sets the name of the object.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Returns a string representation of the object.
    /// </summary>
    /// <returns>The string representation of the object.</returns>
    public override string ToString()
    {
        return $"{Name} is a {this.GetType()}";
    }
}

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
