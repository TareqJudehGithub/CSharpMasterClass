bool isProgramRunning = true;
List<string> todoList = new List<string>();


while (isProgramRunning)
{

    Header();

    bool isUserInputValid = true;
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
            DisplayTodos(todoList);
            Console.ReadKey();
            break;
        case "A":
            AddNewTodo(todoList);
            break;
        case "R":
            RemoveTodo(todoList, userChoice);
            break;
        case "E":
            Console.WriteLine("Good Bye!");
            isProgramRunning = false;
            break;
        default:
            Console.WriteLine("Invalid choice!");
            break;
    }

    // Methods
    void DisplayTodos(List<string> todoList)
    {
        if (todoList.Count() > 0)
        {
            for (int i = 0; i < todoList.Count(); i++)
            {
                Console.WriteLine($"{i + 1}. {todoList[i]}");
            }
        }
        else
        {
            Console.WriteLine("TODO list is empty!");
        }
        // ContinueAndClear();      
    }

    List<string> AddNewTodo(List<string> todoList)
    {
        var todoDescription = "";
        bool addAnotherTODO = true;
        do
        {
            Header();

            Console.Write("Enter TODO description: ");
            todoDescription = Console.ReadLine();

            if (todoDescription.Length > 0)
            {
                if (todoList.Contains(todoDescription))
                {
                    Console.WriteLine($"{todoDescription} is already in you TODO list!");
                    Console.ReadKey();
                }
                else
                {
                    todoList.Add(todoDescription);
                    Console.WriteLine($"TODO was added successfully!");

                    Console.Write("Would you like to add another TODO? (y/n) ");
                    string userAnswer = Console.ReadLine();

                    if (userAnswer.Equals("n", StringComparison.OrdinalIgnoreCase))
                    {
                        addAnotherTODO = false;
                        ContinueAndClear();
                    }
                    else if (userAnswer.Equals("y", StringComparison.OrdinalIgnoreCase))
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry! Choose between 'y' and 'n' ");
                        Console.ReadKey();
                    }
                }
            }
            else
            {
                Console.WriteLine("TODO description cannot be empty!");
            }

        }
        while (todoDescription.Length == 0 || addAnotherTODO);
        return todoList;
    }

    List<string> RemoveTodo(List<string> todoList, string todo)
    {
        int todoIndex = 0;
        bool isValidEntry;
        do
        {
            DisplayTodos(todoList);

            Console.Write($"\nWhich TODO you wish to remove? (1 - {todoList.Count()}): ");

            var userChoice = Console.ReadLine();
            isValidEntry = int.TryParse(userChoice, out todoIndex);

            if (!isValidEntry || todoIndex < 0 || todoIndex > todoList.Count())
            {
                Console.WriteLine("Invalid TODO entry. Please try again");
                isValidEntry = false;
            }
            else
            {
                for (int i = 0; i < todoList.Count(); i++)
                {
                    Console.WriteLine($"TODO {todoList[todoIndex - 1]} was deleted successfully!");
                    Console.ReadKey();
                    break;
                }
                isValidEntry = true;
            }
        }
        while (!isValidEntry);
        todoList.RemoveAt(todoIndex - 1);
        return todoList;
    }

    void ContinueAndClear()
    {
        Console.Write("Press any key to return to Main menu");
        Console.ReadKey();
        Console.Clear();
    }
}

void Header()
{
    Console.Clear();
    Console.WriteLine("\nHello");
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit\n");

}