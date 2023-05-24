using System;

/// <summary> class Shape </summary>
class Shape
{
    /// <summary> NotImplemented error </summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
/// <summary> class Rectangle derived from shape class </summary>
class Rectangle:Shape
{
    private int width;
    private int height;
    public int Width
    {
        get
        {
            return width;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            width = value;
        }
    }
    public int Height
    {
        get
        {
            return height;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            height = value;
        }
    }
    public new int Area()
    {
        return width * height;
    }
    
    public override string ToString()
    {
        return String.Format("[Rectangle] {0} / {1}", this.width, this.height);
    }
}
/// <summary>
/// class Square inherits from Rectangle </summary>
class Square:Rectangle
{
    private int size;
    /// <summary> get value and set, ArgExcept if negative otherwise set height and width</summary>
    public int Size
    {
        get
        {
            return this.size;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Size must be greater than or equal to 0");
            }
            base.Height = value;
            base.Width = value;
            this.size = value;
        }
    }
    public override string ToString()
    {
        string str = "[Square] " + Width + " / " + Height;
        return str;
    }
}