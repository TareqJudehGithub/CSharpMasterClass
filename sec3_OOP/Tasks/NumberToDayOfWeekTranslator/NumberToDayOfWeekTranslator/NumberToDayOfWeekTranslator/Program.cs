// See https://aka.ms/new-console-template for more information
Console.WriteLine("NumberToDayOfWeekTranslator Task\n");

var tuesday = NumberToDayOfWeekTranslator.Translate(2);
Console.WriteLine(tuesday);
//your code goes here
public class NumberToDayOfWeekTranslator
{
    public static string Translate(int num)
    {

        string day;
        switch (num)
        {
            case 1:
                day = "Monday";
                break;

            case 2:
                day = "Tuesday";
                break;

            case 3:
                day = "Wednesday";
                break;

            case 4:
                day = "Thursday";
                break;

            case 5:
                day = "Friday";
                break;

            case 6:
                day = "Saturday";
                break;

            case 7:
                day = "Sunday";
                break;

            default:
                day = "Invalid day of the week";
                break;
        }
        return day;
    }
}
