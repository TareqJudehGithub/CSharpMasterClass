// See https://aka.ms/new-console-template for more information
Console.WriteLine("TransformSeparators \n");

string sentence = "this,is,some,string";
string reslult = StringsTransformator.TransformSeparators(sentence, ",", "+");

string newSentence = string.Empty;

Console.WriteLine(reslult);

public static class StringsTransformator
{
    public static string TransformSeparators(
        string input,
        string originalSeparator,
        string targetSeparator)
    {
        //your code goes here
        string[] splitString = input.Split(originalSeparator);

        string newString = string.Join(targetSeparator, splitString);

        return newString;
    }
}