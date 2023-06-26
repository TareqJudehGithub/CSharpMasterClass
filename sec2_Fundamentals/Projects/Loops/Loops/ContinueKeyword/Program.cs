namespace ContinueKeyword
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Continue keyword\n");

      // The continue keyword break the current itiration of the current loop, and jumps straight to the next itiration block.

      // Output the numbers from 1-20, save those divisible by 3.
      for (int i = 0; i <= 20; i++)
      {
        if (i % 3 == 0)
        {
          //   Console.WriteLine($"{i} is divisible by 3");
          continue;
        }
        Console.WriteLine(i);
      }
      Console.WriteLine("Press any key to close program.");
      Console.ReadKey();
    }
  }
}