namespace FirstClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangleOne = new Rectangle(width: 5, height: 10);
            Rectangle rectangleTwo = new Rectangle(width: 6, height: 8);

            Console.WriteLine($"Rectangle width = {rectangleOne.Width}");
            Console.WriteLine($"Rectangle 2: Width: {rectangleTwo.Width} Height: {rectangleTwo.Height}");

            Console.WriteLine("");
            Console.WriteLine($"The area for rectangle One = {rectangleOne.CalculateArea()}");
            Console.WriteLine($"The circumference for rectangle One = {rectangleOne.CaluclateCircumfrence()}");
        }
    }
}