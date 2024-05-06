using AbstractFactory.Factories;
using Game.Interfaces;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GAME STARTED!");
            IAbstractEnemyFactory abstractEnemyFactory;
            RandomPowerUpFactory randomPowerUpFactory = new RandomPowerUpFactory();

            if (args.Length > 0 && args[0] == "land")
            {
                abstractEnemyFactory = new RandomEnemyFactory();
            }
            else
            {
                abstractEnemyFactory = new UnderwaterEnemyFactory();
            }

            Play(abstractEnemyFactory, randomPowerUpFactory);
        }

        public static void Play(IAbstractEnemyFactory randomEnemyFactory, RandomPowerUpFactory randomPowerUpFactory)
        {

            for (int i = 0; i < 10; i++)
            {
                // Random enemy 80% or PowerUp 20%
                int random = new Random().Next(0, 10);
                if (random < 6)
                {
                    IEnemy enemy = randomEnemyFactory.createEnemy();
                    enemy.attack();
                }
                else
                {
                    IPowerUp powerUp = randomPowerUpFactory.createPowerUp();
                    powerUp.usePowerUp();
                }


            }
        }
    }
}