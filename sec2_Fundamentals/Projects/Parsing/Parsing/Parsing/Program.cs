namespace Parsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Parsing\n");

            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(number);
        }
    }
}