using Decorator.Enemies;

namespace Decorator.Decoradores
{
    public class DecoradorArmadura : EnemyDecorator
    {
        public DecoradorArmadura(Enemy enemy) : base(enemy) { }

        public override int ComputeDamage(Attack receivedAttack)
        {
            int baseDamage = base.ComputeDamage(receivedAttack);
            baseDamage -= 15;

            if (baseDamage < 0)
            {
                return 0;
            }

            return baseDamage;
        }
    }
}
