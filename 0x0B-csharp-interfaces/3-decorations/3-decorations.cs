using System;

abstract class Base
{
    public string name { get; set; }
    public override string ToString()
    {
        return name + " is a " + GetType();
    }
}

/// <summary>
/// Interface for Intraction
/// </summary>
interface IInteractive
{
  void Interact();
}

/// <summary>
/// Interface for breakable
/// </summary>
interface IBreakable
{
  int durability { get; set; }
  void Break();
}

/// <summary>
/// Interface for Collectable
/// </summary>
interface ICollectable
{
  bool isCollected { get; set; }
  void Collect();
}

class Door : Base, IInteractive
{
  public Door(string name = "Door")
  {
    this.name = name;
  }
  public void Interact()
  {
    Console.WriteLine("You try to open the {0}. It's locked.", name);
  }
}

class Decoration : Base, IInteractive, IBreakable
{
  public bool isQuestItem;
  public int durability {get; set;}
  public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
  {
    this.name = name;
    if (durability <= 0)
      throw new Exception("Durability must be greater than 0");
    else
      this.durability = durability;
    this.isQuestItem = isQuestItem;
  }

  public void Interact()
  {
    if (durability <= 0)
      Console.WriteLine("The " + name + " has been broken");
    else if (isQuestItem == true)
      Console.WriteLine("You look at the " + name + ". There's a key inside.");
    else if (isQuestItem == false)
      Console.WriteLine("You look at the " + name + ". Not much to see here.");
  }

  public void Break()
  {
    if (durability > 0)
    {
      durability -= 1;
      Console.WriteLine("You hit the " + name + ". It cracks.");
    }
    else if (durability == 0)
      Console.WriteLine("You smash the " + name + ". What a mess.");
    else
      Console.WriteLine("The " + name + " is already broken.");
  }
}
