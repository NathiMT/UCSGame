using UCSGame.Base;

namespace UCSGame.Components
{
    internal class Enemy : Character
    {
        public Enemy(string name) 
        { 
            Name = name;
        }

        public override string GetFightingMove()
        {
            Random random = new Random();

            string option = random.Next(1, 4).ToString();

            return option;
        }
    }
}
