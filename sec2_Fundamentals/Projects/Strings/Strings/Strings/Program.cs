namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!\n");
            // String Interpolation
            int a = 4, b = 2, c = 10;
            Console.WriteLine($"First is: {nameof(a)} = {a}, second is {nameof(b)} = {b}, third is: {nameof(c)} = {c}");

        }
    }
}