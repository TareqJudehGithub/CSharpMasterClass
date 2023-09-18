//global using System.Diagnostics;
using SRP.DataAccess;

Console.WriteLine("Singe Responsibility Principle\n");

var stopWatch = Stopwatch.StartNew();
stopWatch.Start();

var names = new Names();
var path = new NamesFilePathBuilder().BuildFilePath();
var stringsTextualRepository = new StringsTextualRepository();

if (File.Exists(path))
{
    Console.WriteLine("Names file already exists. Loading names.");
    var stringsFromFile = stringsTextualRepository.Read(path);
    names.AddNames(stringsFromFile);

}
else
{
    Console.WriteLine("Names files does not yet exist");

    // let's imagine they are given by the user
    names.AddName("John");
    names.AddName("not a valid name");
    names.AddName("Claire");
    names.AddName("123 definitely not a valid name");

    Console.WriteLine("Saving names to a file.");
    stringsTextualRepository.Write(path, names.All);

}
Console.WriteLine(new NameFormatter().Format(names.All));
stopWatch.Stop();
Console.WriteLine($"\nTime elapsed {stopWatch.ElapsedMilliseconds}");

Console.ReadKey();
