// measures code execution time.
using System.Diagnostics;

Console.WriteLine("Name Spaces\n");

var stopwatch = Stopwatch.StartNew();

stopwatch.Start();

for (int i = 0; i <= 1000; i++)
{
    Console.WriteLine($"Loop Number: {i}");
}

stopwatch.Stop();

Console.WriteLine($"\nTime in me: {stopwatch.ElapsedMilliseconds}");

