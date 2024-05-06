

using Decorator.Enemies;

namespace Decorator.Decoradores
{
    public class DecoradorCasco : EnemyDecorator
    {
        public DecoradorCasco(Enemy enemy) : base(enemy) { }

        public override int ComputeDamage(Attack receivedAttack)
        {
            int baseDamage = base.ComputeDamage(receivedAttack);
            baseDamage -= 5;

            if (receivedAttack.IsHeadAttack)
            {
                return 0;
            }

            if (baseDamage < 0)
            {
                return 0;
            }

            return baseDamage;
        }
    }
}
