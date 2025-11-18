// See https://aka.ms/new-console-template for more information
Console.WriteLine("While Loops\n");

//var number = 0;

//while (number < 10)
//{
//    number++;
//    console.writeline($"number is: {number}");
//}
//console.writeline("press a key to continue to the next exercise.");



//Console.Write("Enter a word: ");
//string word = Console.ReadLine();


//while (word.Length < 10)
//{
//    word += 'a';
//    Console.WriteLine(word);
//}
//Console.Read();


// Find the sum of all numbers between firstNumber and lastNumber
int CalculateSumOfNumbersBetween(int firstNumber, int lastNumber)
{
    int sum = 0;
    int current = firstNumber;

    while (current <= lastNumber)
    {
        sum += current;
        current++;
    }

    return sum;
}

Console.WriteLine(CalculateSumOfNumbersBetween(5, 10));


// For loop
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}


int Factorial(int number)
{
    int factorial = 1;
    //your code goes here
    if (number == 0)
    {
        factorial = 1;
    }

    for (int i = 1; i <= number; i++)
    {
        factorial *= i;
    }
    return factorial;
}


void ForLoop()
{
    int userNumber = 0;
    do
    {
        Console.Write("Enter a number larger than 10: ");
        string userInput = Console.ReadLine();


        // Abort if user enters "stop"
        if (userInput == "stop")
        {
            Console.WriteLine("Aborting program! Good Bye!");
            Console.Read();
            break;
        }
        bool isParsableToInt = userInput.All(char.IsDigit);
        if (isParsableToInt)
        {
            userNumber = Convert.ToInt32(userInput);
        }
        else
        {
            continue;
        }
    }
    while (userNumber <= 10);
    Console.WriteLine("Loop has ended!");
}

ForLoop();