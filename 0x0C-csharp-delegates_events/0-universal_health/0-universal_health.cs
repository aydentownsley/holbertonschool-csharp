using System;

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
}
