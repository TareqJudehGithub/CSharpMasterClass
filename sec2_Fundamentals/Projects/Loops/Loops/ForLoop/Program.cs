namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Loop\n");

            // for loop, etirates over all elements or for a specific amount of time determined
            // by the developer.
            //for (Initializer; Condition; Itirator)
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Hello!");
            }

            //your code goes here           

            int factNumber = 5;

            int Factorial(int number)
            {
                //your code goes here
                int factorial = 1;

                for (int i = 0; i < number; i++)
                {
                    Console.WriteLine(i);
                    Console.WriteLine(factorial);
                    factorial += factorial * (i);

                    //Console.WriteLine($"factorial = {factorial}");
                }
                return factorial;
            }
            Console.WriteLine($"\nFactorial for number {factNumber} = {Factorial(factNumber)}");

        }
    }
}