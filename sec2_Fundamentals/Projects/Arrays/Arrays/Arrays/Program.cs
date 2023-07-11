namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            /* - Arrays is a collection type that store elements of the 'same' type.
            *  - Array(s) have a fixed sizes, and cannot be changed after declaration.       
            *  - new keyword. Array is a class, and in order to create new instances of 
            *    classes we must use the 'new' keyword.
               - Array index(s) values in Array declaration is by default = 0;
            */

            // Declare an Array
            int[] numbers = new int[3];

            // Initialize Array elements with values
            int firstIndex = numbers[0] = 1;
            int secondtIndex = numbers[1] = 2;
            int thirdIndex = numbers[2] = 3;

            Console.WriteLine($"Element at index0 = {numbers[0]}");
            Console.WriteLine($"Element at index0 = {numbers[1]}");
            Console.WriteLine($"Element at index0 = {numbers[2]}");


            Console.WriteLine("");
            // Array Initializer
            string[] friendsList = new string[] { "Ali", "Sarrah", "Amy", "Adam" };

            for (int i = 0; i < friendsList.Length; i++)
            {
                Console.WriteLine(friendsList[i]);
            }
            Console.ReadKey();
        }



    }
}