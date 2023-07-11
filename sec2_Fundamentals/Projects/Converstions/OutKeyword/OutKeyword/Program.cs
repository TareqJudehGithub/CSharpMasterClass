namespace OutKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Out Keyword\n");

            // return positive numbers out of a List
            var numbers = new[] { 7, 10, -8, -15, 2, 12, -17 };
            int negativeCount = 0;

            List<int> PositiveNumResult = PositiveNumbers(numbers, out negativeCount);
            foreach (var item in PositiveNumResult)
            {
                Console.Write($"{item}, ");
                negativeCount++;
            }
            Console.WriteLine($"\nCount of negative numbers = {negativeCount}");

            List<int> PositiveNumbers(int[] arrayOfNums, out int countNonPositive)
            {
                List<int> positiveNumbers = new List<int>();
                countNonPositive = 0;

                foreach (var num in arrayOfNums)
                {
                    if (num > 0)
                    {
                        positiveNumbers.Add(num);
                    }
                    else
                    {
                        countNonPositive++;
                    }
                }
                return positiveNumbers;
            }
        }
    }
}