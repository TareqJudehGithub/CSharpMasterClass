// See https://aka.ms/new-console-template for more information
using RollDiceGame.Game;

Console.WriteLine("RollDiceGame\n");

Random random = new Random();
Dice dice = new Dice(random);
GuessingGame guessingGame = new GuessingGame(dice);


GameResult gameResult = guessingGame.Play();
GuessingGame.PrintResult(gameResult);

Console.ReadKey();




