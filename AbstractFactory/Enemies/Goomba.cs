using Game.Interfaces;

namespace Game.Enemies
{
    public class Goomba : IEnemy
    {
        public int attack()
        {
            Console.WriteLine("Goomba attacks using headbutt");
            return 5;
        }
    }
}
