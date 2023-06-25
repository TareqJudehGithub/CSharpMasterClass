namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Methods\n");

            Console.Write("Enter the 1st value: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the 2nd value: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());


            var result = Add(a: firstNum, b: secondNum);
            Console.WriteLine($"The sum of {firstNum} and {secondNum} = {result}");

            Console.WriteLine("\nPress any key to exit program.");
            Console.ReadKey();

            int Add(int a, int b)
            {
                int sum = a + b;

                if (sum >= 0) return sum;
                else { return -sum; }
            }
        }
    }
}

