
namespace Decorator
{
    public class Attack
    {
        public bool IsHeadAttack { get; set; }
        public int BaseDamage { get; set; }

        // Constructor
        public Attack(int baseDamage)
        {
            BaseDamage = baseDamage;
        }
    }

}
