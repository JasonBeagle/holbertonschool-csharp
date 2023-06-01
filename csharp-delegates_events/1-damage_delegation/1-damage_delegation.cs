using System;


/// <summary> delegate for calculating health </summary>
/// <param name="amount">health amount </param>
public delegate void CalculateHealth(float amount);

/// <summary> class Player. </summary>
public class Player
{
    /// <summary> player name </summary>
    private string name { get; set; }

    /// <summary> player maxHp, 100 by default </summary>
    private float maxHp { get; set; }

    /// <summary> player hp </summary>
    private float hp { get; set; }

    /// <summary> player constructor </summary>
    /// <param name="name">player name </param>
    /// <param name="maxHp">player maxHp </param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp <= 0)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            maxHp = 100f;
        }
        this.maxHp = maxHp;
        this.hp = maxHp;
    }

    /// <summary> prints player health </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    /// <summary> delegate for calculating health </summary>
    /// <param name="amount">health amount </param>
    public delegate void CalculateHealth(float amount);

    /// <summary> player takes damage </summary>
    /// <param name="damage">damage amount </param>
    public void TakeDamage(float damage)
    {
        if (damage <= 0)
        {
        Console.WriteLine($"{name} takes 0 damage!");
        return;
        }
        Console.WriteLine($"{name} takes {damage} damage!");
    }

    /// <summary> method to heal damage </summary>
    /// <param name="heal">heal amount </param>
    public void HealDamage(float heal)
    {
        if (heal <= 0)
        {
        Console.WriteLine($"{name} heals 0 HP!");
        return;
        }
        Console.WriteLine($"{name} heals {heal} HP!");
    }
}
