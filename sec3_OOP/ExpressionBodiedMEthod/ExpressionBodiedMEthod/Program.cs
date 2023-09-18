// See https://aka.ms/new-console-template for more information
Console.WriteLine("Expression Bodied Methods\n");


class Rectangle
{
    #region fields
    int Width;
    int Height;
    #endregion

    #region Constructors
    internal Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }
    #endregion

    #region Methods
    internal int CalculateArea() => Width * Height;

    internal int CaclulateCircumference() => (Width + Height) * 2;
    #endregion
}

