namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TryParse keyword\n");

            bool isParsed = true;
            do
            {
                Console.WriteLine("Enter a number: ");
                string userInput = Console.ReadLine();

                isParsed = int.TryParse(userInput, out int result);
                if (isParsed)
                {
                    Console.WriteLine($"Parsing number {result} was successful!");
                }
                else
                {
                    Console.WriteLine($"Parsing number {userInput} failed!");
                }

            }
            while (!isParsed);
            Console.ReadKey();


        }
    }
}