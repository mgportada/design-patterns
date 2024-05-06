using Game.EnemyFactory;
using Game.Factories;
using Game.Interfaces;

namespace Game
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("GAME STARTED!");
            RandomEnemyFactory randomEnemyFactory = new RandomEnemyFactory();
            RandomPowerUpFactory randomPowerUpFactory = new RandomPowerUpFactory();

            Play(randomEnemyFactory, randomPowerUpFactory);
        }

        public static void Play(RandomEnemyFactory randomEnemyFactory, RandomPowerUpFactory randomPowerUpFactory)
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