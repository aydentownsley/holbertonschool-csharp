using System;

class Shape
{
    /// <summary>Non-Implemented Method</summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

class Rectangle : Shape
{
    /// widht and height members
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

    /// <summary>Area Method.</summary>
    public new int Area()
    {
        return this.width * this.height;
    }

    /// <summary>Overriden ToString</summary>
    public override string ToString()
    {
        return string.Format("[Rectangle] {0} / {1}", this.width, this.height);
    }
}

class Square : Rectangle
{
    /// private member.
    private int size;

    /// <summary>Size Property.</summary>
    public int Size
    {
        get { return this.size; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Size must be greater than or equal to 0");
            this.size = this.Width = this.Height = value;
        }
    }

    /// <summary>Overriden ToString</summary>
    public override string ToString()
    {
        return string.Format("[Square] {0} / {0}", this.size);
    }
}
