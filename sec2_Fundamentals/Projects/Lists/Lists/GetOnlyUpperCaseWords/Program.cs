namespace GetOnlyUpperCaseWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GetOnlyUpperCaseWords problem\n");

            List<string> words = new List<string> { "ONE", "TWO", "TWO", "oNe", "TWO123", "THREE!&^" };

            Console.WriteLine(GetOnlyUpperCaseWords(words));

            List<string> GetOnlyUpperCaseWords(List<string> words)
            {
                List<string> upperWords = new List<string>();

                foreach (string word in words)
                {

                    if (!upperWords.Contains(word))
                    {

                        bool isUpper = true;
                        foreach (char letter in word)
                        {
                            if (!char.IsUpper(letter))
                            {
                                isUpper = false;
                            }
                        }
                        if (isUpper)
                        {
                            upperWords.Add(word);
                        }
                    }
                }
                foreach (string word in upperWords)
                {
                    Console.WriteLine(word);
                }
                return upperWords;
            }

        }
    }
}