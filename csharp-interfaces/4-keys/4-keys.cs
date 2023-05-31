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

/// <summary> Decoration class </summary>
public class Decoration : Base, IInteractive, IBreakable
{
    /// <summary>
    /// Gets or sets the durability of the decoration.
    /// </summary>
    public int Durability { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the decoration is a quest item.
    /// </summary>
    public bool IsQuestItem { get; set; }

    /// <summary> InitializesDecoration class </summary>
    /// <param name="name">The name of the decoration.</param>
    /// <param name="durability">The durability of the decoration.</param>
    /// <param name="isQuestItem">A value indicating whether the decoration is a quest item.</param>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        Name = name;
        if (durability <= 0)
        {
            throw new ArgumentException("Durability must be greater than 0");
        }
        Durability = durability;
        IsQuestItem = isQuestItem;
    }

    /// <summary> Performs an interaction with the decoration. </summary>
    public void Interact()
    {
        if (Durability <= 0)
        {
            Console.WriteLine($"The {Name} has been broken.");
        }
        else if (IsQuestItem)
        {
            Console.WriteLine($"You look at the {Name}. There's a key inside.");
        }
        else
        {
            Console.WriteLine($"You look at the {Name}. Not much to see here.");
        }
    }

    /// <summary> Breaks the decoration by decrementing the durability by 1. </summary>
    public void Break()
    {
        if (Durability > 0)
        {
            Durability--;
            if (Durability > 0)
            {
                Console.WriteLine($"You hit the {Name}. It cracks.");
            }
            else
            {
                Console.WriteLine($"You smash the {Name}. What a mess.");
            }
        }
        else
        {
            Console.WriteLine($"The {Name} is already broken.");
        }
    }
}

/// <summary> Key class </summary>
public class Key : Base, ICollectable
{
    /// <summary> Gets or sets a value indicating whether the key is collected. </summary>
    public bool IsCollected { get; set; }

    /// <summary> Initializes instance of Key class parameters.</summary>
    /// <param name="name">The name of the key.</param>
    /// <param name="isCollected">A value indicating whether the key is collected.</param>
    public Key(string name = "Key", bool isCollected = false)
    {
        Name = name;
        IsCollected = isCollected;
    }

    /// <summary> Collects the key </summary>
    public void Collect()
    {
        if (IsCollected)
        {
            Console.WriteLine($"You have already picked up the {Name}.");
        }
        else
        {
            IsCollected = true;
            Console.WriteLine($"You pick up the {Name}.");
        }
    }
}
