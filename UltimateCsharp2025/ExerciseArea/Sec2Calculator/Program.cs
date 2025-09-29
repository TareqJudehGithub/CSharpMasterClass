public class MyProgram
{
    public static void Main(string[] args)
    {

        string CalculateResult()
        {
            Console.WriteLine("Hello!");
            Console.Write("Input the first number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the second number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What do you want to do with those numbers?");
            Console.WriteLine("[A]dd");
            Console.WriteLine("[S]ubtract");
            Console.WriteLine("[M]ultiple");
            Console.WriteLine("");
            string userChoice = Console.ReadLine().ToUpper();
            int result = 0;
            switch (userChoice)
            {
                case "A":
                    result = firstNum + secondNum;
                    break;
                case "S":
                    result = firstNum - secondNum;
                    break;
                case "M":
                    result = firstNum * secondNum;
                    break;
                default:
                    result = 0;
                    break;
            }
            if (result == 0)
            {
                return "empty choice";
            }
            return Convert.ToString(result);
        }

        Console.WriteLine(CalculateResult());


        Console.WriteLine("Press any key to close");







    }
}



