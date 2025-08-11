
namespace RollDiceGame.Game
{
    public class Dice
    {
        private readonly Random _random;
        private readonly int SideCount = 6;

        public Dice(Random random)
        {
            _random = random;
        }
        public int Roll()
        {
            return _random.Next(1, SideCount + 1);
        }
        public void Describe() => Console.WriteLine($"This is a dice with {SideCount} sides.");
    }

}
