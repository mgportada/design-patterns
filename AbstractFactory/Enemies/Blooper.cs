

using Game.Interfaces;

namespace AbstractFactory.Enemies
{
    internal class Blooper : IEnemy
    {
        public int attack()
        {
            return 10;
        }
    }
}
