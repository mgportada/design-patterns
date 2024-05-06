using Game.Interfaces;

namespace Game.Enemies
{
    public class Goomba : IEnemy
    {
        public int attack()
        {
            Console.WriteLine("Goomba attacks");
            return 5;
        }
    }
}
