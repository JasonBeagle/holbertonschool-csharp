using System;

/// <summary>
/// Represents a player.
/// </summary>
public class Player
{
    private string name;
    private float maxHp;
    private float hp;

    /// <summary>
    /// Gets the name of the player.
    /// </summary>
    public string Name { get { return name; } }

    /// <summary>
    /// Gets the maximum health points (hp) of the player.
    /// </summary>
    public float MaxHp { get { return maxHp; } }

    /// <summary>
    /// Gets the current health points (hp) of the player.
    /// </summary>
    public float Hp { get { return hp; } }

    /// <summary>
    /// Initializes a new instance of the <see cref="Player"/> class with the specified name and maximum health points (maxHp).
    /// </summary>
    /// <param name="name">The name of the player.</param>
    /// <param name="maxHp">The maximum health points (hp) of the player.</param>
    public Player(string name, float maxHp)
    {
        this.name = name;
        if (maxHp > 0)
        {
            this.maxHp = maxHp;
        }
        else
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100f;
        }
        this.hp = maxHp;
    }

    /// <summary>
    /// Prints the current health status of the player.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
}
