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
    char[] letters = ['h', 'e', 'l', 'l', 'o']; //your code goes here
    var result = "";
    for (int i = 0; i < letters.Length; ++i)
    {
        //your code goes here
        result += letters[i];
    }
    return result;
}

BuildHelloString();