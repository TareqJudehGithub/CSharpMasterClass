Console.WriteLine("Hello");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

bool isUserInputValid = true;
int userInputOutput = 0;
string userChoice;
string[] systemChoices = new string[] { "S", "A", "R", "E" };
do
{
    Console.Write("What do you want to do? ");
    userChoice = Console.ReadLine().ToUpper();

    if (!systemChoices.Contains(userChoice))
    {
        isUserInputValid = false;
        Console.WriteLine("Invalid entry! Please try again.");
    }
    else
    {
        break;
    }
}
while (!isUserInputValid);

switch (userChoice)
{
    case "S":
        PrintSelectedOption("See all TODOs");
        break;
    case "A":
        PrintSelectedOption("Add a TODO");
        break;
    case "R":
        PrintSelectedOption("Remove a TODO");
        break;
    case "E":
        PrintSelectedOption("Exiting application..");
        break;
    default:
        Console.WriteLine("Invalid choice!");
        break;
}


// Methods
void PrintSelectedOption(string selectedOption)
{
    Console.WriteLine($"Selected option: {selectedOption}");

}





