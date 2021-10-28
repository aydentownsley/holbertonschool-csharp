using System;

/// <summary> enum for modifiers </summary>
public enum Modifier
{
    /// <summary> Weak Mod </summary>
    Weak,
    /// <summary> Base Mod </summary>
    Base,
    /// <summary> Strong Mod </summary>
    Strong
}

/// <summary> Delegate to calculate modifier </summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary> Delegate to calculate health for damage and healing </summary>
public delegate float CalculateHealth(float points);

/// <summary> Player Class with stats </summary>
public class Player
{
    private string name;
    private float maxHP;
    private float hp;
    private string status;
    /// <summary> Event handler for health </summary>
    public EventHandler<CurrentHPArgs> HPCheck;

    /// <summary> Player Constructor to set stats </summary>
    public Player(string name = "Player", float maxHP = 100f)
    {
        this.status = this.name + " is ready to go!";
        this.name = name;
        this.HPCheck += CheckStatus;

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
        if (damage < 0)
            Console.WriteLine(this.name + " takes 0 damage!");
        else
        {
            Console.WriteLine(this.name + " takes " + damage + " damage!");
            ValidateHP(this.hp - damage);
        }
    }

    /// <summary> increases health of player </summary>
    public void HealDamage(float heal)
    {
        if (heal < 0)
            Console.WriteLine(this.name + " heals 0 HP!");
        else
        {
            Console.WriteLine(this.name + " heals " + heal + " HP!");
            ValidateHP(this.hp + heal);
        }
    }

    /// <summary> validates calculated health is within bounds of maxHP </summary>
    public void ValidateHP(float newHP)
    {
        if (newHP <= 0)
            this.hp = 0;
        else if (newHP >= maxHP)
            this.hp = maxHP;
        else
            this.hp = newHP;

        HPCheck(this, new CurrentHPArgs(this.hp));
    }

    /// <summary> apply modifer to value entered </summary>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier.ToString() == "Weak")
            return (baseValue * 0.5f);
        else if (modifier.ToString() == "Base")
            return (baseValue);
        else if (modifier.ToString() == "Strong")
            return (baseValue * 1.5f);
        else
            return (baseValue);
    }

    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == maxHP)
            Console.WriteLine(this.name + " is in perfect health!");
        else if (e.currentHp >= (0.5f * maxHP) && e.currentHp < maxHP)
            Console.WriteLine(this.name + " is doing well!");
        else if (e.currentHp >= (0.25f * maxHP) && e.currentHp < (0.5f * maxHP))
            Console.WriteLine(this.name + " isn't doing too great...");
        else if (e.currentHp > 0 && e.currentHp < (0.25f * maxHP))
            Console.WriteLine(this.name + " needs help!");
        else
            Console.WriteLine(this.name + " is knocked out!");
    }
}

/// <summary> Handles health </summary>
public class CurrentHPArgs : EventArgs
{
    /// <summary> currentHp check </summary>
    public readonly float currentHp;

    /// <summary> sets newHP to current </summary>
    public CurrentHPArgs(float newHP)
    {
        this.currentHp = newHP;
    }
}
