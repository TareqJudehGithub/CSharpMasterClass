namespace ToDoListTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Implement a ToDo List 
            List<string> toDoList = new List<string>();

            SelectToDoOption();
            Console.WriteLine("\n");
            AddToDo(toDoList);

            List<string> allToDos = ShowAllToDos(toDoList);

            foreach (string toDo in allToDos)
            {
                Console.WriteLine(toDo);
            }

            //Methods

            // Implement a ToDo List - Select an option
            void SelectToDoOption()
            {
                Console.WriteLine("" +
                   "Hello,\n" +
                   "What do you want to do?\n" +
                   "[S]ee all TODOs\n" +
                   "[A]dd a TODO\n" +
                   "[R]emove a TODO\n" +
                   "[E]xit\n");
            }

            // Implement a ToDo List See ALL ToDos
            List<string> ShowAllToDos(List<string> toDo)
            {
                Console.WriteLine("\nToDo(s) for today are: ");
                return toDo;
            }

            // Implement a ToDo List - Add method
            void AddToDo(List<string> toDoList)
            {
                string description = string.Empty;

                do
                {
                    Console.Write("Enter a TODO description: ");
                    description = Console.ReadLine();

                    toDoList.Add(description);
                    if (description.Length > 0)
                    {
                        Console.WriteLine($"TODO successfully added: {description}");
                    }

                }
                while (description.Length == 0);
            }

            // Implement a ToDo List - Remove method

            //SelectOption(){
            //    string choice = string.Empty;

            //    switch (choice)
            //    {
            //        case "A":
            //        case "a":

            //    }
            //}

            // Console.ReadKey();
        }
    }
}