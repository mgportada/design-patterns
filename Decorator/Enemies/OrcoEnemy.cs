namespace Decorator.Enemies
{
    public class OrcoEnemy : Enemy
    {
        public override int ComputeDamage(Attack receivedAttack)
        {
            int baseDamage = receivedAttack.BaseDamage;
            // Si el ataque es a la cabeza, aumentamos el daño
            if (receivedAttack.IsHeadAttack)
            {
                baseDamage *= 2; // Por ejemplo, aumenta en 10 el daño si es un ataque a la cabeza
            }
            return baseDamage;
        }
    }

}
