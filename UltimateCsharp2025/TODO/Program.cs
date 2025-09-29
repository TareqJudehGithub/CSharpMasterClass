Console.WriteLine("Hello");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");


Console.Write("What do you want to do? ");
string userChoice = Console.ReadLine().ToUpper();

if (userChoice == "S")
{
    PrintSelectedOption(userChoice);
}
else if (userChoice == "A")
{
    PrintSelectedOption(userChoice);
}
else if (userChoice == "R")
{
    PrintSelectedOption(userChoice);
}
else
{
    PrintSelectedOption(userChoice);
}


// Methods
void PrintSelectedOption(string selectedOption)
{
    Console.WriteLine("Selected option: " + selectedOption);

}

Console.Write("Enter a number: ");
int userNumber = int.Parse(Console.ReadLine());
Console.WriteLine($"User entered number: {userNumber}");


Console.ReadKey();




