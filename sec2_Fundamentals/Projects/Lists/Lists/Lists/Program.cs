namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lists\n");

            // Declare and a new list:
            List<string> words = new List<string>();

            // Declare and a new list:
            List<string> friends = new List<string>
            {
                "Ali",
                "Sammar",
                "Adams",
                "Ellishiya"
            };

            // List length
            Console.WriteLine(words.Count);
            Console.WriteLine(friends.Count);

            // Add new item to Lists using .Add() method
            words.Add("Hello");
            Console.WriteLine(words.Count);

            Console.WriteLine("");
            // Iteriate over items in a List.
            foreach (string friend in friends)
            {
                Console.WriteLine(friend);
            }

            Console.WriteLine("");

            // Removing items from a List
            friends.Remove("Adams");

            Console.WriteLine(friends.Count);

            // .RemoveAt(indexX) remove an element using it's index number.
            friends.RemoveAt(0);

            foreach (string friend in friends)
            {
                Console.WriteLine(friend);
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            //Add range

            List<string> moreFriends = new List<string>
            {
                "Sarah",
                "Khalil",
                "Mohammad"
            };

            friends.AddRange(moreFriends);

            foreach (string friend in friends)
            {
                Console.WriteLine(friend);
            }
            // IndexOf()
            Console.WriteLine(friends.IndexOf("Khalil")); // 3
            Console.WriteLine(friends.IndexOf("Peter"));  // -1

            // Contains - chk if an element exists in the List - bool result.
            Console.WriteLine(friends.Contains("Mohammad")); // true

            // Empty/delete a list
            friends.Clear();
        }
    }

}