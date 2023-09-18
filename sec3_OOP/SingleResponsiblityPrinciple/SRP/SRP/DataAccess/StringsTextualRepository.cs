namespace SRP.DataAccess;

class StringsTextualRepository
{
    // Const field
    private static readonly string Separator = Environment.NewLine;
    public List<string> Read(string filePath)
    {
        /*
         * Read from and to a text file.
         */
        var fileContents = File.ReadAllText(filePath);
        return fileContents.Split(Environment.NewLine).ToList();

        //foreach (var name in namesFromFile)
        //{
        //    AddName(name);
        //}
    }
    public void Write(string filePath, List<string> strings)
    {
        /*
        * Write to a text file.
        */
        File.WriteAllText(filePath, string.Join(Separator, strings));
    }

}
