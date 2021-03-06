using System;

class Shape
{
    /// <summary>Non-Implemented Area Method.</summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

class Rectangle : Shape
{
    /// Private members
    private int width;
    private int height;

    /// <summary>Width Property.</summary>
    public int Width
    {
        get { return this.width; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            this.width = value;
        }
    }

    /// <summary>Height Property.</summary>
    public int Height
    {
        get { return this.height; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            this.height = value;
        }
    }
}
