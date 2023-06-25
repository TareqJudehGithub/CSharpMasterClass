namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whie loop\n");
            // A while loop keeps runing a until  condition is no longer met.

            int number = 0;
            while (number < 5)
            {
                Console.WriteLine($"{nameof(number)} = {number}");
                number++;
            }

            Console.Write("enter a word: ");
            string userInput = Console.ReadLine();

            while (userInput.Length < 10)
            {
                Console.WriteLine(userInput);
                userInput += "a";
            }
        }
    }
}