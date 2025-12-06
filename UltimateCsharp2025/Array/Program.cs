Console.WriteLine("Arrays\n");

// Arrays of integers - empty
int[] numbers = new int[3];  // int of 3
int[] codes = Array.Empty<int>();  // 0 items 

Console.WriteLine(numbers.Length);
Console.WriteLine(codes.Length);


// ^ index from  symbol
// Get the last item using ^
numbers = [10, 20, 30];
Console.WriteLine(numbers[^1]);  // 30


string BuildHelloString()
{
    char[] letters = new char[] { 'h', 'e', 'l', 'l', 'o' };
    var result = "";
    for (int i = 0; i < letters.Length; ++i)
    {
        //your code goes here
        result += letters[i];
    }
    return result;
}
Console.WriteLine(BuildHelloString());

string[] words = new string[] { "one", "two", "three" };
bool IsWordPresentInCollection(string[] words, string wordToBeChecked)
{
    //your code goes here
    bool result = false;
    for (int i = 0; i < words.Length; i++)
    {
        if (words[i] == wordToBeChecked)
        {
            return result = true;
        }
        else
        {
            result = false;
        }
        //return result = words[i] == wordToBeChecked;
    }
    return result;
}
Console.WriteLine(IsWordPresentInCollection(words, "two"));
// IsWordPresentInCollection(words, "two");