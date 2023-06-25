namespace Switch;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Switch Statements\n");

        Console.Write("Enter student points: ");
        int userPoints = int.Parse(Console.ReadLine());

        string userGrade = ConvertPointsToGrade(userPoints);
        Console.WriteLine($"User grade = {userGrade}");

        string ConvertPointsToGrade(int points)
        {
            switch (points)
            {
                case 10:
                case 9:
                    return "A";

                case 8:
                case 7:
                case 6:
                    return "B";

                case 5:
                case 4:
                case 3:
                    return "C";

                case 2:
                case 1:
                    return "D";

                case 0:
                    return "E";

                default:
                    return "!";
            }
        }
    }
}
