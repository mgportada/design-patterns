using AbstractFactory.Enemies;
using Game;
using Game.Enemies;
using Game.Interfaces;

namespace AbstractFactory.Factories
{
    public class UnderwaterEnemyFactory : IAbstractEnemyFactory
    {
        public IEnemy createEnemy()
        {
            // 70% chance of Cheep, 30% chance of Blooper
            int random = new Random().Next(0, 10);
            if (random < 7)
            {
                return new Cheep();
            }
            else
            {
                return new Blooper();
            }

        }
    }
}
