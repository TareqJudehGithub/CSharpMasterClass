Console.WriteLine("Hello");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");


Console.Write("What do you want to do? ");
string userChoice = Console.ReadLine().ToUpper();

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
    case "e":
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

string firstName = "John Smith";
string department = "IT";
string emailAddress = "john.smith@gmail.com";


Console.Write("Enter a number: ");
int userNumber = int.Parse(Console.ReadLine());
Console.WriteLine($"User entered number: {userNumber}");


Console.ReadKey();




