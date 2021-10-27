using System;

/// <summary> Delegate to calculate health for damage and healing </summary>
public delegate float CalculateHealth(float points);

/// <summary> Player Class with stats </summary>
public class Player
{
    private string name;
    private float maxHP;
    private float hp;

    /// <summary> Player Constructor to set stats </summary>
    public Player(string name = "Player", float maxHP = 100f)
    {
        this.name = name;
        if (maxHP <= 0f)
        {
            this.maxHP = this.hp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
            this.maxHP = this.hp = maxHP;
    }

    /// <summary> Prints health of Player </summary>
    public void PrintHealth()
    {
        Console.WriteLine(this.name + " has " + this.hp + " / " + this.maxHP + " health");
    }

    /// <summary> decreases health of player </summary>
    public void TakeDamage(float damage)
    {
        if (damage <= 0)
            Console.WriteLine(this.name + " takes 0 damage!");
        else
        {
            this.hp = this.hp - damage;
            Console.WriteLine(this.name + " takes " + damage + " damage!");
        }
    }

    /// <summary> increases health of player </summary>
    public void HealDamage(float heal)
    {
        if (heal <= 0)
            Console.WriteLine(this.name + " heals 0 HP!");
        else
        {
            this.hp = this.hp + heal;
            Console.WriteLine(this.name + " heals " + heal + " HP!");
        }
    }
}
