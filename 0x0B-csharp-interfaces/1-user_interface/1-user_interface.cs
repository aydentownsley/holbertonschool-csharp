using System;

abstract class Base
{
    public string name;
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

class TestObject : Base, IInteractive, IBreakable, ICollectable
{
  public string name;
  public int durability { get; set; }
  public bool isCollected { get; set; }
  void IInteractive.Interact() {}
  void IBreakable.Break() {}
  void ICollectable.Collect() {}
}
