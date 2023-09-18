// See https://aka.ms/new-console-template for more information
Console.WriteLine("Encapsulation\n");



class Rectangle
{
    #region fields
    int SideA;
    int Height;
    #endregion

    #region Constructors
    internal Rectangle(int width, int height)
    {
        // Constructor validation
        SideA = GetLengthOrDefault(width, nameof(SideA));
        Height = GetLengthOrDefault(height, nameof(Height));
    }
    #endregion

    #region Methods
    internal int CalculateArea()
    {
        return SideA * Height;
    }

    internal int CaclulateCircumference()
    {
        return (SideA + Height) * 2;
    }
    private int GetLengthOrDefault(int length, string name)
    {
        int defaultValueIfNonPositive = 1;

        if (length <= 1)
        {
            Console.WriteLine($"{name} must be a positive number.");
            return defaultValueIfNonPositive;
        }
        return length;
    }

    #endregion
}
