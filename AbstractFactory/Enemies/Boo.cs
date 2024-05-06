using Game.Interfaces;

namespace Game.Enemies
{
    public class Boo : IEnemy
    {
        public int attack()
        {
            return 10;
        }
    }
}
