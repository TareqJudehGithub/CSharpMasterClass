// See https://aka.ms/new-console-template for more information
Console.WriteLine("Static Classes and Methods\n");

#region Objects
Rectangle rectangle1 = new Rectangle(5, 10);
#endregion

Console.WriteLine(rectangle1.CalculateArea);
Console.WriteLine(rectangle1.CalculateCircumference);

Calculater calculator = new Calculater();

// Notice how we are calling the static method directly from the class it self.
Console.WriteLine(Calculater.Add(5, 8));
Console.WriteLine(Calculater.NumberOfSides);


class Rectangle
{
    /**
     * Stateful class
     */

    #region Properties
    internal int Width { set; get; }
    internal int Height { set; get; }
    #endregion

    #region Constructors
    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }
    #endregion

    #region Methods
    public int CalculateArea => Width * Height;
    public int CalculateCircumference => 2 * (Width * Height);
    #endregion
}

class Calculater
{
    /**
     * Stateless class
     */
    #region Methods
    public static int Add(int a, int b) => a + b;
    public int Subtract(int a, int b) => a - b;
    public int Multiply(int a, int b) => a * b;
    public int Divide(int a, int b) => a / b;


    public const int NumberOfSides = 4;
    #endregion
}
