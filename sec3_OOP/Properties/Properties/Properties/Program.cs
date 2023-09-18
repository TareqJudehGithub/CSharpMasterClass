// See https://aka.ms/new-console-template for more information
Console.WriteLine("Properites\n");

Rectangle rectangleA = new Rectangle(width: 5, height: 10);

// Objects
int recWidth = rectangleA.Width;
Console.WriteLine(recWidth);

rectangleA.Width = 15;
Console.WriteLine(rectangleA.Width);

class Rectangle
{
    #region Fields
    private int _width;
    private int _height;
    #endregion

    #region Properties

    // Old school C# accessors        
    public int Width
    {
     #region Accessors
        get
        {
            return _width;
        }
        set
        {
            if (value > 0)
            {
                this._width = value;
            }
        }
    }
    // Modern C# accessors

    // readonly Width
    //public int WidthFixed { get; }

    //public int Height { get; private set; }
    //#endregion        

    //#region Constructors
    //public Rectangle(int width, int height)
    //{
    //    this._width = width;
    //    this._height = height;
    //}
    #endregion
    // Methods

}

