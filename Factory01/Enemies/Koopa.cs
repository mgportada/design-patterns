using Game.Interfaces;

namespace Game.Enemies
{
    public class Koopa : IEnemy
    {
        public int attack()
        {
            Console.WriteLine("Koopa attacks");
            return 15;
        }
    }
}
