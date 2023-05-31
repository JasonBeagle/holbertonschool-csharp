using System;

/// <summary> Interactive interface </summary>
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

/// <summary> Door class </summary>
public class Door : Base, IInteractive
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Door"/> class with the specified name.
    /// </summary>
    /// <param name="name">The name of the door.</param>
    public Door(string name = "Door")
    {
        Name = name;
    }

    /// <summary>
    /// Performs an interaction with the door.
    /// </summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {Name}. It's locked.");
    }
}
