Console.WriteLine("Lists\n");
List<string> words = new List<string> { "one", "two", "three" };

// Adding "four"
words.Add("four");

Console.WriteLine(words);

foreach (var word in words)
{
    Console.WriteLine(word);
}

Console.WriteLine(words.Contains("four")); // true

words.Clear();  // Clears all items
Console.WriteLine(words.Count());   // returns list length

List<string> names = new List<string> { "one", "TWO", "THREE", "four", "TWO", "TWO123", "THREE!&^" };

List<string> GetOnlyUpperCaseWords(List<string> words)
{
    //your code goes here
    List<string> upperCaseLetters = new List<string>();

    foreach (var word in words)
    {
        if (upperCaseLetters.Contains(word))
        {
            Console.WriteLine($"{word} is already in uppderCaseLetters list.");
            continue;
        }
        if (isAllLetters(word))
        {
            upperCaseLetters.Add(word);
        }

        bool isAllLetters(string word)
        {

            for (int i = 0; i < word.Length; i++)
            {
                if (!char.IsUpper(word[i]))
                {
                    return false;
                }
            }
            return true;

        }

    }
    return upperCaseLetters;

}


foreach (var item in GetOnlyUpperCaseWords(names))
{
    Console.WriteLine(item);
}