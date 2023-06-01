using System;

/// <summary> delegate modifier </summary>
public enum Modifier
{
    /// <summary> weak value should be 0.5  </summary>
    Weak,
    /// <summary> default value of 1  </summary>
    Base,
    /// <summary> strong value 1.5 </summary>
    Strong
}

/// <summary> delegate for calculating health </summary>
/// <param name="amount">health amount </param>
public delegate void CalculateHealth(float amount);
/// <summary> calculate delegate modifier </summary>
/// <param name="baseValue">Base value</param>
/// <param name="modifier">Modifier: Weak, Base, Strong</param>
/// <returns>Returns a delegate</returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

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
        this.ValidateHP(this.hp - damage);
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
        this.ValidateHP(this.hp + heal);
    }
    /// <summary> player's new hp </summary>
    /// <param name="newHp"> sets player's hp </param>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
        {
            this.hp = 0;
        }
        else if (newHp >= maxHp)
        {
            this.hp = maxHp;
        }
        else
        {
            this.hp = newHp;
        }
    }

    /// <summary> applies modifier </summary>
    /// <param name="baseValue">Base value to apply</param>
    /// <param name="modifier">Modifier : Weak, Base, Strong</param>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        float modifiedVal = baseValue;
        switch (modifier)
        {
            case Modifier.Weak:
                modifiedVal = baseValue * 0.5f;
                break;
            case Modifier.Base:
                modifiedVal = baseValue * 1f;
                break;
            case Modifier.Strong:
                modifiedVal = baseValue * 1.5f;
                break;
        }
        return modifiedVal;
    }
}
