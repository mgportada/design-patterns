using Decorator.Decoradores;
using Decorator.Enemies;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos un enemigo Orco
            Enemy orco = new OrcoEnemy();

            // Decoramos al Orco con DoubleDamageDecorator
            Enemy orcoConArmadura = new DecoradorArmadura(orco);
            Enemy orcoConArmaduraYCasco = new DecoradorCasco(orcoConArmadura);

            PlayGame(orcoConArmaduraYCasco);
        }

        static void PlayGame(Enemy enemy)
        {
            for (int i = 0; i < 10; i++)
            {
                // random damage
                int baseDamage = new System.Random().Next(10, 70);
                Attack attack = new Attack(baseDamage);
                attack.IsHeadAttack = i % 2 == 0;

                int damage = enemy.ComputeDamage(attack);
                System.Console.WriteLine($"El enemigo ha recibido {damage} de daño");
            }
        }
    }
}