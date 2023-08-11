namespace ToDoListTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Implement a ToDo List 
            List<string> toDoList = new List<string>();
            toDoList.Add("hello");
            Console.WriteLine(toDoList.IndexOf("hello"));

            // Implement a ToDo List See ALL ToDos

            SelectToDoOption();

            // Show all ToDo(s)
            void ShowAllToDos(List<string> toDo)
            {
                int toDoNo = 1;

                if (toDo.Count() == 0)
                {
                    Console.WriteLine("No TODOs have been added yet.");
                }
                //if (toDo.Count > 0)
                //{
                //    Console.WriteLine("\nToDo(s) for today are: ");

                //    for (int i = 0; i < toDo.Count(); i++)
                //    {
                //        Console.WriteLine($"{toDoNo}. {toDo[i]}");
                //        toDoNo++;
                //    }

                //}
            }
            Console.WriteLine("\n");

            string removeIndex = string.Empty;

            //Methods

            // Implement a ToDo List - Select an option
            void SelectToDoOption()
            {
                string userChoice = string.Empty;
                int toDoNo = 1;
                do
                {
                    Console.WriteLine("" +
                       "Hello,\n" +
                       "What do you want to do?\n" +
                       "[S]ee all TODOs\n" +
                       "[A]dd a TODO\n" +
                       "[R]emove a TODO\n" +
                       "[E]xit\n");

                    Console.WriteLine("Leaving Console.");

                    Console.WriteLine("");
                    Console.Write("\nEnter your choice: ");
                    userChoice = Console.ReadLine();

                    switch (userChoice)
                    {
                        case "S":
                        case "s":
                            //  ShowAllToDos(toDoList);
                            Console.Clear();
                            Console.WriteLine($"User choice: Show");
                            ShowAllToDos(toDo: toDoList);

                            if (toDoList.Count > 0)
                            {
                                toDoNo = 1;
                                Console.WriteLine("\nToDo(s) for today are: ");

                                for (int i = 0; i < toDoList.Count(); i++)
                                {
                                    Console.WriteLine($"{toDoNo}. {toDoList[i]}");
                                    toDoNo++;
                                }
                            }
                            Console.WriteLine("\n");
                            break;

                        case "A":
                        case "a":
                            Console.Clear();
                            Console.WriteLine($"User choice: Add\n");
                            AddToDo(toDoList);
                            break;

                        case "R":
                        case "r":
                            Console.Clear();
                            Console.WriteLine($"User choice: Remove\n");
                            RemoveToDo(toDoList);
                            break;
                        case "E":
                        case "e":
                            Console.Clear();
                            Console.WriteLine($"User choice: Exit\n");
                            Console.WriteLine("Good bye!");
                            break;
                        default:

                            Console.WriteLine("Invalid entry.\n");
                            break;
                    }
                    if (userChoice == "E")
                    {
                        Console.WriteLine("Closing application..\n");
                        break;
                    }
                    if (userChoice == "e")
                    {
                        Console.WriteLine("Closing application..");
                        break;
                    }
                }
                while (userChoice != "E" || userChoice != "e");
            }

            // Implement a ToDo List - Add method
            void AddToDo(List<string> toDoList)
            {
                string description = string.Empty;
                do
                {
                    Console.Clear();
                    Console.Write("Enter a TODO description: ");
                    description = Console.ReadLine();

                    if (description.Length > 0 && !toDoList.Contains(description))
                    {
                        toDoList.Add(description);
                        //foreach (string item in toDoList) Console.WriteLine(item);
                        Console.WriteLine($"TODO successfully added: {description}\n");
                        break;
                    }
                    else if (description.Length == 0)
                    {
                        Console.WriteLine("Description cannot be empty.\n");
                    }
                    else if (toDoList.Contains(description))
                    {
                        Console.WriteLine("Description must be unique.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry. Try again please.\n");
                    }
                }
                while (description.Length == 0);
            }

            // Implement a ToDo List - Remove method
            List<string> RemoveToDo(List<string> toDo)
            {
                string removeIndex = string.Empty;
                int userChoice = 0;
                bool isDigit = true;

                int toDoNo = 1;
                do
                {
                    //ShowAllToDos(toDo);
                    ShowAllToDos(toDo: toDoList);
                    // Show all ToDo
                    toDoNo = 1;

                    // Remove a ToDo item
                    if (toDoList.Count > 0)
                    {
                        Console.WriteLine("\nToDo(s) for today are: ");
                        foreach (string item in toDoList)
                        {
                            Console.WriteLine($"{toDoNo}. {item}");
                        }
                        Console.Write("Select the index of the TODO you want to remove: ");
                        removeIndex = Console.ReadLine();
                        userChoice = Convert.ToInt32(removeIndex);

                        isDigit = int.TryParse(removeIndex, out userChoice);

                        if (isDigit)
                        {
                            Console.WriteLine($"User choice = {userChoice}");

                            toDo.Remove(toDo[userChoice]);
                            Console.WriteLine($"TODO removed: {toDo[userChoice]}\n");

                            ShowAllToDos(toDo);
                            if (toDoList.Count > 0)
                            {
                                Console.WriteLine("\nToDo(s) for today are: ");
                                foreach (string item in toDoList)
                                {
                                    Console.WriteLine($"{toDoNo}. {item}");
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("No TODOs have been added yet.");
                    }
                }
                while (!isDigit);

                return toDo;
            }
        }
    }
}
