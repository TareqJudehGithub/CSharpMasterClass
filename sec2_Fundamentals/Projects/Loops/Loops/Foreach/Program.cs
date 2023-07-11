namespace Foreach;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Foreach loop\n");

        //string[] words = new string[0];
        string[] words = new string[] { };
        //  Console.WriteLine(words.Length);

        Console.WriteLine(IfLongerThanFive(words));

        bool IfLongerThanFive(string[] words)
        {
            bool isLonger = default;
            foreach (string word in words)
            {
                Console.WriteLine(word.Length);

                if (words.Length == 0)
                {
                    isLonger = false;

                }
                if (word.Length > 5)
                {
                    isLonger = true;
                }
                else
                {
                    isLonger = false;
                }
            }
            return isLonger;
        }
    }
}
