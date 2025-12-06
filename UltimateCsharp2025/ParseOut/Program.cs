// See https://aka.ms/new-console-template for more information
Console.WriteLine("TryParse & out keywords");


var numbers = new[] { 10, 5, -8, 14, -17, 2 };
List<int> positiveNumbers = new List<int>();
int negativeCount;

// Using out keyword to calculate negative numbers found
List<int> GetPositiveNumbers(List<int> numbersArr, out int countOfNegative)
{
    countOfNegative = 0;
    foreach (var number in numbers)
    {
        if (number > 0)
        {
            positiveNumbers.Add(number);
        }
        else
        {
            countOfNegative++;
        }
    }
    return positiveNumbers;
}

GetPositiveNumbers(positiveNumbers, out negativeCount);

foreach (var number in positiveNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine($"Negative numbers count = {negativeCount}");

// TryParse in action
int output = 0;
bool isUserInputInt;
do
{
    Console.Write("Enter a number: ");
    var userInput = Console.ReadLine();

    isUserInputInt = int.TryParse(userInput, out output);

    // Check if parsing was successful
    if (isUserInputInt)
    {
        Console.WriteLine("Parsing was successful!");
    }
    else
    {
        Console.WriteLine("Parsing failed!");
    }
}
while (!isUserInputInt);

Console.WriteLine("Press any key to exit Console");
Console.ReadKey();



