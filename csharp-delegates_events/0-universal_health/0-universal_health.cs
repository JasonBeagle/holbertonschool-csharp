using System;

/// <summary> class Player. </summary>
public class Player
{

    /// <summary> player name </summary>
    public string name { get; set; }

    /// <summary> player maxHp, 100 by default  </summary>
    public float maxHp { get; set; }

    /// <summary> player hp </summary>
    public float hp { get; set; }

    /// <summary> player constructor </summary>
    /// <param name="name">player name </param>
    /// <param name="maxHp">player maxHp </param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp > 0)
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
}
