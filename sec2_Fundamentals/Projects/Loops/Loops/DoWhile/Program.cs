namespace DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do While");
            // Unlike the case in While loops, the Do While loop code is excuted once, before the
            // the loop runs.
            char letterS = 's';
            char upperS = Char.ToUpper(letterS);

            Console.WriteLine(upperS);

            //your code goes here
            string RepeatCharacter(char character, int targetLength)
            {
                //your code goes here                
                string result = string.Empty;
                do
                {
                    result += character;
                }
                while (result.Length < targetLength);

                return result;
            }

            // user enters a number 1 - 10 or stop to exit program.
            int userNumber;
            do
            {

                Console.WriteLine("Please enter a number from 1 - 10, or type stop to exit.");
                var userInput = Console.ReadLine();
                if (userInput == "stop")
                {
                    break;
                }

                // convert user input to int

                bool isParsableToInt = userInput.All(char.IsDigit);

                Console.WriteLine(isParsableToInt);

                userNumber = int.Parse(userInput);
                if (userNumber < 0 || userNumber > 10)
                {
                    Console.WriteLine("Invalid entry.");
                    break;
                }

            } while (userNumber > 0 || userNumber <= 10);
        }
    }
}