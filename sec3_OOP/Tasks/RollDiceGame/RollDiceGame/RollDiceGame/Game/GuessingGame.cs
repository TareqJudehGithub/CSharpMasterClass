
using RollDiceGame.UserCommunication;

namespace RollDiceGame.Game
{
    public class GuessingGame
    {
        // A Dice object which should load at the begining of the game:
        private readonly Dice _dice;
        private const int initialTries = 3;

        public GuessingGame(Dice dice)
        {
            _dice = dice;
        }
        public GameResult Play()
        {
            int diceRollResult = _dice.Roll();
            Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries.");

            var triesLeft = initialTries;
            while (triesLeft > 0)
            {
                var guess = ConsoleReader.ReadInteger("Enter a number: ");

                if (guess == diceRollResult)
                {
                    Console.WriteLine("You win!");
                    return GameResult.Victory;
                }
                else
                {
                    Console.WriteLine("Wrong number. Try again.");
                    triesLeft--;
                }
            }
            return GameResult.Loss;
        }
        public static void PrintResult(GameResult gameResult)
        {
            string message = string.Empty;
            message = gameResult == GameResult.Victory ? "You win!" : "You lose :(";
            Console.WriteLine(message);
        }
    }

}
