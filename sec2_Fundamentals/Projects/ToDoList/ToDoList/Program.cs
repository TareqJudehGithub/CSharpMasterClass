// See https://aka.ms/new-console-template for more information


// Todo list
Console.WriteLine("Hello!");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

// Console.ReadKey(); // stops the program, until the user manually choses so.

Console.Write("\nPlease type something: ");
var userChoice = Console.ReadLine();

PrintSelectedOption(userChoice);

Console.WriteLine($"User entry is too long? {IsLong(userChoice)}");
Console.WriteLine("");

// Using If Else
//if (userChoice == "S")
//{
//    PrintSelectedOption("See All options");
//}
//else if (userChoice == "A")
//{
//    Console.WriteLine("Add a TODO");
//}
//else if (userChoice == "R")
//{
//    Console.WriteLine("Remove a TODO");
//}
//else if (userChoice == "E")
//{
//    Console.WriteLine("Exit");
//}
//else
//{
//    Console.WriteLine("Invalid choice!");
//}

// Using Switch
switch (userChoice)
{
    case "A":
    case "a":
        Console.WriteLine("Add a TODO");
        break;

    case "R":
    case "r":
        Console.WriteLine("Remove TODO");
        break;

    case "E":
    case "e":
        Console.WriteLine("Add a TODO");
        break;

    default:
        Console.WriteLine("Invalid entry!");
        break;
}

Console.WriteLine("\nPress any key to terminate program.");
Console.ReadKey();

void PrintSelectedOption(string selectedOption)
{
    Console.WriteLine("\nSelected option: " + selectedOption);
}

bool IsLong(string input)
{
    return input.Length > 10;
}




