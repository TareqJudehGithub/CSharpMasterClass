
namespace RollDiceGame.UserCommunication
{
    // *** Change my location
    public static class ConsoleReader
    {
        public static int ReadInteger(string message)
        {
            int result;
            do
            {
                Console.Write(message);
            }
            while (!int.TryParse(Console.ReadLine(), out result));
            return result;
        }
    }

}
