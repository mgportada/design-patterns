

using Game.Interfaces;

namespace AbstractFactory.Enemies
{
    internal class Cheep : IEnemy
    {
        public int attack()
        {
            Console.WriteLine("Cheep attacks using water gun");
            return 5;
        }
    }
}
