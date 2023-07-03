namespace MultiArrays;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Multi Dimentional Arrays\n");

        // Multi Dimentional Arrays are simply a matrix of elements.
        // Multi Dimentional Arrays takes 2 indexes.
        // for Multi Dimentional Arrays we use .GetLength() method to iteriate over elements.

        char[,] letters = new char[2, 3];   // [rows, columns]

        letters[0, 0] = 'A';
        letters[0, 1] = 'B';
        letters[0, 2] = 'C';
        letters[1, 0] = 'D';
        letters[1, 1] = 'E';
        letters[1, 2] = 'F';

        Console.WriteLine("");
        // Iteriate over a multi dimentional array
        for (int i = 0; i < letters.GetLength(0); i++)
        {
            for (int x = 0; x < letters.GetLength(1); x++)
            {
                Console.WriteLine(letters[i, x]);
            }
        }


        Console.WriteLine("");
        // A multi Dimentional Array with initialized values.

        int[,] numbers =
        {
            {0, 150 },
            {100, 175 },
            {100, 195 },
            {200, 100 },
            {200, 150 },
            {200, 200 }
        };
        Console.ReadKey();

        int FindMax(int[,] numbers)
        {
            //your code goes here
            int maxValue = 0;
            int arraySum = 0;

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    maxValue = numbers[i, j];
                    arraySum += numbers[i, j];

                    if (numbers[i, j] > maxValue)
                    {
                        maxValue = numbers[i, j];
                    }
                }
            }
            if (arraySum == 0)
            {
                return -1;
            }
            return maxValue;
        }
        Console.WriteLine(FindMax(numbers));

    }
}
