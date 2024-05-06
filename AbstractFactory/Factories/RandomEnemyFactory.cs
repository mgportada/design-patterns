using Game;
using Game.Enemies;
using Game.Interfaces;

namespace AbstractFactory.Factories
{
    public class RandomEnemyFactory : IAbstractEnemyFactory
    {
        public IEnemy createEnemy()
        {
            // random enemy
            int random = new Random().Next(0, 3);
            switch (random)
            {
                case 0:
                    return new Goomba();
                case 1:
                    return new Koopa();
                case 2:
                    return new Boo();
                default:
                    return new Goomba();
            }
        }

    }
}
