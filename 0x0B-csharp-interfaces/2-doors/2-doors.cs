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
