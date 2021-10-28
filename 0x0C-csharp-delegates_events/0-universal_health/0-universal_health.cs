using System;

/// <summary> Player Class with stats </summary>
public class Player
{
    private string name;
    private float maxHp;
    private float hp;

    /// <summary> Player Constructor to set stats </summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp <= 0f)
        {
            this.maxHp = this.hp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
            this.maxHp = this.hp = maxHp;
    }

    /// <summary> Prints health of Player </summary>
    public void PrintHealth()
    {
        Console.WriteLine(this.name + " has " + this.hp + " / " + this.maxHp + " health");
    }
}
