// See https://aka.ms/new-console-template for more information
Console.WriteLine("Computed Properties\n");

Rectangle rectangleA = new Rectangle(5, 10);

Console.WriteLine(rectangleA.Description);
class Rectangle
{

    private int _widht;
    private int _hieght;
    public int Width
    {
        set
        {
            this.Width = value;
        }
        get
        {
            return this._widht;
        }
    }
    public int Height { set; get; }

    // Computed Properties


    public Rectangle(int width, int height)
    {
        this._widht = width;
        Height = height;
    }

    public int CaluclateCircumfrence() => 2 * (Width + Height);
    public int CalculateArea() => Width * Height;
    public string Description => $"A rectangle with {Width} and a height of {Height}";

}

// * The => in Description property provides a get-only property