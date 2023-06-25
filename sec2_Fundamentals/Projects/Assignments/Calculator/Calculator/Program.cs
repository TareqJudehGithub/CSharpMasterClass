namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator project\n\n");

            Console.WriteLine("Hello!");
            Console.Write("Input the first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Input the first number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("\nWhat do you want to do?");
            Console.WriteLine("[A]dd  number");
            Console.WriteLine("[S]ubtract number");
            Console.WriteLine("[M]ultiply number");

            Caclulator(firstNumber, secondNumber);

            void Caclulator(int num1, int num2)
            {
                /**
                 * This Method calculates the mathmatical output of two user inputs.
                 */
                // Workout result based on user's input choice
                string userInput = Console.ReadLine();
                int result;

                if (userInput == "A" || userInput == "a")
                {
                    result = num1 + num2;
                    Console.WriteLine($"{num1} + {num2} = {result}");
                }
                else if (userInput == "S" || userInput == "s")
                {
                    result = num1 - num2;
                    Console.WriteLine($"{num1} - {num2} = {result}");
                }
                else if (userInput == "M" || userInput == "m")
                {
                    result = num1 * num2;
                    Console.WriteLine($"{num1} * {num2} = {result}");
                }
                else
                {
                    Console.WriteLine("Invalid choice!");
                }
                Console.WriteLine("Press any key to close.");
                Console.ReadKey();
            }

        }
    }
}