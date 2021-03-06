using System;
using System.Collections;
using System.Collections.Generic;

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

    if (isQuestItem == true)
      Console.WriteLine("You look at the " + name + ". There's a key inside.");
    else if (isQuestItem == false)
      Console.WriteLine("You look at the " + name + ". Not much to see here.");
  }

  public void Break()
  {
    durability -= 1;
    if (durability > 0)
    {
      Console.WriteLine("You hit the " + name + ". It cracks.");
    }
    else if (durability == 0)
      Console.WriteLine("You smash the " + name + ". What a mess.");
    else
      Console.WriteLine("The " + name + " is already broken.");
  }
}

class Key : Base, ICollectable
{
  public bool isCollected {get; set;}
  public Key(string name = "Key", bool isCollected = false)
  {
    this.name = name;
    this.isCollected = isCollected;
  }

  public void Collect()
  {
    if (isCollected == false)
    {
      isCollected = true;
      Console.WriteLine("You pick up the " + name + ".");
    }
    else
      Console.WriteLine("You have already picked up the " + name + ".");
  }
}

class Objs<T> : IEnumerable<T>
{
  private List<T> objects = new List<T>();

  public void Add(T obj)
  {
    objects.Add(obj);
  }

  public IEnumerator<T> GetEnumerator()
  {
    return objects.GetEnumerator();
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return GetEnumerator();
  }
}
